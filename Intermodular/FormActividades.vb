Imports Configuracion
Imports Conexion
Imports System.Data.SqlClient
Imports Gestores
Imports Entidades
Imports FechaSencilla
Imports System.Security.AccessControl
Imports Cambios

Public Class FormActividades

    Private _Ajustes As New Ajustes()
    Private _Conector As New Conector(_Ajustes)

    Private _CambiosGuardados As Boolean = True

    Private Const _ConsultaActividades As String = "SELECT * FROM ACTIVIDAD"
    Private _GestorOriginal As New GestorEntidad(Of Actividad)
    Private _GestorNuevo As GestorEntidad(Of Actividad)

    Private Const _ConsultaCursos As String = "SELECT * FROM CURSO"
    Private _GestorCursos As New GestorEntidad(Of Curso)

    Private Const _ConsultaOrganizaciones As String = "SELECT * FROM ORGANIZACION"
    Private _GestorOrganizaciones As New GestorEntidad(Of Organizacion)

    Private _ActividadActual As Actividad

    Private Const _ConsultaBaseOds As String = "SELECT * FROM ODS"
    Private _ActividadesConOds As New Dictionary(Of Actividad, List(Of Ods))
    Private _OdsDisponiblesActividadActual As New List(Of Ods)
    Private _CambiosOdsActividad As New List(Of String)

    Private _GestorOds As New GestorEntidad(Of Ods)

    Private Const _ConsultaBaseVoluntarios As String = "SELECT * FROM VOLUNTARIO"
    Private _ActividadesConVoluntarios As New Dictionary(Of Actividad, List(Of Voluntario))
    Private _VoluntariosDisponiblesActividadActual As New List(Of Voluntario)
    Private _CambiosVoluntariosActividad As New List(Of String)

    Private _GestorVoluntarios As New GestorEntidad(Of Voluntario)

    Private Const _ConsultaBaseTipos As String = "SELECT * FROM TIPO"
    Private _ActividadesConTipos As New Dictionary(Of Actividad, List(Of Tipo))
    Private _TiposDisponiblesActividadActual As New List(Of Tipo)
    Private _CambiosTiposActividad As New List(Of String)
    Private _GestorTipos As New GestorEntidad(Of Tipo)

    Private _ValidacionDeFilaActiva As Boolean = False

    Private Sub FormActividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _Conector.Abrir()
        Using registrosCursos As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaCursos)
            While registrosCursos.Read()
                _GestorCursos.Insertar(New Curso(
                                    registrosCursos("ID"),
                                    registrosCursos("DESCRIPCION")
                                    ))
            End While
        End Using

        Using registrosOrganizaciones As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaOrganizaciones)
            While registrosOrganizaciones.Read()
                Dim apellido2ResponsableRelacionado As Object = registrosOrganizaciones("APELLIDO2_RESPONSABLE")
                Dim apellido2 As String = If(IsDBNull(apellido2ResponsableRelacionado), Nothing, apellido2ResponsableRelacionado.ToString())

                _GestorOrganizaciones.Insertar(New Organizacion(
                registrosOrganizaciones("ID"),
                registrosOrganizaciones("NOMBRE"),
                registrosOrganizaciones("NOMBRE_RESPONSABLE"),
                registrosOrganizaciones("APELLIDO1_RESPONSABLE"),
                apellido2,
                New Fecha(registrosOrganizaciones("FECHA_REGISTRO"), "d/m/a")
            ))
            End While
        End Using

        Using registrosActividad As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaActividades)
            While registrosActividad.Read()
                Dim idOrganizacionRelacionada As UInt16 = registrosActividad("CONVOCADA_POR")
                Dim organizacionRelacionada As Organizacion = _GestorOrganizaciones.Elementos.FirstOrDefault(Function(organizacion) organizacion.Id = idOrganizacionRelacionada)

                Dim idCursoRelacionado As Object = registrosActividad("TECNICO_DE")
                Dim cursoRelacionado As Curso = If(IsDBNull(idCursoRelacionado), Nothing, _GestorCursos.Elementos.FirstOrDefault(Function(curso) curso.Id = idCursoRelacionado))

                Dim fechaHoraInicio As DateTime = Actividad.UnirFechaYHora(registrosActividad("FECHA_INICIO"), registrosActividad("HORA_INICIO"))
                Dim fechaHoraFin As DateTime = Actividad.UnirFechaYHora(registrosActividad("FECHA_FIN"), registrosActividad("HORA_FIN"))

                _GestorOriginal.Insertar(New Actividad((registrosActividad("ID")), registrosActividad("NOMBRE"), registrosActividad("DESCRIPCION"), registrosActividad("ESTADO"), organizacionRelacionada, fechaHoraInicio, fechaHoraFin, cursoRelacionado))
            End While
        End Using

        Using registrosOds As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaBaseOds)
            While registrosOds.Read()
                _GestorOds.Insertar(New Ods(registrosOds("ID"), registrosOds("DESCRIPCION")))
            End While
        End Using

        Using registrosVoluntarios As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaBaseVoluntarios)
            While registrosVoluntarios.Read()
                Dim apellido2Leido As Object = registrosVoluntarios("APELLIDO2")
                Dim apellido2 As String = If(IsDBNull(apellido2Leido), Nothing, apellido2Leido)

                Dim idCursoVoluntario As UInt16 = registrosVoluntarios("ESTUDIA")
                Dim cursoVoluntario As Curso = _GestorCursos.Elementos.FirstOrDefault(Function(curso) curso.Id = idCursoVoluntario)

                Dim telefonoLeido As Object = registrosVoluntarios("TELEFONO")
                Dim telefono As String = If(IsDBNull(telefonoLeido), Nothing, telefonoLeido)

                Dim experienciaLeida As Object = registrosVoluntarios("EXPERIENCIA")
                Dim experiencia As String = If(IsDBNull(experienciaLeida) OrElse String.IsNullOrWhiteSpace(experienciaLeida), Nothing, experienciaLeida)
                _GestorVoluntarios.Insertar(New Voluntario(
                    registrosVoluntarios("NIF"),
                    registrosVoluntarios("NOMBRE"),
                    registrosVoluntarios("APELLIDO1"),
                    apellido2,
                    telefono,
                    cursoVoluntario,
                    registrosVoluntarios("CORREO"),
                    experiencia
                ))
            End While
        End Using

        Using registrosTipos As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaBaseTipos)
            While registrosTipos.Read()
                _GestorTipos.Insertar(New Tipo(
                    registrosTipos("ID"),
                    registrosTipos("DESCRIPCION")
                ))
            End While
        End Using
        _Conector.Cerrar()

        Me._GestorOriginal.Elementos.Sort()
        Me._GestorNuevo = _GestorOriginal.Clonar()

        _Conector.Abrir()
        For Each actividad As Actividad In _GestorNuevo.Elementos
            If Not _ActividadesConOds.ContainsKey(actividad) Then
                _ActividadesConOds.Add(actividad, New List(Of Ods))
            End If
            Using registroOdsRelacionadas As SqlDataReader = _Conector.EjecutarConsultaMutilple($"SELECT * FROM CUMPLE_CON WHERE ID_ACTIVIDAD = {actividad.Id}")
                While registroOdsRelacionadas.Read()
                    Dim idOds As Byte = registroOdsRelacionadas("ID_ODS")
                    _ActividadesConOds(actividad).Add(_GestorOds.Elementos.FirstOrDefault(Function(ods) ods.Id = idOds))
                End While
            End Using
        Next

        For Each actividad As Actividad In _GestorNuevo.Elementos
            If Not _ActividadesConVoluntarios.ContainsKey(actividad) Then
                _ActividadesConVoluntarios.Add(actividad, New List(Of Voluntario))
            End If
            Using registroVoluntariosRelacionados As SqlDataReader = _Conector.EjecutarConsultaMutilple($"SELECT NIF_VOLUNTARIO FROM REALIZA WHERE ID_ACTIVIDAD = {actividad.Id}")
                While registroVoluntariosRelacionados.Read()
                    Dim nifVoluntario As String = registroVoluntariosRelacionados("NIF_VOLUNTARIO").ToString()
                    Dim voluntarioEncontrado As Voluntario = _GestorVoluntarios.Elementos.FirstOrDefault(Function(vol) vol.Nif = nifVoluntario)
                    _ActividadesConVoluntarios(actividad).Add(voluntarioEncontrado)
                End While
            End Using
        Next

        For Each actividad As Actividad In _GestorNuevo.Elementos
            If Not _ActividadesConTipos.ContainsKey(actividad) Then
                _ActividadesConTipos.Add(actividad, New List(Of Tipo))
            End If
            Using registrosTiposRelacionados As SqlDataReader = _Conector.EjecutarConsultaMutilple($"SELECT ID_TIPO FROM ES_DE_TIPO WHERE ID_ACTIVIDAD = {actividad.Id}")
                While registrosTiposRelacionados.Read()
                    Dim idTipo As Byte = registrosTiposRelacionados("ID_TIPO")
                    _ActividadesConTipos(actividad).Add(_GestorTipos.Elementos.FirstOrDefault(Function(tipo) tipo.Id = idTipo))
                End While
            End Using
        Next
        _Conector.Cerrar()

        Dim valoresTecnicidad As New List(Of Curso) From {New Curso(Nothing, Nothing)}
        valoresTecnicidad.AddRange(_GestorCursos.Elementos)
        Me.cmbTecnicidad.DataSource = valoresTecnicidad
        Me.cmbTecnicidad.SelectedIndex = -1

        Me.cmbOrganizacionActividad.DataSource = _GestorOrganizaciones.Elementos()
        Me.cmbOrganizacionActividad.SelectedIndex = -1

        Me.cmbEstadoActividad.DataSource = Actividad.EstadosValidos
        Me.cmbEstadoActividad.SelectedIndex = -1

        Me.dgvActividades.DataSource = _GestorNuevo.Elementos()

        If dgvActividades.Rows.Count > 0 Then
            dgvActividades.CurrentCell = dgvActividades.Rows(0).Cells(0)
            AlSeleccionarFila(dgvActividades.Rows(0).Cells(0), Nothing)
        End If

        AsociarHandlerMostrarOdsRelacionadas()
        AsociarHandlerMostrarVoluntariosRelacionados()
        AsociarHandlerMostrarTiposRelacionados()
        AsociarHandlerCambioDeFila()
        AsociarHandlersAlSeleccionarFila()
    End Sub

    Private Sub AsociarHandlerMostrarTiposRelacionados()
        AddHandler dgvActividades.SelectionChanged, AddressOf MostrarTiposRelacionados
    End Sub

    Private Sub EliminarHandlerMostrarTiposRelacionados()
        RemoveHandler dgvActividades.SelectionChanged, AddressOf MostrarTiposRelacionados
    End Sub

    Private Sub AsociarHandlerMostrarVoluntariosRelacionados()
        AddHandler dgvActividades.SelectionChanged, AddressOf MostrarVoluntariosRelacionados
    End Sub

    Private Sub EliminarHandlerMostrarVoluntariosRelacionados()
        RemoveHandler dgvActividades.SelectionChanged, AddressOf MostrarVoluntariosRelacionados
    End Sub

    Private Sub AsociarHandlerMostrarOdsRelacionadas()
        AddHandler dgvActividades.SelectionChanged, AddressOf MostrarOdsRelacionadas
    End Sub

    Private Sub EliminarHandlerMostrarOdsRelacionadas()
        RemoveHandler dgvActividades.SelectionChanged, AddressOf MostrarOdsRelacionadas
    End Sub

    Private Sub AsociarHandlerCambioDeFila()
        _ValidacionDeFilaActiva = True
        AddHandler dgvActividades.RowValidating, AddressOf EntidadValida
    End Sub

    Private Sub EliminarHandlerCambioDeFila()
        _ValidacionDeFilaActiva = False
        RemoveHandler dgvActividades.RowValidating, AddressOf EntidadValida
    End Sub

    Private Sub AsociarHandlersAlSeleccionarFila()
        AddHandler dgvActividades.SelectionChanged, AddressOf AlSeleccionarFila
        AddHandler dgvActividades.CellContentClick, AddressOf AlSeleccionarFila
    End Sub

    Private Sub EliminarHandlersAlSeleccionarFila()
        RemoveHandler dgvActividades.SelectionChanged, AddressOf AlSeleccionarFila
        RemoveHandler dgvActividades.CellContentClick, AddressOf AlSeleccionarFila
    End Sub

    Private Sub AsociarHandlersCamposObligatorios()
        AddHandler txtNombreActividad.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtDescActividad.TextChanged, AddressOf AlCambiarContenido
        AddHandler cmbOrganizacionActividad.SelectedValueChanged, AddressOf AlCambiarContenido
        AddHandler cmbEstadoActividad.SelectedValueChanged, AddressOf AlCambiarContenido
        AddHandler dtpFechaInicio.ValueChanged, AddressOf AlCambiarContenido
        AddHandler dtpFechaFin.ValueChanged, AddressOf AlCambiarContenido
        AddHandler dtpHoraInicioActividad.ValueChanged, AddressOf AlCambiarContenido
        AddHandler dtpHoraFinActividad.ValueChanged, AddressOf AlCambiarContenido
        AddHandler cmbTecnicidad.SelectedValueChanged, AddressOf AlCambiarContenido
    End Sub

    Private Sub EliminarHandlersCamposObligatorios()
        RemoveHandler txtNombreActividad.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtDescActividad.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler cmbOrganizacionActividad.SelectedValueChanged, AddressOf AlCambiarContenido
        RemoveHandler cmbEstadoActividad.SelectedValueChanged, AddressOf AlCambiarContenido
        RemoveHandler dtpFechaInicio.ValueChanged, AddressOf AlCambiarContenido
        RemoveHandler dtpFechaFin.ValueChanged, AddressOf AlCambiarContenido
        RemoveHandler dtpHoraInicioActividad.ValueChanged, AddressOf AlCambiarContenido
        RemoveHandler dtpHoraFinActividad.ValueChanged, AddressOf AlCambiarContenido
        RemoveHandler cmbTecnicidad.SelectedValueChanged, AddressOf AlCambiarContenido
    End Sub

    Private Sub NuevaFila(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        _CambiosGuardados = False
        If EntidadValida() Then
            _GestorNuevo.InsertarElementoVacio()
            RecargarTabla(True)
            txtNombreActividad.Focus()
            If dgvActividades.Rows.Count = 1 Then
                dgvActividades.CurrentCell = dgvActividades.Rows(0).Cells(0)
                AlSeleccionarFila(dgvActividades.Rows(0).Cells(0), Nothing)
            Else
                dgvActividades.CurrentCell = dgvActividades.Rows(dgvActividades.Rows.Count - 1).Cells(0)
                AlSeleccionarFila(dgvActividades.Rows(0).Cells(0), Nothing)
            End If
        Else
            MessageBox.Show("Termina de modificar la actual actividad antes de añadir una nueva.")
        End If
    End Sub

    Private Sub EliminarFila() Handles tsbEliminar.Click
        _CambiosGuardados = False
        EliminarHandlersAlSeleccionarFila()
        Dim actividadSeleccionada As Actividad = TryCast(dgvActividades.CurrentRow.DataBoundItem, Actividad)
        Dim indiceFilaSeleccionada = _GestorNuevo.Elementos.IndexOf(actividadSeleccionada) - 1
        _GestorNuevo.Elementos.Remove(actividadSeleccionada)
        If indiceFilaSeleccionada > 0 Then
            dgvActividades.CurrentCell = dgvActividades.Rows(indiceFilaSeleccionada).Cells(0)
        End If
        RecargarTabla()
        AsociarHandlersAlSeleccionarFila()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        _CambiosGuardados = True
        If MessageBox.Show($"¿Seguro que quieres restaurar los cambios?{ControlChars.NewLine}Todo aquello no guardado se perderá de manera irreversible", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes) Then
            _GestorNuevo = _GestorOriginal.Clonar()
            dgvActividades.CancelEdit()

            _ActividadesConOds.Clear()
            _Conector.Abrir()
            For Each actividad In _GestorNuevo.Elementos
                If Not _ActividadesConOds.ContainsKey(actividad) Then
                    _ActividadesConOds.Add(actividad, New List(Of Ods))
                End If
                Using registroOdsRelacionadas As SqlDataReader = _Conector.EjecutarConsultaMutilple($"SELECT * FROM CUMPLE_CON WHERE ID_ACTIVIDAD = {actividad.Id}")
                    While registroOdsRelacionadas.Read()
                        Dim idOds As Byte = registroOdsRelacionadas("ID_ODS")
                        _ActividadesConOds(actividad).Add(_GestorOds.Elementos.FirstOrDefault(Function(ods) ods.Id = idOds))
                    End While
                End Using

                If Not _ActividadesConVoluntarios.ContainsKey(actividad) Then _ActividadesConVoluntarios.Add(actividad, New List(Of Voluntario))
                Using registroVoluntariosRelacionados As SqlDataReader = _Conector.EjecutarConsultaMutilple($"SELECT NIF_VOLUNTARIO FROM REALIZA WHERE ID_ACTIVIDAD = {actividad.Id}")
                    While registroVoluntariosRelacionados.Read()
                        Dim nifVoluntario As String = registroVoluntariosRelacionados("NIF_VOLUNTARIO")
                        _ActividadesConVoluntarios(actividad).Add(_GestorVoluntarios.Elementos.FirstOrDefault(Function(voluntario) voluntario.Nif = nifVoluntario))
                    End While
                End Using
            Next
            _Conector.Cerrar()
            _CambiosOdsActividad.Clear()
            _CambiosVoluntariosActividad.Clear()

            RecargarTabla()

            MostrarOdsRelacionadas()
            MostrarVoluntariosRelacionados()
            MostrarTiposRelacionados()
        End If
    End Sub

    Private Sub HabilitarBotonEliminar() Handles dgvActividades.SelectionChanged, dgvActividades.DataSourceChanged
        If dgvActividades.Rows.Count > 0 Then
            tsbEliminar.Enabled = True
        Else
            tsbEliminar.Enabled = False
        End If
    End Sub

    Private Sub LimpiarFilaVacia()
        _GestorNuevo.LimpiarElementoVacio()
    End Sub

    Private Sub FocoEnLaUltimaFila()
        If dgvActividades.Rows.Count > 0 Then
            dgvActividades.CurrentCell = dgvActividades.Rows(dgvActividades.Rows.Count - 1).Cells(0)
        ElseIf dgvActividades.Rows.Count = 1 Then
            dgvActividades.CurrentCell = dgvActividades.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub AlSeleccionarFila(sender As Object, e As EventArgs)
        EliminarHandlersCamposObligatorios()
        Dim actividadSeleccionada As Actividad = TryCast(dgvActividades.CurrentRow.DataBoundItem, Actividad)
        If actividadSeleccionada IsNot Nothing Then
            Me.txtIDActividad.Text = actividadSeleccionada.Id
            Me.txtNombreActividad.Text = actividadSeleccionada.Nombre
            Me.txtDescActividad.Text = actividadSeleccionada.Descripcion
            Me.cmbEstadoActividad.Text = actividadSeleccionada.Estado
            Me.cmbOrganizacionActividad.SelectedItem = actividadSeleccionada.ConvocadaPor
            Me.cmbEstadoActividad.Text = actividadSeleccionada.Estado
            Me.dtpFechaInicio.Value = actividadSeleccionada.FechaHoraInicio
            Me.dtpHoraInicioActividad.Value = actividadSeleccionada.FechaHoraInicio
            Me.dtpFechaFin.Value = actividadSeleccionada.FechaHoraFin.Date
            Me.dtpHoraFinActividad.Value = actividadSeleccionada.FechaHoraFin
            Me.cmbTecnicidad.SelectedItem = actividadSeleccionada.TecnicoDe
        Else
            Me.txtIDActividad.Text = ""
            Me.txtNombreActividad.Text = ""
            Me.txtDescActividad.Text = ""
            Me.cmbEstadoActividad.SelectedIndex = -1
            Me.cmbOrganizacionActividad.SelectedIndex = -1
            Me.cmbEstadoActividad.Text = ""
            Me.dtpFechaInicio.Value = DateTime.Now
            Me.dtpHoraInicioActividad.Value = DateTime.Now
            Me.dtpFechaFin.Value = DateTime.Now
            Me.dtpHoraFinActividad.Value = DateTime.Now + TimeSpan.FromHours(1)
            Me.cmbTecnicidad.SelectedIndex = -1
        End If
        AsociarHandlersCamposObligatorios()
    End Sub

    Private Sub AlCambiarContenido(sender As Object, e As EventArgs)
        _CambiosGuardados = False
        Dim actividadSeleccionada As Actividad = CType(dgvActividades.CurrentRow.DataBoundItem, Actividad)
        If actividadSeleccionada IsNot Nothing Then
            actividadSeleccionada.Nombre = txtNombreActividad.Text
            actividadSeleccionada.Descripcion = txtDescActividad.Text
            actividadSeleccionada.Estado = cmbEstadoActividad.SelectedValue
            actividadSeleccionada.ConvocadaPor = CType(cmbOrganizacionActividad.SelectedItem, Organizacion)
            actividadSeleccionada.FechaHoraInicio = Actividad.UnirFechaYHora(dtpFechaInicio.Value.Date, dtpHoraInicioActividad.Value.TimeOfDay)
            actividadSeleccionada.FechaHoraFin = Actividad.UnirFechaYHora(dtpFechaFin.Value.Date, dtpHoraFinActividad.Value.TimeOfDay)
            actividadSeleccionada.TecnicoDe = TryCast(cmbTecnicidad.SelectedItem, Curso)
            If Not _ValidacionDeFilaActiva Then RecargarTabla()
        Else
            actividadSeleccionada = New Actividad(
                Nothing,
                txtNombreActividad.Text,
                txtDescActividad.Text,
                "Pendiente",
                CType(cmbOrganizacionActividad.SelectedItem, Organizacion),
                Actividad.UnirFechaYHora(dtpFechaInicio.Value.Date, dtpHoraInicioActividad.Value.TimeOfDay),
                Actividad.UnirFechaYHora(dtpFechaFin.Value.Date, dtpHoraFinActividad.Value.TimeOfDay),
                TryCast(cmbTecnicidad.SelectedItem, Curso)
                )
            EliminarHandlerCambioDeFila()
            LimpiarFilaVacia()
            _GestorNuevo.Elementos.Add(actividadSeleccionada)
            If Not _ValidacionDeFilaActiva Then
                RecargarTabla()
                FocoEnLaUltimaFila()
            End If
            AsociarHandlerCambioDeFila()
        End If
    End Sub

    Private Sub RecargarTabla(Optional focoALaUltimiaFila As Boolean = False)
        EliminarHandlerMostrarOdsRelacionadas()
        EliminarHandlerMostrarVoluntariosRelacionados()
        EliminarHandlerMostrarTiposRelacionados()
        dgvActividades.CancelEdit()
        dgvActividades.DataSource = Nothing
        dgvActividades.DataSource = _GestorNuevo.Elementos()
        If focoALaUltimiaFila Then FocoEnLaUltimaFila()
        AsociarHandlerMostrarOdsRelacionadas()
        AsociarHandlerMostrarVoluntariosRelacionados()
        AsociarHandlerMostrarTiposRelacionados()
    End Sub

    Private Function EntidadValida() As Boolean
        If Not ComprobarCamposObligatorios() Then
            MessageBox.Show("Hay campos obligatorios que no están completos")
            Return False
        End If
        If dtpFechaFin.Value.Date < dtpFechaInicio.Value.Date Then
            MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio")
            Return False
        End If
        If dtpFechaFin.Value.Date = dtpFechaInicio.Value.Date Then
            If dtpHoraFinActividad.Value.TimeOfDay < dtpHoraInicioActividad.Value.TimeOfDay Then
                MessageBox.Show("La hora de fin no puede ser anterior a la hora de inicio dentro del mismo día")
                Return False
            ElseIf dtpHoraFinActividad.Value.TimeOfDay = dtpHoraInicioActividad.Value.TimeOfDay Then
                MessageBox.Show("La hora de fin no puede ser igual a la hora de inicio dentro del mismo día")
                Return False
            End If
        End If
        Return True
    End Function

    Private Sub EntidadValida(sender As Object, e As DataGridViewCellCancelEventArgs)
        If Not ComprobarCamposObligatorios() Then
            MessageBox.Show("Hay campos obligatorios que no están completos")
            e.Cancel = True
        End If
        If dtpFechaFin.Value.Date < dtpFechaInicio.Value.Date Then
            MessageBox.Show("La fecha de fin no puede ser anterior a la fecha de inicio")
            e.Cancel = True
        End If
        If dtpFechaFin.Value.Date = dtpFechaInicio.Value.Date Then
            If dtpHoraFinActividad.Value.TimeOfDay < dtpHoraInicioActividad.Value.TimeOfDay Then
                MessageBox.Show("La hora de fin no puede ser anterior a la hora de inicio dentro del mismo día")
                e.Cancel = True
            ElseIf dtpHoraFinActividad.Value.TimeOfDay = dtpHoraInicioActividad.Value.TimeOfDay Then
                MessageBox.Show("La hora de fin no puede ser igual a la hora de inicio dentro del mismo día")
                e.Cancel = True
            End If
        End If
    End Sub

    Private Function ComprobarCamposObligatorios() As Boolean
        If txtNombreActividad.Text = "" OrElse String.IsNullOrWhiteSpace(txtNombreActividad.Text) Then Return False
        For Each control As Control In _ControlesObligatorios
            If TypeOf control Is ComboBox Then
                If CType(control, ComboBox).SelectedIndex = -1 Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Sub MostrarOdsRelacionadas(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing)
        _ActividadActual = TryCast(dgvActividades.CurrentRow.DataBoundItem, Actividad)
        _OdsDisponiblesActividadActual = _GestorOds.ClonarElementos()
        For Each ods As Ods In _ActividadesConOds(_ActividadActual)
            If _OdsDisponiblesActividadActual.Contains(ods) Then
                _OdsDisponiblesActividadActual.Remove(ods)
            End If
        Next
        _OdsDisponiblesActividadActual.Sort()
        _ActividadesConOds(_ActividadActual).Sort()
        lstOdsDisponibles.DataSource = Nothing
        lstOdsAsignados.DataSource = Nothing
        lstOdsDisponibles.DataSource = _OdsDisponiblesActividadActual
        lstOdsAsignados.DataSource = _ActividadesConOds(_ActividadActual)
    End Sub

    Private Sub MostrarVoluntariosRelacionados(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing)
        _ActividadActual = TryCast(dgvActividades.CurrentRow.DataBoundItem, Actividad)
        _VoluntariosDisponiblesActividadActual = _GestorVoluntarios.ClonarElementos()
        For Each voluntario In _ActividadesConVoluntarios(_ActividadActual)
            If _ActividadesConVoluntarios(_ActividadActual).Contains(voluntario) Then
                _VoluntariosDisponiblesActividadActual.Remove(voluntario)
            End If
        Next
        _VoluntariosDisponiblesActividadActual.Sort()
        _ActividadesConVoluntarios(_ActividadActual).Sort()
        lstVoluntariosDisponibles.DataSource = Nothing
        lstVoluntariosAsignados.DataSource = Nothing
        lstVoluntariosDisponibles.DataSource = _VoluntariosDisponiblesActividadActual
        lstVoluntariosAsignados.DataSource = _ActividadesConVoluntarios(_ActividadActual)
    End Sub

    Private Sub MostrarTiposRelacionados(Optional sender As Object = Nothing, Optional e As EventArgs = Nothing)
        _ActividadActual = TryCast(dgvActividades.CurrentRow.DataBoundItem, Actividad)
        _TiposDisponiblesActividadActual = _GestorTipos.ClonarElementos()
        For Each tipo As Tipo In _ActividadesConTipos(_ActividadActual)
            If _TiposDisponiblesActividadActual.Contains(tipo) Then
                _TiposDisponiblesActividadActual.Remove(tipo)
            End If
        Next
        _TiposDisponiblesActividadActual.Sort()
        _ActividadesConTipos(_ActividadActual).Sort()
        lstTiposDisponibles.DataSource = Nothing
        lstTiposAsignados.DataSource = Nothing
        lstTiposDisponibles.DataSource = _TiposDisponiblesActividadActual
        lstTiposAsignados.DataSource = _ActividadesConTipos(_ActividadActual)
    End Sub

    Private Sub btnAnadirOds_Click(sender As Object, e As EventArgs) Handles btnAnadirOds.Click
        _CambiosGuardados = False
        Dim odsParaAgregar As Ods = TryCast(lstOdsDisponibles.SelectedItem, Ods)
        If odsParaAgregar IsNot Nothing Then
            _OdsDisponiblesActividadActual.Remove(odsParaAgregar)
            _ActividadesConOds(_ActividadActual).Add(odsParaAgregar)
            _OdsDisponiblesActividadActual.Sort()
            _ActividadesConOds(_ActividadActual).Sort()
            lstOdsDisponibles.DataSource = Nothing
            lstOdsAsignados.DataSource = Nothing
            lstOdsDisponibles.DataSource = _OdsDisponiblesActividadActual
            lstOdsAsignados.DataSource = _ActividadesConOds(_ActividadActual)
            If Not _CambiosOdsActividad.Contains($"DELETE CUMPLE_CON WHERE ID_ACTIVIDAD = ({CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, {odsParaAgregar.Id})") Then
                _CambiosOdsActividad.Add($"ASOCIAR_CUMPLE_CON {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, {odsParaAgregar.Id}")
            Else
                _CambiosOdsActividad.Remove($"DELETE CUMPLE_CON WHERE ID_ACTIVIDAD = ({CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, {odsParaAgregar.Id})")
            End If
        End If
    End Sub

    Private Sub btnQuitarOds_Click(sender As Object, e As EventArgs) Handles btnQuitarOds.Click
        _CambiosGuardados = False
        Dim odsParaEliminar As Ods = TryCast(lstOdsAsignados.SelectedItem, Ods)
        If odsParaEliminar IsNot Nothing Then
            _ActividadesConOds(_ActividadActual).Remove(odsParaEliminar)
            _OdsDisponiblesActividadActual.Add(odsParaEliminar)
            _OdsDisponiblesActividadActual.Sort()
            _ActividadesConOds(_ActividadActual).Sort()
            lstOdsDisponibles.DataSource = Nothing
            lstOdsAsignados.DataSource = Nothing
            lstOdsDisponibles.DataSource = _OdsDisponiblesActividadActual
            lstOdsAsignados.DataSource = _ActividadesConOds(_ActividadActual)
            If Not _CambiosOdsActividad.Contains($"ASOCIAR_CUMPLE_CON {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, {odsParaEliminar.Id}") Then
                _CambiosOdsActividad.Add($"DELETE FROM CUMPLE_CON WHERE ID_ACTIVIDAD = {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id} And ID_ODS = {odsParaEliminar.Id}")
            Else _CambiosOdsActividad.Remove($"ASOCIAR_CUMPLE_CON {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, {odsParaEliminar.Id}")
            End If
        End If
    End Sub

    Private Sub btnAnadirVoluntario_Click(sender As Object, e As EventArgs) Handles btnAnadirVoluntario.Click
        _CambiosGuardados = False
        Dim voluntarioParaAgregar As Voluntario = TryCast(lstVoluntariosDisponibles.SelectedItem, Voluntario)
        If voluntarioParaAgregar IsNot Nothing Then
            _VoluntariosDisponiblesActividadActual.Remove(voluntarioParaAgregar)
            _ActividadesConVoluntarios(_ActividadActual).Add(voluntarioParaAgregar)
            _VoluntariosDisponiblesActividadActual.Sort()
            _ActividadesConVoluntarios(_ActividadActual).Sort()
            lstVoluntariosDisponibles.DataSource = Nothing
            lstVoluntariosAsignados.DataSource = Nothing
            lstVoluntariosDisponibles.DataSource = _VoluntariosDisponiblesActividadActual
            lstVoluntariosAsignados.DataSource = _ActividadesConVoluntarios(_ActividadActual)
            If Not _CambiosVoluntariosActividad.Contains($"DELETE FROM REALIZA WHERE ID_ACTIVIDAD = {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id} And NIF_VOLUNTARIO = '{voluntarioParaAgregar.Nif}'") Then
                _CambiosVoluntariosActividad.Add($"ASOCIAR_REALIZA {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, '{voluntarioParaAgregar.Nif}'")
            Else _CambiosVoluntariosActividad.Remove($"DELETE FROM REALIZA WHERE ID_ACTIVIDAD = {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id} And NIF_VOLUNTARIO = '{voluntarioParaAgregar.Nif}'")
            End If
        End If
    End Sub

    Private Sub btnQuitarVoluntario_Click(sender As Object, e As EventArgs) Handles btnQuitarVoluntario.Click
        _CambiosGuardados = False
        Dim voluntarioParaEliminar As Voluntario = TryCast(lstVoluntariosAsignados.SelectedItem, Voluntario)
        If voluntarioParaEliminar IsNot Nothing Then
            _ActividadesConVoluntarios(_ActividadActual).Remove(voluntarioParaEliminar)
            _VoluntariosDisponiblesActividadActual.Add(voluntarioParaEliminar)
            _VoluntariosDisponiblesActividadActual.Sort()
            _ActividadesConVoluntarios(_ActividadActual).Sort()
            lstVoluntariosDisponibles.DataSource = Nothing
            lstVoluntariosAsignados.DataSource = Nothing
            lstVoluntariosDisponibles.DataSource = _VoluntariosDisponiblesActividadActual
            lstVoluntariosAsignados.DataSource = _ActividadesConVoluntarios(_ActividadActual)
            If Not _CambiosVoluntariosActividad.Contains($"ASOCIAR_REALIZA {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, '{voluntarioParaEliminar.Nif}'") Then
                _CambiosVoluntariosActividad.Add($"DELETE FROM REALIZA WHERE ID_ACTIVIDAD = {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id} AND NIF_VOLUNTARIO = '{voluntarioParaEliminar.Nif}'")
            Else
                _CambiosVoluntariosActividad.Remove($"ASOCIAR_REALIZA {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, '{voluntarioParaEliminar.Nif}'")
            End If
        End If
    End Sub

    Private Sub btnAnadirTipo_Click(sender As Object, e As EventArgs) Handles btnAnadirTipo.Click
        _CambiosGuardados = False
        Dim tipoParaAgregar As Tipo = TryCast(lstTiposDisponibles.SelectedItem, Tipo)
        If tipoParaAgregar IsNot Nothing Then
            _TiposDisponiblesActividadActual.Remove(tipoParaAgregar)
            _ActividadesConTipos(_ActividadActual).Add(tipoParaAgregar)
            _TiposDisponiblesActividadActual.Sort()
            _ActividadesConTipos(_ActividadActual).Sort()
            lstTiposDisponibles.DataSource = Nothing
            lstTiposAsignados.DataSource = Nothing
            lstTiposDisponibles.DataSource = _TiposDisponiblesActividadActual
            lstTiposAsignados.DataSource = _ActividadesConTipos(_ActividadActual)
            If Not _CambiosTiposActividad.Contains($"DELETE FROM ES_DE_TIPO WHERE ID_ACTIVIDAD = {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id} And ID_TIPO = {tipoParaAgregar.Id}") Then
                _CambiosTiposActividad.Add($"ASOCIAR_ES_DE_TIPO {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, {tipoParaAgregar.Id}")
            Else
                _CambiosTiposActividad.Remove($"DELETE FROM ES_DE_TIPO WHERE ID_ACTIVIDAD = {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id} And ID_TIPO = {tipoParaAgregar.Id}")
            End If
        End If
    End Sub

    Private Sub btnQuitarTipo_Click(sender As Object, e As EventArgs) Handles btnQuitarTipo.Click
        _CambiosGuardados = False
        Dim tipoParaeliminar As Tipo = TryCast(lstTiposAsignados.SelectedItem, Tipo)
        If tipoParaeliminar IsNot Nothing Then
            _ActividadesConTipos(_ActividadActual).Remove(tipoParaeliminar)
            _TiposDisponiblesActividadActual.Add(tipoParaeliminar)
            _TiposDisponiblesActividadActual.Sort()
            _ActividadesConTipos(_ActividadActual).Sort()
            lstTiposDisponibles.DataSource = Nothing
            lstTiposAsignados.DataSource = Nothing
            lstTiposDisponibles.DataSource = _TiposDisponiblesActividadActual
            lstTiposAsignados.DataSource = _ActividadesConTipos(_ActividadActual)
            If Not _CambiosTiposActividad.Contains($"ASOCIAR_ES_DE_TIPO {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, {tipoParaeliminar.Id}") Then
                _CambiosTiposActividad.Add($"DELETE FROM ES_DE_TIPO WHERE ID_ACTIVIDAD = {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id} AND ID_TIPO = {tipoParaeliminar.Id}")
            Else
                _CambiosTiposActividad.Remove($"ASOCIAR_ES_DE_TIPO {CType(dgvActividades.CurrentRow.DataBoundItem, Actividad).Id}, {tipoParaeliminar.Id}")
            End If
        End If
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        If MessageBox.Show("¿Seguro que quieres guardar los cambios?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes) Then
            If EntidadValida() Then
                Dim gestorCambios As New GestorCambios(Of Actividad)(_GestorOriginal, _GestorNuevo)
                gestorCambios.ProcesarCambios()

                _Conector.Abrir()
                For Each cambio As String In _CambiosOdsActividad
                    _Conector.EjecutarModificacion(cambio)
                Next
                For Each cambio As String In _CambiosVoluntariosActividad
                    _Conector.EjecutarModificacion(cambio)
                Next
                For Each cambio As String In _CambiosTiposActividad
                    _Conector.EjecutarModificacion(cambio)
                Next
                For Each cambio As String In gestorCambios.Sentencias
                    _Conector.EjecutarModificacion(cambio)
                Next
                _Conector.Cerrar()
                MessageBox.Show("Cambios guardados correctamente. A continuación se cerrará el formulario", "Guardado")
                _CambiosGuardados = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub FormActividad_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If Not _CambiosGuardados Then
            Dim respuesta As DialogResult = MessageBox.Show("¿Quieres guardar los cambios antes de salir?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If respuesta.Equals(DialogResult.Yes) Then
                If EntidadValida() Then
                    Dim gestorCambios As New GestorCambios(Of Actividad)(_GestorOriginal, _GestorNuevo)
                    gestorCambios.ProcesarCambios()

                    _Conector.Abrir()
                    For Each cambio As String In _CambiosOdsActividad
                        _Conector.EjecutarModificacion(cambio)
                    Next
                    For Each cambio As String In _CambiosVoluntariosActividad
                        _Conector.EjecutarModificacion(cambio)
                    Next
                    For Each cambio As String In _CambiosTiposActividad
                        _Conector.EjecutarModificacion(cambio)
                    Next
                    For Each cambio As String In gestorCambios.Sentencias
                        _Conector.EjecutarModificacion(cambio)
                    Next
                    _Conector.Cerrar()
                    _CambiosGuardados = True
                    Me.Close()
                End If
            ElseIf respuesta.Equals(DialogResult.No) Then
                _CambiosGuardados = True
                MyBase.Close()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub dgvActividades_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvActividades.CellContentClick

    End Sub
End Class