Imports System.Data.SqlClient
Imports Configuracion
Imports Conexion
Imports Gestores
Imports Entidades
Imports Cambios
Imports System.Text.RegularExpressions

Public Class FormVoluntario
    Inherits System.Windows.Forms.Form

    Private _Ajustes As New Ajustes()
    Private _Conector As New Conector(_Ajustes)
    Private _CambiosGuardados As Boolean = True

    Private Const _ConsultaVoluntarios As String = "SELECT * FROM VOLUNTARIO"
    Private Const _ConsultaCursos As String = "SELECT * FROM CURSO"
    Private Const _ConsultaTipos As String = "SELECT * FROM TIPO"
    Private Const _ConsultaDias As String = "SELECT * FROM DIA"
    Private Const _ConsultaHoras As String = "SELECT * FROM HORA"

    Private _GestorOriginal As New GestorEntidad(Of Voluntario)
    Private _GestorNuevo As GestorEntidad(Of Voluntario)
    Private _GestorCursos As New GestorEntidad(Of Curso)
    Private _GestorTipos As New GestorEntidad(Of Tipo)
    Private _GestorDias As New GestorEntidad(Of Dia)
    Private _GestorHoras As New GestorEntidad(Of Hora)

    Private _VoluntariosConIntereses As New Dictionary(Of Voluntario, List(Of Tipo))
    Private _TiposDisponiblesVoluntarioActual As New List(Of Tipo)
    Private _CambiosIntereses As New List(Of String)

    Private _VoluntariosConDisponibilidad As New Dictionary(Of Voluntario, List(Of Hora))
    Private _HorasDisponiblesDiaActual As New List(Of Hora)
    Private _CambiosDisponibilidad As New List(Of String)

    Private _VoluntarioActual As Voluntario

    Private _ValidacionDeFilaActiva As Boolean = False
    Private _ControlesObligatorios As Control() = {Me.txtNif, Me.txtNombre, Me.txtApellido1, Me.txtCorreo, Me.cmbCurso}

    Private Sub FormVoluntario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvVoluntarios.Enabled = False
        tabDetalles.Enabled = False

        Try
            _Conector.Abrir()

            Using registrosCursos As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaCursos)
                While registrosCursos.Read()
                    _GestorCursos.Insertar(New Curso(Convert.ToInt32(registrosCursos("ID")), registrosCursos("DESCRIPCION").ToString()))
                End While
            End Using

            Using registrosTipos As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaTipos)
                While registrosTipos.Read()
                    _GestorTipos.Insertar(New Tipo(Convert.ToInt32(registrosTipos("ID")), registrosTipos("DESCRIPCION").ToString()))
                End While
            End Using
            _GestorTipos.Elementos.Sort()

            Using registrosDias As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaDias)
                While registrosDias.Read()
                    _GestorDias.Insertar(New Dia(registrosDias("DESCRIPCION").ToString()))
                End While
            End Using

            Using registrosHoras As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaHoras)
                While registrosHoras.Read()
                    Dim diaDesc As String = registrosHoras("DIA").ToString()
                    Dim diaObj As Dia = _GestorDias.Elementos.FirstOrDefault(Function(d) d.Descripcion.Equals(diaDesc, StringComparison.OrdinalIgnoreCase))
                    If diaObj IsNot Nothing Then
                        Dim horaInicioTimeSpan As TimeSpan = CType(registrosHoras("HORA_INICIO"), TimeSpan)
                        Dim horaFinTimeSpan As TimeSpan = CType(registrosHoras("HORA_FIN"), TimeSpan)
                        Dim fechaBase As DateTime = DateTime.Today
                        Dim horaInicioDT As DateTime = fechaBase + horaInicioTimeSpan
                        Dim horaFinDT As DateTime = fechaBase + horaFinTimeSpan
                        _GestorHoras.Insertar(New Hora(diaObj, horaInicioDT, horaFinDT))
                    End If
                End While
            End Using
            _GestorHoras.Elementos.Sort()

            Using registrosVoluntarios As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaVoluntarios)
                While registrosVoluntarios.Read()
                    Dim apellido2Obj As Object = registrosVoluntarios("APELLIDO2")
                    Dim apellido2 As String = If(IsDBNull(apellido2Obj), Nothing, apellido2Obj.ToString())
                    Dim telefonoObj As Object = registrosVoluntarios("TELEFONO")
                    Dim telefono As String = If(IsDBNull(telefonoObj), Nothing, telefonoObj.ToString())
                    Dim experienciaObj As Object = registrosVoluntarios("EXPERIENCIA")
                    Dim experiencia As String = If(IsDBNull(experienciaObj), Nothing, experienciaObj.ToString())
                    Dim idCurso As Integer = Convert.ToInt32(registrosVoluntarios("ESTUDIA"))
                    Dim cursoObj As Curso = _GestorCursos.Elementos.FirstOrDefault(Function(c) c.Id = idCurso)

                    Dim vol = New Voluntario(
                        registrosVoluntarios("NIF").ToString(),
                        registrosVoluntarios("NOMBRE").ToString(),
                        registrosVoluntarios("APELLIDO1").ToString(),
                        apellido2,
                        registrosVoluntarios("CORREO").ToString(),
                        cursoObj,
                        telefono,
                        experiencia
                    )
                    _GestorOriginal.Insertar(vol)
                End While
            End Using

            For Each vol As Voluntario In _GestorOriginal.Elementos
                _VoluntariosConIntereses.Add(vol, New List(Of Tipo))
                Dim consultaIntereses As String = $"SELECT ID_TIPO FROM INTERES WHERE NIF_VOLUNTARIO = '{vol.Nif}'"
                Using regIntereses As SqlDataReader = _Conector.EjecutarConsultaMutilple(consultaIntereses)
                    While regIntereses.Read()
                        Dim idTipo As Integer = Convert.ToInt32(regIntereses("ID_TIPO"))
                        Dim tipoObj As Tipo = _GestorTipos.Elementos.FirstOrDefault(Function(t) t.Id = idTipo)
                        If tipoObj IsNot Nothing Then
                            _VoluntariosConIntereses(vol).Add(tipoObj)
                        End If
                    End While
                End Using
                _VoluntariosConIntereses(vol).Sort()

                _VoluntariosConDisponibilidad.Add(vol, New List(Of Hora))
                Dim consultaDisponibilidad As String = $"SELECT DIA, HORA_INICIO, HORA_FIN FROM DISPONE_DE WHERE NIF_VOLUNTARIO = '{vol.Nif}'"
                Using regDisponibilidad As SqlDataReader = _Conector.EjecutarConsultaMutilple(consultaDisponibilidad)
                    While regDisponibilidad.Read()
                        Dim diaDesc As String = regDisponibilidad("DIA").ToString()
                        Dim horaInicioTimeSpan As TimeSpan = CType(regDisponibilidad("HORA_INICIO"), TimeSpan)
                        Dim horaFinTimeSpan As TimeSpan = CType(regDisponibilidad("HORA_FIN"), TimeSpan)
                        Dim horaObj As Hora = _GestorHoras.Elementos.FirstOrDefault(
                            Function(h)
                                Return h.Dia.Descripcion.Equals(diaDesc, StringComparison.OrdinalIgnoreCase) AndAlso
                                       h.HoraInicio.TimeOfDay = horaInicioTimeSpan AndAlso
                                       h.HoraFin.TimeOfDay = horaFinTimeSpan
                            End Function)
                        If horaObj IsNot Nothing Then
                            _VoluntariosConDisponibilidad(vol).Add(horaObj)
                        End If
                    End While
                End Using
                _VoluntariosConDisponibilidad(vol).Sort()
            Next

        Catch ex As Exception
            MessageBox.Show($"Error al cargar datos iniciales: {ex.Message}", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            _Conector.Cerrar()
        End Try

        _GestorOriginal.Elementos.Sort()
        _GestorNuevo = _GestorOriginal.Clonar()

        Me.dgvVoluntarios.AutoGenerateColumns = False
        Me.dgvVoluntarios.DataSource = _GestorNuevo.Elementos()

        Me.cmbCurso.DataSource = _GestorCursos.Elementos
        Me.cmbCurso.DisplayMember = "Descripcion"
        Me.cmbCurso.ValueMember = "Id"
        Me.cmbCurso.SelectedIndex = -1

        Me.cmbDiaDisponibilidad.DataSource = _GestorDias.Elementos
        Me.cmbDiaDisponibilidad.DisplayMember = "Descripcion"
        Me.cmbDiaDisponibilidad.SelectedIndex = -1

        AsociarHandlersAlSeleccionarFila()
        AsociarHandlerCambioDeFila()
        AddHandler cmbDiaDisponibilidad.SelectedIndexChanged, AddressOf ActualizarListasDisponibilidad
        ActualizarEstadoBotones()

        dgvVoluntarios.Enabled = True
        tabDetalles.Enabled = True
    End Sub

    Private Sub FormVoluntario_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If dgvVoluntarios.Rows.Count > 0 Then
            dgvVoluntarios.CurrentCell = dgvVoluntarios.Rows(0).Cells(0)
            AlSeleccionarFila(dgvVoluntarios, EventArgs.Empty)
        Else
            LimpiarControlesDetalle()
            LimpiarYDeshabilitarListasRelacionadas()
        End If
        Me.dgvVoluntarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub AsociarHandlersCamposObligatorios()
        AddHandler txtNif.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtNombre.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtApellido1.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtApellido2.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtTelefono.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtCorreo.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtExperiencia.TextChanged, AddressOf AlCambiarContenido
        AddHandler cmbCurso.SelectedValueChanged, AddressOf AlCambiarContenido
    End Sub

    Private Sub EliminarHandlersCamposObligatorios()
        RemoveHandler txtNif.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtNombre.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtApellido1.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtApellido2.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtTelefono.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtCorreo.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtExperiencia.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler cmbCurso.SelectedValueChanged, AddressOf AlCambiarContenido
    End Sub

    Private Sub AsociarHandlersAlSeleccionarFila()
        AddHandler dgvVoluntarios.SelectionChanged, AddressOf AlSeleccionarFila
        AddHandler dgvVoluntarios.CellContentClick, AddressOf AlSeleccionarFila
    End Sub

    Private Sub EliminarHandlersAlSeleccionarFila()
        RemoveHandler dgvVoluntarios.SelectionChanged, AddressOf AlSeleccionarFila
        RemoveHandler dgvVoluntarios.CellContentClick, AddressOf AlSeleccionarFila
    End Sub

    Private Sub AsociarHandlerCambioDeFila()
        _ValidacionDeFilaActiva = True
        AddHandler dgvVoluntarios.RowValidating, AddressOf EntidadValidaHandler
    End Sub

    Private Sub EliminarHandlerCambioDeFila()
        _ValidacionDeFilaActiva = False
        RemoveHandler dgvVoluntarios.RowValidating, AddressOf EntidadValidaHandler
    End Sub

    Private Sub AlSeleccionarFila(sender As Object, e As EventArgs)
        If dgvVoluntarios.CurrentRow Is Nothing Then
            LimpiarControlesDetalle()
            LimpiarYDeshabilitarListasRelacionadas()
            _VoluntarioActual = Nothing
            Return
        End If

        EliminarHandlersCamposObligatorios()
        _VoluntarioActual = TryCast(dgvVoluntarios.CurrentRow.DataBoundItem, Voluntario)

        If _VoluntarioActual IsNot Nothing Then
            Me.txtNif.Text = _VoluntarioActual.Nif
            Me.txtNombre.Text = _VoluntarioActual.Nombre
            Me.txtApellido1.Text = _VoluntarioActual.Apellido1
            Me.txtApellido2.Text = If(_VoluntarioActual.Apellido2 Is Nothing, "", _VoluntarioActual.Apellido2)
            Me.txtTelefono.Text = If(_VoluntarioActual.Telefono Is Nothing, "", _VoluntarioActual.Telefono)
            Me.txtCorreo.Text = _VoluntarioActual.Correo
            Me.txtExperiencia.Text = If(_VoluntarioActual.Experiencia Is Nothing, "", _VoluntarioActual.Experiencia)
            Me.cmbCurso.SelectedItem = _VoluntarioActual.Estudia

            MostrarInteresesRelacionados()
            ActualizarListasDisponibilidad(sender, e)

        Else
            LimpiarControlesDetalle()
            LimpiarYDeshabilitarListasRelacionadas()
        End If
        AsociarHandlersCamposObligatorios()
    End Sub

    Private Sub LimpiarControlesDetalle()
        Me.txtNif.Text = ""
        Me.txtNombre.Text = ""
        Me.txtApellido1.Text = ""
        Me.txtApellido2.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtCorreo.Text = ""
        Me.txtExperiencia.Text = ""
        Me.cmbCurso.SelectedIndex = -1
    End Sub

    Private Sub LimpiarYDeshabilitarListasRelacionadas()
        lstTiposDisponibles.DataSource = Nothing
        lstTiposInteresado.DataSource = Nothing
        lstTiposDisponibles.Enabled = False
        lstTiposInteresado.Enabled = False
        btnAnadirInteres.Enabled = False
        btnQuitarInteres.Enabled = False

        lstHorasDisponiblesDia.DataSource = Nothing
        lstHorasAsignadasDia.DataSource = Nothing
        lstHorasDisponiblesDia.Enabled = False
        lstHorasAsignadasDia.Enabled = False
        btnAnadirDisponibilidad.Enabled = False
        btnQuitarDisponibilidad.Enabled = False
        cmbDiaDisponibilidad.SelectedIndex = -1
        cmbDiaDisponibilidad.Enabled = False
    End Sub

    Private Sub AlCambiarContenido(sender As Object, e As EventArgs)
        If _ValidacionDeFilaActiva AndAlso dgvVoluntarios.CurrentRow Is Nothing Then Exit Sub

        _CambiosGuardados = False
        ActualizarEstadoBotones()

        Dim volSeleccionado As Voluntario = Nothing
        If dgvVoluntarios.CurrentRow IsNot Nothing Then
            volSeleccionado = TryCast(dgvVoluntarios.CurrentRow.DataBoundItem, Voluntario)
        End If

        If volSeleccionado IsNot Nothing AndAlso Not String.IsNullOrEmpty(volSeleccionado.Nif) Then
            volSeleccionado.Nombre = txtNombre.Text
            volSeleccionado.Apellido1 = txtApellido1.Text
            volSeleccionado.Apellido2 = If(String.IsNullOrWhiteSpace(txtApellido2.Text), Nothing, txtApellido2.Text)
            volSeleccionado.Telefono = If(String.IsNullOrWhiteSpace(txtTelefono.Text), Nothing, txtTelefono.Text)
            volSeleccionado.Correo = txtCorreo.Text
            volSeleccionado.Experiencia = If(String.IsNullOrWhiteSpace(txtExperiencia.Text), Nothing, txtExperiencia.Text)
            volSeleccionado.Estudia = TryCast(cmbCurso.SelectedItem, Curso)
            If volSeleccionado.Nif <> txtNif.Text AndAlso Not String.IsNullOrEmpty(volSeleccionado.Nif) Then
                txtNif.Text = volSeleccionado.Nif
            End If

            If Not _ValidacionDeFilaActiva Then RecargarTabla()
        Else
            If _GestorNuevo.Elementos.Count > 0 AndAlso (_GestorNuevo.Elementos.LastOrDefault() Is Nothing OrElse String.IsNullOrEmpty(_GestorNuevo.Elementos.LastOrDefault().Nif)) Then
                Dim nuevoVol As New Voluntario(
                    txtNif.Text,
                    txtNombre.Text,
                    txtApellido1.Text,
                    If(String.IsNullOrWhiteSpace(txtApellido2.Text), Nothing, txtApellido2.Text),
                    txtCorreo.Text,
                    TryCast(cmbCurso.SelectedItem, Curso),
                    If(String.IsNullOrWhiteSpace(txtTelefono.Text), Nothing, txtTelefono.Text),
                    If(String.IsNullOrWhiteSpace(txtExperiencia.Text), Nothing, txtExperiencia.Text)
                )
                EliminarHandlerCambioDeFila()
                LimpiarFilaVacia()
                _GestorNuevo.Elementos.Add(nuevoVol)
                If Not _VoluntariosConIntereses.ContainsKey(nuevoVol) Then _VoluntariosConIntereses.Add(nuevoVol, New List(Of Tipo))
                If Not _VoluntariosConDisponibilidad.ContainsKey(nuevoVol) Then _VoluntariosConDisponibilidad.Add(nuevoVol, New List(Of Hora))

                If Not _ValidacionDeFilaActiva Then
                    RecargarTabla()
                    FocoEnLaUltimaFila()
                End If
                AsociarHandlerCambioDeFila()
            End If
        End If
    End Sub

    Private Sub RecargarTabla(Optional focoALaUltimiaFila As Boolean = False)
        Dim filaSeleccionadaIdx As Integer = -1
        If dgvVoluntarios.CurrentRow IsNot Nothing Then
            filaSeleccionadaIdx = dgvVoluntarios.CurrentRow.Index
        End If

        EliminarHandlersAlSeleccionarFila()
        EliminarHandlerCambioDeFila()
        dgvVoluntarios.CancelEdit()
        dgvVoluntarios.DataSource = Nothing
        dgvVoluntarios.DataSource = _GestorNuevo.Elementos()

        If focoALaUltimiaFila Then
            FocoEnLaUltimaFila()
        ElseIf filaSeleccionadaIdx >= 0 AndAlso filaSeleccionadaIdx < dgvVoluntarios.Rows.Count Then
            If dgvVoluntarios.Rows(filaSeleccionadaIdx).Cells.Count > 0 Then
                dgvVoluntarios.CurrentCell = dgvVoluntarios.Rows(filaSeleccionadaIdx).Cells(0)
            End If
        ElseIf dgvVoluntarios.Rows.Count > 0 Then
            If dgvVoluntarios.Rows(0).Cells.Count > 0 Then
                dgvVoluntarios.CurrentCell = dgvVoluntarios.Rows(0).Cells(0)
            End If
        End If

        AsociarHandlerCambioDeFila()
        AsociarHandlersAlSeleccionarFila()
        HabilitarBotonEliminar()
        If dgvVoluntarios.CurrentRow IsNot Nothing Then AlSeleccionarFila(dgvVoluntarios, EventArgs.Empty)
    End Sub

    Private Function ValidarNIF(nif As String) As Boolean
        If String.IsNullOrWhiteSpace(nif) Then Return False
        nif = nif.Trim().ToUpper()
        Return Regex.IsMatch(nif, "^[XYZ\d]\d{7}[A-Z]$") OrElse Regex.IsMatch(nif, "^\d{8}[A-Z]$")
    End Function

    Private Function ValidarEmail(email As String) As Boolean
        If String.IsNullOrWhiteSpace(email) Then Return False
        Return Regex.IsMatch(email, "^[^@\s]+@[^@\s]+\.[^@\s]+$")
    End Function

    Private Function ValidarTelefono(telefono As String) As Boolean
        If String.IsNullOrWhiteSpace(telefono) Then Return True
        Return telefono.All(AddressOf Char.IsDigit)
    End Function

    Private Function ComprobarCamposObligatoriosYValidos() As Boolean
        Dim nifValido As Boolean = True
        Dim emailValido As Boolean = True
        Dim telefonoValido As Boolean = True
        Dim obligatorioIncompleto As Boolean = False

        If String.IsNullOrWhiteSpace(txtNif.Text) Then obligatorioIncompleto = True
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then obligatorioIncompleto = True
        If String.IsNullOrWhiteSpace(txtApellido1.Text) Then obligatorioIncompleto = True
        If String.IsNullOrWhiteSpace(txtCorreo.Text) Then obligatorioIncompleto = True
        If cmbCurso.SelectedIndex = -1 Then obligatorioIncompleto = True

        If obligatorioIncompleto Then
            MessageBox.Show("Hay campos obligatorios incompletos (NIF, Nombre, Apellido1, Correo, Curso).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not ValidarNIF(txtNif.Text) Then
            MessageBox.Show("El formato del NIF no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            nifValido = False
        End If
        If Not ValidarEmail(txtCorreo.Text) Then
            MessageBox.Show("El formato del Correo Electrónico no es válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            emailValido = False
        End If
        If Not ValidarTelefono(txtTelefono.Text) Then
            MessageBox.Show("El Teléfono solo puede contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            telefonoValido = False
        End If

        Return nifValido AndAlso emailValido AndAlso telefonoValido
    End Function

    Private Function EntidadValida() As Boolean
        Return ComprobarCamposObligatoriosYValidos()
    End Function

    Private Sub EntidadValidaHandler(sender As Object, e As DataGridViewCellCancelEventArgs)
        If Not ComprobarCamposObligatoriosYValidos() Then
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub LimpiarFilaVacia()
        _GestorNuevo.LimpiarElementoVacio()
    End Sub

    Private Sub FocoEnLaUltimaFila()
        If dgvVoluntarios.Rows.Count > 0 Then
            If dgvVoluntarios.Rows(dgvVoluntarios.Rows.Count - 1).Cells.Count > 0 Then
                dgvVoluntarios.CurrentCell = dgvVoluntarios.Rows(dgvVoluntarios.Rows.Count - 1).Cells(0)
            End If
        End If
    End Sub

    Private Sub MostrarInteresesRelacionados()
        If _VoluntarioActual Is Nothing OrElse Not _VoluntariosConIntereses.ContainsKey(_VoluntarioActual) Then
            lstTiposDisponibles.DataSource = Nothing
            lstTiposInteresado.DataSource = Nothing
            lstTiposDisponibles.Enabled = False
            lstTiposInteresado.Enabled = False
            btnAnadirInteres.Enabled = False
            btnQuitarInteres.Enabled = False
            Return
        End If

        _TiposDisponiblesVoluntarioActual = _GestorTipos.ClonarElementos()
        Dim tiposAsignados = _VoluntariosConIntereses(_VoluntarioActual)

        For Each asignado As Tipo In tiposAsignados
            Dim tipoParaQuitar = _TiposDisponiblesVoluntarioActual.FirstOrDefault(Function(t) t.Equals(asignado))
            If tipoParaQuitar IsNot Nothing Then
                _TiposDisponiblesVoluntarioActual.Remove(tipoParaQuitar)
            End If
        Next

        _TiposDisponiblesVoluntarioActual.Sort()
        tiposAsignados.Sort()

        lstTiposDisponibles.DataSource = Nothing
        lstTiposInteresado.DataSource = Nothing
        lstTiposDisponibles.DataSource = _TiposDisponiblesVoluntarioActual
        lstTiposInteresado.DataSource = tiposAsignados

        lstTiposDisponibles.Enabled = True
        lstTiposInteresado.Enabled = True
        btnAnadirInteres.Enabled = True
        btnQuitarInteres.Enabled = True
    End Sub

    Private Sub ActualizarListasDisponibilidad(sender As Object, e As EventArgs)
        If _VoluntarioActual Is Nothing OrElse Not _VoluntariosConDisponibilidad.ContainsKey(_VoluntarioActual) OrElse cmbDiaDisponibilidad.SelectedIndex = -1 Then
            lstHorasDisponiblesDia.DataSource = Nothing
            lstHorasAsignadasDia.DataSource = Nothing
            lstHorasDisponiblesDia.Enabled = False
            lstHorasAsignadasDia.Enabled = False
            btnAnadirDisponibilidad.Enabled = False
            btnQuitarDisponibilidad.Enabled = False
            cmbDiaDisponibilidad.Enabled = (_VoluntarioActual IsNot Nothing)
            Return
        End If

        Dim diaSeleccionado As Dia = CType(cmbDiaDisponibilidad.SelectedItem, Dia)
        Dim todasLasHorasDelDia = _GestorHoras.Elementos.Where(Function(h) h.Dia.Equals(diaSeleccionado)).ToList()
        Dim horasAsignadasAlVoluntario = _VoluntariosConDisponibilidad(_VoluntarioActual)
        Dim horasAsignadasDelDia = horasAsignadasAlVoluntario.Where(Function(h) h.Dia.Equals(diaSeleccionado)).ToList()

        _HorasDisponiblesDiaActual = todasLasHorasDelDia.ToList()

        For Each asignada As Hora In horasAsignadasDelDia
            Dim horaParaQuitar = _HorasDisponiblesDiaActual.FirstOrDefault(Function(h) h.Equals(asignada))
            If horaParaQuitar IsNot Nothing Then
                _HorasDisponiblesDiaActual.Remove(horaParaQuitar)
            End If
        Next

        _HorasDisponiblesDiaActual.Sort()
        horasAsignadasDelDia.Sort()

        lstHorasDisponiblesDia.DataSource = Nothing
        lstHorasAsignadasDia.DataSource = Nothing
        lstHorasDisponiblesDia.DataSource = _HorasDisponiblesDiaActual
        lstHorasAsignadasDia.DataSource = horasAsignadasDelDia

        lstHorasDisponiblesDia.Enabled = True
        lstHorasAsignadasDia.Enabled = True
        btnAnadirDisponibilidad.Enabled = True
        btnQuitarDisponibilidad.Enabled = True
        cmbDiaDisponibilidad.Enabled = True
    End Sub

    Private Sub btnAnadirInteres_Click(sender As Object, e As EventArgs) Handles btnAnadirInteres.Click
        If _VoluntarioActual Is Nothing OrElse lstTiposDisponibles.SelectedItems.Count = 0 Then Exit Sub

        _CambiosGuardados = False
        ActualizarEstadoBotones()

        Dim listaParaMover As New List(Of Tipo)
        For Each itemSeleccionado In lstTiposDisponibles.SelectedItems
            listaParaMover.Add(CType(itemSeleccionado, Tipo))
        Next

        For Each tipoParaAgregar As Tipo In listaParaMover
            _TiposDisponiblesVoluntarioActual.Remove(tipoParaAgregar)
            _VoluntariosConIntereses(_VoluntarioActual).Add(tipoParaAgregar)

            Dim comandoDelete As String = $"DELETE FROM INTERES WHERE ID_TIPO = {tipoParaAgregar.Id} AND NIF_VOLUNTARIO = '{_VoluntarioActual.Nif}'"
            Dim comandoInsert As String = $"ASOCIAR_INTERES {tipoParaAgregar.Id}, '{_VoluntarioActual.Nif}'"

            If _CambiosIntereses.Contains(comandoDelete) Then
                _CambiosIntereses.Remove(comandoDelete)
            ElseIf Not _CambiosIntereses.Contains(comandoInsert) Then
                _CambiosIntereses.Add(comandoInsert)
            End If
        Next

        _TiposDisponiblesVoluntarioActual.Sort()
        _VoluntariosConIntereses(_VoluntarioActual).Sort()
        lstTiposDisponibles.DataSource = Nothing
        lstTiposInteresado.DataSource = Nothing
        lstTiposDisponibles.DataSource = _TiposDisponiblesVoluntarioActual
        lstTiposInteresado.DataSource = _VoluntariosConIntereses(_VoluntarioActual)
    End Sub

    Private Sub btnQuitarInteres_Click(sender As Object, e As EventArgs) Handles btnQuitarInteres.Click
        If _VoluntarioActual Is Nothing OrElse lstTiposInteresado.SelectedItems.Count = 0 Then Exit Sub

        _CambiosGuardados = False
        ActualizarEstadoBotones()

        Dim listaParaMover As New List(Of Tipo)
        For Each itemSeleccionado In lstTiposInteresado.SelectedItems
            listaParaMover.Add(CType(itemSeleccionado, Tipo))
        Next

        For Each tipoParaQuitar As Tipo In listaParaMover
            _VoluntariosConIntereses(_VoluntarioActual).Remove(tipoParaQuitar)
            _TiposDisponiblesVoluntarioActual.Add(tipoParaQuitar)

            Dim comandoDelete As String = $"DELETE FROM INTERES WHERE ID_TIPO = {tipoParaQuitar.Id} AND NIF_VOLUNTARIO = '{_VoluntarioActual.Nif}'"
            Dim comandoInsert As String = $"ASOCIAR_INTERES {tipoParaQuitar.Id}, '{_VoluntarioActual.Nif}'"

            If _CambiosIntereses.Contains(comandoInsert) Then
                _CambiosIntereses.Remove(comandoInsert)
            ElseIf Not _CambiosIntereses.Contains(comandoDelete) Then
                _CambiosIntereses.Add(comandoDelete)
            End If
        Next

        _TiposDisponiblesVoluntarioActual.Sort()
        _VoluntariosConIntereses(_VoluntarioActual).Sort()
        lstTiposDisponibles.DataSource = Nothing
        lstTiposInteresado.DataSource = Nothing
        lstTiposDisponibles.DataSource = _TiposDisponiblesVoluntarioActual
        lstTiposInteresado.DataSource = _VoluntariosConIntereses(_VoluntarioActual)
    End Sub

    Private Sub btnAnadirDisponibilidad_Click(sender As Object, e As EventArgs) Handles btnAnadirDisponibilidad.Click
        If _VoluntarioActual Is Nothing OrElse lstHorasDisponiblesDia.SelectedItems.Count = 0 Then Exit Sub

        _CambiosGuardados = False
        ActualizarEstadoBotones()

        Dim listaParaMover As New List(Of Hora)
        For Each itemSeleccionado In lstHorasDisponiblesDia.SelectedItems
            listaParaMover.Add(CType(itemSeleccionado, Hora))
        Next

        For Each horaParaAgregar As Hora In listaParaMover
            _HorasDisponiblesDiaActual.Remove(horaParaAgregar)
            _VoluntariosConDisponibilidad(_VoluntarioActual).Add(horaParaAgregar)

            Dim diaDesc As String = horaParaAgregar.Dia.Descripcion
            Dim horaIniStr As String = horaParaAgregar.HoraInicio.ToString("HH:mm:ss")
            Dim horaFinStr As String = horaParaAgregar.HoraFin.ToString("HH:mm:ss")

            Dim comandoDelete As String = $"DELETE FROM DISPONE_DE WHERE NIF_VOLUNTARIO = '{_VoluntarioActual.Nif}' AND DIA = '{diaDesc}' AND HORA_INICIO = '{horaIniStr}' AND HORA_FIN = '{horaFinStr}'"
            Dim comandoInsert As String = $"ASOCIAR_DISPONE_DE '{_VoluntarioActual.Nif}', '{diaDesc}', '{horaIniStr}', '{horaFinStr}'"

            If _CambiosDisponibilidad.Contains(comandoDelete) Then
                _CambiosDisponibilidad.Remove(comandoDelete)
            ElseIf Not _CambiosDisponibilidad.Contains(comandoInsert) Then
                _CambiosDisponibilidad.Add(comandoInsert)
            End If
        Next

        Dim diaSeleccionado As Dia = CType(cmbDiaDisponibilidad.SelectedItem, Dia)
        Dim horasAsignadasDelDia = _VoluntariosConDisponibilidad(_VoluntarioActual).Where(Function(h) h.Dia.Equals(diaSeleccionado)).ToList()
        _HorasDisponiblesDiaActual.Sort()
        horasAsignadasDelDia.Sort()

        lstHorasDisponiblesDia.DataSource = Nothing
        lstHorasAsignadasDia.DataSource = Nothing
        lstHorasDisponiblesDia.DataSource = _HorasDisponiblesDiaActual
        lstHorasAsignadasDia.DataSource = horasAsignadasDelDia
    End Sub

    Private Sub btnQuitarDisponibilidad_Click(sender As Object, e As EventArgs) Handles btnQuitarDisponibilidad.Click
        If _VoluntarioActual Is Nothing OrElse lstHorasAsignadasDia.SelectedItems.Count = 0 Then Exit Sub

        _CambiosGuardados = False
        ActualizarEstadoBotones()

        Dim listaParaMover As New List(Of Hora)
        For Each itemSeleccionado In lstHorasAsignadasDia.SelectedItems
            listaParaMover.Add(CType(itemSeleccionado, Hora))
        Next

        For Each horaParaQuitar As Hora In listaParaMover
            _VoluntariosConDisponibilidad(_VoluntarioActual).Remove(horaParaQuitar)
            _HorasDisponiblesDiaActual.Add(horaParaQuitar)

            Dim diaDesc As String = horaParaQuitar.Dia.Descripcion
            Dim horaIniStr As String = horaParaQuitar.HoraInicio.ToString("HH:mm:ss")
            Dim horaFinStr As String = horaParaQuitar.HoraFin.ToString("HH:mm:ss")

            Dim comandoDelete As String = $"DELETE FROM DISPONE_DE WHERE NIF_VOLUNTARIO = '{_VoluntarioActual.Nif}' AND DIA = '{diaDesc}' AND HORA_INICIO = '{horaIniStr}' AND HORA_FIN = '{horaFinStr}'"
            Dim comandoInsert As String = $"ASOCIAR_DISPONE_DE '{_VoluntarioActual.Nif}', '{diaDesc}', '{horaIniStr}', '{horaFinStr}'"

            If _CambiosDisponibilidad.Contains(comandoInsert) Then
                _CambiosDisponibilidad.Remove(comandoInsert)
            ElseIf Not _CambiosDisponibilidad.Contains(comandoDelete) Then
                _CambiosDisponibilidad.Add(comandoDelete)
            End If
        Next

        Dim diaSeleccionado As Dia = CType(cmbDiaDisponibilidad.SelectedItem, Dia)
        Dim horasAsignadasDelDia = _VoluntariosConDisponibilidad(_VoluntarioActual).Where(Function(h) h.Dia.Equals(diaSeleccionado)).ToList()
        _HorasDisponiblesDiaActual.Sort()
        horasAsignadasDelDia.Sort()

        lstHorasDisponiblesDia.DataSource = Nothing
        lstHorasAsignadasDia.DataSource = Nothing
        lstHorasDisponiblesDia.DataSource = _HorasDisponiblesDiaActual
        lstHorasAsignadasDia.DataSource = horasAsignadasDelDia
    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        If EntidadValida() Then
            _CambiosGuardados = False
            ActualizarEstadoBotones()
            _GestorNuevo.InsertarElementoVacio()
            RecargarTabla(True)
            txtNif.Focus()
        Else
            MessageBox.Show("Termina de modificar el voluntario actual antes de añadir uno nuevo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        If MessageBox.Show("¿Seguro que quieres guardar los cambios?", "Confirmar Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If EntidadValida() Then
                Try
                    Dim gestorCambiosVoluntario As New GestorCambios(Of Voluntario)(_GestorOriginal, _GestorNuevo)
                    gestorCambiosVoluntario.ProcesarCambios()

                    _Conector.Abrir()
                    For Each cambio As String In gestorCambiosVoluntario.Sentencias
                        _Conector.EjecutarModificacion(cambio)
                    Next
                    For Each cambio As String In _CambiosIntereses
                        _Conector.EjecutarModificacion(cambio)
                    Next
                    For Each cambio As String In _CambiosDisponibilidad
                        _Conector.EjecutarModificacion(cambio)
                    Next
                    _Conector.Cerrar()

                    MessageBox.Show("Cambios guardados correctamente. A continuación se cerrará el formulario.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    _CambiosGuardados = True
                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    If _Conector IsNot Nothing AndAlso _Conector.Conexion.State = ConnectionState.Open Then _Conector.Cerrar()
                End Try
            End If
        End If
    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If dgvVoluntarios.CurrentRow IsNot Nothing Then
            Dim volSeleccionado As Voluntario = TryCast(dgvVoluntarios.CurrentRow.DataBoundItem, Voluntario)
            If volSeleccionado IsNot Nothing Then
                _CambiosGuardados = False
                ActualizarEstadoBotones()
                Dim indiceFilaSeleccionada = dgvVoluntarios.CurrentRow.Index

                EliminarHandlersAlSeleccionarFila()
                _VoluntariosConIntereses.Remove(volSeleccionado)
                _VoluntariosConDisponibilidad.Remove(volSeleccionado)
                _GestorNuevo.Elementos.Remove(volSeleccionado)

                Dim indiceNuevaSeleccion As Integer = -1
                If _GestorNuevo.Elementos.Count > 0 Then
                    indiceNuevaSeleccion = If(indiceFilaSeleccionada >= _GestorNuevo.Elementos.Count, _GestorNuevo.Elementos.Count - 1, indiceFilaSeleccionada)
                    If indiceNuevaSeleccion < 0 Then indiceNuevaSeleccion = 0
                End If

                RecargarTabla()

                If indiceNuevaSeleccion >= 0 AndAlso indiceNuevaSeleccion < dgvVoluntarios.Rows.Count Then
                    If dgvVoluntarios.Rows(indiceNuevaSeleccion).Cells.Count > 0 Then
                        dgvVoluntarios.CurrentCell = dgvVoluntarios.Rows(indiceNuevaSeleccion).Cells(0)
                    End If
                ElseIf dgvVoluntarios.Rows.Count > 0 Then
                    If dgvVoluntarios.Rows(0).Cells.Count > 0 Then
                        dgvVoluntarios.CurrentCell = dgvVoluntarios.Rows(0).Cells(0)
                    End If
                Else
                    LimpiarControlesDetalle()
                    LimpiarYDeshabilitarListasRelacionadas()
                End If

                AsociarHandlersAlSeleccionarFila()
                If dgvVoluntarios.CurrentRow IsNot Nothing Then
                    AlSeleccionarFila(dgvVoluntarios, EventArgs.Empty)
                End If
            End If
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        If MessageBox.Show($"¿Seguro que quieres deshacer los cambios?{ControlChars.NewLine}Todo aquello no guardado se perderá.", "Cancelar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            _GestorNuevo = _GestorOriginal.Clonar()
            _VoluntariosConIntereses.Clear()
            _VoluntariosConDisponibilidad.Clear()
            _CambiosIntereses.Clear()
            _CambiosDisponibilidad.Clear()

            Try
                _Conector.Abrir()
                For Each vol As Voluntario In _GestorNuevo.Elementos
                    _VoluntariosConIntereses.Add(vol, New List(Of Tipo))
                    Dim consultaIntereses As String = $"SELECT ID_TIPO FROM INTERES WHERE NIF_VOLUNTARIO = '{vol.Nif}'"
                    Using regIntereses As SqlDataReader = _Conector.EjecutarConsultaMutilple(consultaIntereses)
                        While regIntereses.Read()
                            Dim idTipo As Integer = Convert.ToInt32(regIntereses("ID_TIPO"))
                            Dim tipoObj As Tipo = _GestorTipos.Elementos.FirstOrDefault(Function(t) t.Id = idTipo)
                            If tipoObj IsNot Nothing Then _VoluntariosConIntereses(vol).Add(tipoObj)
                        End While
                    End Using
                    _VoluntariosConIntereses(vol).Sort()

                    _VoluntariosConDisponibilidad.Add(vol, New List(Of Hora))
                    Dim consultaDisponibilidad As String = $"SELECT DIA, HORA_INICIO, HORA_FIN FROM DISPONE_DE WHERE NIF_VOLUNTARIO = '{vol.Nif}'"
                    Using regDisponibilidad As SqlDataReader = _Conector.EjecutarConsultaMutilple(consultaDisponibilidad)
                        While regDisponibilidad.Read()
                            Dim diaDesc As String = regDisponibilidad("DIA").ToString()
                            Dim horaInicioTimeSpan As TimeSpan = CType(regDisponibilidad("HORA_INICIO"), TimeSpan)
                            Dim horaFinTimeSpan As TimeSpan = CType(regDisponibilidad("HORA_FIN"), TimeSpan)
                            Dim horaObj As Hora = _GestorHoras.Elementos.FirstOrDefault(
                                Function(h)
                                    Return h.Dia.Descripcion.Equals(diaDesc, StringComparison.OrdinalIgnoreCase) AndAlso
                                           h.HoraInicio.TimeOfDay = horaInicioTimeSpan AndAlso
                                           h.HoraFin.TimeOfDay = horaFinTimeSpan
                                End Function)
                            If horaObj IsNot Nothing Then _VoluntariosConDisponibilidad(vol).Add(horaObj)
                        End While
                    End Using
                    _VoluntariosConDisponibilidad(vol).Sort()
                Next
            Catch ex As Exception
                MessageBox.Show($"Error al recargar relaciones para cancelar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                _Conector.Cerrar()
            End Try


            dgvVoluntarios.CancelEdit()
            RecargarTabla()
            _CambiosGuardados = True
            ActualizarEstadoBotones()
            If dgvVoluntarios.Rows.Count > 0 Then
                If dgvVoluntarios.Rows(0).Cells.Count > 0 Then
                    dgvVoluntarios.CurrentCell = dgvVoluntarios.Rows(0).Cells(0)
                End If
                AlSeleccionarFila(dgvVoluntarios, EventArgs.Empty)
            Else
                LimpiarControlesDetalle()
                LimpiarYDeshabilitarListasRelacionadas()
            End If
        End If
    End Sub

    Private Sub HabilitarBotonEliminar() Handles dgvVoluntarios.SelectionChanged, dgvVoluntarios.DataSourceChanged
        tsbEliminar.Enabled = (dgvVoluntarios.Rows.Count > 0 AndAlso dgvVoluntarios.CurrentRow IsNot Nothing)
    End Sub

    Private Sub ActualizarEstadoBotones()
        tsbGuardar.Enabled = Not _CambiosGuardados
        tsbCancelar.Enabled = Not _CambiosGuardados
    End Sub

    Private Sub FormVoluntario_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If Not _CambiosGuardados Then
            Dim respuesta As DialogResult = MessageBox.Show("Hay cambios sin guardar. ¿Quieres guardarlos antes de salir?", "Cambios Pendientes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                If EntidadValida() Then
                    Try
                        Dim gestorCambiosVoluntario As New GestorCambios(Of Voluntario)(_GestorOriginal, _GestorNuevo)
                        gestorCambiosVoluntario.ProcesarCambios()
                        _Conector.Abrir()
                        For Each cambio As String In gestorCambiosVoluntario.Sentencias
                            _Conector.EjecutarModificacion(cambio)
                        Next
                        For Each cambio As String In _CambiosIntereses
                            _Conector.EjecutarModificacion(cambio)
                        Next
                        For Each cambio As String In _CambiosDisponibilidad
                            _Conector.EjecutarModificacion(cambio)
                        Next
                        _Conector.Cerrar()
                        _CambiosGuardados = True
                    Catch ex As Exception
                        MessageBox.Show($"Error al intentar guardar los cambios antes de cerrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        If _Conector IsNot Nothing AndAlso _Conector.Conexion.State = ConnectionState.Open Then _Conector.Cerrar()
                        e.Cancel = True
                    End Try
                Else
                    e.Cancel = True
                End If
            ElseIf respuesta = DialogResult.No Then
                _CambiosGuardados = True
            Else
                e.Cancel = True
            End If
        End If
    End Sub

End Class