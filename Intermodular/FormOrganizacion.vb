Imports System.Data.SqlClient
Imports Configuracion
Imports Conexion
Imports Gestores
Imports Entidades
Imports FechaSencilla
Imports Cambios

Public Class FormOrganizacion

    Private _Ajustes As New Ajustes()
    Private _Conector As New Conector(_Ajustes)
    Private _CambiosGuardados As Boolean = True
    Private Const _ConsultaOrganizaciones As String = "SELECT * FROM ORGANIZACION"
    Private _GestorOriginal As New GestorEntidad(Of Organizacion)
    Private _GestorNuevo As GestorEntidad(Of Organizacion)
    Private _ValidacionDeFilaActiva As Boolean = False

    Private Sub FormOrganizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOrganizaciones.Enabled = False
        _Conector.Abrir()
        Using registrosOrganizaciones As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaOrganizaciones)
            While registrosOrganizaciones.Read()
                Dim apellido2ResponsableObj As Object = registrosOrganizaciones("APELLIDO2_RESPONSABLE")
                Dim apellido2 As String = If(IsDBNull(apellido2ResponsableObj), Nothing, apellido2ResponsableObj.ToString())
                Dim org As New Organizacion(
                    registrosOrganizaciones("ID"),
                    registrosOrganizaciones("NOMBRE").ToString(),
                    registrosOrganizaciones("NOMBRE_RESPONSABLE").ToString(),
                    registrosOrganizaciones("APELLIDO1_RESPONSABLE").ToString(),
                    apellido2,
                    New Fecha(registrosOrganizaciones("FECHA_REGISTRO"), "d/m/a")
                )
                _GestorOriginal.Insertar(org)
            End While
        End Using
        _Conector.Cerrar()
        _GestorOriginal.Elementos.Sort()
        _GestorNuevo = _GestorOriginal.Clonar()
        Me.dgvOrganizaciones.DataSource = _GestorNuevo.Elementos()
        AsociarHandlersAlSeleccionarFila()
        AsociarHandlerCambioDeFila()
        ActualizarEstadoBotones()
        dgvOrganizaciones.Enabled = True
    End Sub

    Private Sub FormOrganizacion_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If dgvOrganizaciones.Rows.Count > 0 Then
            dgvOrganizaciones.CurrentCell = dgvOrganizaciones.Rows(0).Cells(0)
            AlSeleccionarFila(dgvOrganizaciones, EventArgs.Empty)
        Else
            LimpiarControlesDetalle()
        End If
        Me.dgvOrganizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub AsociarHandlersCamposObligatorios()
        AddHandler txtNombreOrg.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtRespNombre.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtRespApellido1.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtRespApellido2.TextChanged, AddressOf AlCambiarContenido
        AddHandler dtpFechaRegistro.ValueChanged, AddressOf AlCambiarContenido
    End Sub

    Private Sub EliminarHandlersCamposObligatorios()
        RemoveHandler txtNombreOrg.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtRespNombre.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtRespApellido1.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtRespApellido2.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler dtpFechaRegistro.ValueChanged, AddressOf AlCambiarContenido
    End Sub

    Private Sub AsociarHandlersAlSeleccionarFila()
        AddHandler dgvOrganizaciones.SelectionChanged, AddressOf AlSeleccionarFila
        AddHandler dgvOrganizaciones.CellContentClick, AddressOf AlSeleccionarFila
    End Sub

    Private Sub EliminarHandlersAlSeleccionarFila()
        RemoveHandler dgvOrganizaciones.SelectionChanged, AddressOf AlSeleccionarFila
        RemoveHandler dgvOrganizaciones.CellContentClick, AddressOf AlSeleccionarFila
    End Sub

    Private Sub AsociarHandlerCambioDeFila()
        _ValidacionDeFilaActiva = True
        AddHandler dgvOrganizaciones.RowValidating, AddressOf EntidadValidaHandler
    End Sub

    Private Sub EliminarHandlerCambioDeFila()
        _ValidacionDeFilaActiva = False
        RemoveHandler dgvOrganizaciones.RowValidating, AddressOf EntidadValidaHandler
    End Sub

    Private Sub AlSeleccionarFila(sender As Object, e As EventArgs)
        If dgvOrganizaciones.CurrentRow Is Nothing Then
            LimpiarControlesDetalle()
            Return
        End If

        EliminarHandlersCamposObligatorios()
        Dim orgSeleccionada As Organizacion = TryCast(dgvOrganizaciones.CurrentRow.DataBoundItem, Organizacion)

        If orgSeleccionada IsNot Nothing Then
            Me.txtId.Text = orgSeleccionada.Id.ToString()
            Me.txtNombreOrg.Text = orgSeleccionada.Nombre
            Me.txtRespNombre.Text = orgSeleccionada.NombreResponsable
            Me.txtRespApellido1.Text = orgSeleccionada.Apellido1Responsable
            Me.txtRespApellido2.Text = If(orgSeleccionada.Apellido2Responsable Is Nothing, "", orgSeleccionada.Apellido2Responsable)
            If orgSeleccionada.FechaRegistro IsNot Nothing Then
                Me.dtpFechaRegistro.Value = orgSeleccionada.FechaRegistro.ADateTime
            Else
                Me.dtpFechaRegistro.Value = DateTime.Now
                Me.dtpFechaRegistro.Checked = False
            End If
        Else
            LimpiarControlesDetalle()
        End If
        AsociarHandlersCamposObligatorios()
    End Sub

    Private Sub LimpiarControlesDetalle()
        Me.txtId.Text = ""
        Me.txtNombreOrg.Text = ""
        Me.txtRespNombre.Text = ""
        Me.txtRespApellido1.Text = ""
        Me.txtRespApellido2.Text = ""
        Me.dtpFechaRegistro.Value = DateTime.Now
    End Sub

    Private Sub AlCambiarContenido(sender As Object, e As EventArgs)
        If _ValidacionDeFilaActiva AndAlso dgvOrganizaciones.CurrentRow Is Nothing Then Exit Sub

        _CambiosGuardados = False
        ActualizarEstadoBotones()

        Dim orgSeleccionada As Organizacion = Nothing
        If dgvOrganizaciones.CurrentRow IsNot Nothing Then
            orgSeleccionada = TryCast(dgvOrganizaciones.CurrentRow.DataBoundItem, Organizacion)
        End If

        If orgSeleccionada IsNot Nothing Then
            orgSeleccionada.Nombre = txtNombreOrg.Text
            orgSeleccionada.NombreResponsable = txtRespNombre.Text
            orgSeleccionada.Apellido1Responsable = txtRespApellido1.Text
            orgSeleccionada.Apellido2Responsable = If(String.IsNullOrWhiteSpace(txtRespApellido2.Text), Nothing, txtRespApellido2.Text)
            orgSeleccionada.FechaRegistro = New Fecha(dtpFechaRegistro.Value, "d/m/a")

            If Not _ValidacionDeFilaActiva Then RecargarTabla()
        Else
            If _GestorNuevo.Elementos.Count > 0 AndAlso _GestorNuevo.Elementos.LastOrDefault() Is Nothing OrElse _GestorNuevo.Elementos.LastOrDefault().Nombre = "" Then
                Dim nuevaOrg As New Organizacion(
                    0,
                    txtNombreOrg.Text,
                    txtRespNombre.Text,
                    txtRespApellido1.Text,
                    If(String.IsNullOrWhiteSpace(txtRespApellido2.Text), Nothing, txtRespApellido2.Text),
                    New Fecha(dtpFechaRegistro.Value, "d/m/a")
                    )
                EliminarHandlerCambioDeFila()
                LimpiarFilaVacia()
                _GestorNuevo.Elementos.Add(nuevaOrg)
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
        If dgvOrganizaciones.CurrentRow IsNot Nothing Then
            filaSeleccionadaIdx = dgvOrganizaciones.CurrentRow.Index
        End If

        EliminarHandlersAlSeleccionarFila()
        EliminarHandlerCambioDeFila()
        dgvOrganizaciones.CancelEdit()
        dgvOrganizaciones.DataSource = Nothing
        dgvOrganizaciones.DataSource = _GestorNuevo.Elementos()

        If focoALaUltimiaFila Then
            FocoEnLaUltimaFila()
        ElseIf filaSeleccionadaIdx >= 0 AndAlso filaSeleccionadaIdx < dgvOrganizaciones.Rows.Count Then
            dgvOrganizaciones.CurrentCell = dgvOrganizaciones.Rows(filaSeleccionadaIdx).Cells(0)
        ElseIf dgvOrganizaciones.Rows.Count > 0 Then
            dgvOrganizaciones.CurrentCell = dgvOrganizaciones.Rows(0).Cells(0)
        End If

        AsociarHandlerCambioDeFila()
        AsociarHandlersAlSeleccionarFila()
        HabilitarBotonEliminar()
    End Sub

    Private Function ComprobarCamposObligatorios() As Boolean
        If String.IsNullOrWhiteSpace(txtNombreOrg.Text) Then Return False
        If String.IsNullOrWhiteSpace(txtRespNombre.Text) Then Return False
        If String.IsNullOrWhiteSpace(txtRespApellido1.Text) Then Return False
        Return True
    End Function

    Private Function EntidadValida() As Boolean
        If Not ComprobarCamposObligatorios() Then
            MessageBox.Show("Hay campos obligatorios que no están completos (Nombre Org, Resp. Nombre, Resp. Apellido 1).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub EntidadValidaHandler(sender As Object, e As DataGridViewCellCancelEventArgs)
        If Not ComprobarCamposObligatorios() Then
            MessageBox.Show("Hay campos obligatorios que no están completos (Nombre Org, Resp. Nombre, Resp. Apellido 1).", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub LimpiarFilaVacia()
        _GestorNuevo.LimpiarElementoVacio()
    End Sub

    Private Sub FocoEnLaUltimaFila()
        If dgvOrganizaciones.Rows.Count > 0 Then
            dgvOrganizaciones.CurrentCell = dgvOrganizaciones.Rows(dgvOrganizaciones.Rows.Count - 1).Cells(0)
        End If
    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        If EntidadValida() Then
            _CambiosGuardados = False
            ActualizarEstadoBotones()
            _GestorNuevo.InsertarElementoVacio()
            RecargarTabla(True)
            txtNombreOrg.Focus()
        Else
            MessageBox.Show("Termina de modificar la organización actual antes de añadir una nueva.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        If MessageBox.Show("¿Seguro que quieres guardar los cambios?", "Confirmar Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If EntidadValida() Then
                Try
                    Dim gestorCambios As New GestorCambios(Of Organizacion)(_GestorOriginal, _GestorNuevo)
                    gestorCambios.ProcesarCambios()
                    _Conector.Abrir()
                    For Each cambio As String In gestorCambios.Sentencias
                        _Conector.EjecutarModificacion(cambio)
                    Next
                    _Conector.Cerrar()
                    MessageBox.Show("Cambios guardados correctamente. A continuación se cerrará el formulario.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    _CambiosGuardados = True
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show($"Error al guardar los cambios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    _Conector.Cerrar()
                End Try
            End If
        End If
    End Sub

    Private Sub tsbEliminar_Click(sender As Object, e As EventArgs) Handles tsbEliminar.Click
        If dgvOrganizaciones.CurrentRow IsNot Nothing Then
            Dim orgSeleccionada As Organizacion = TryCast(dgvOrganizaciones.CurrentRow.DataBoundItem, Organizacion)
            If orgSeleccionada IsNot Nothing Then
                _CambiosGuardados = False
                ActualizarEstadoBotones()
                Dim indiceFilaSeleccionada = dgvOrganizaciones.CurrentRow.Index
                EliminarHandlersAlSeleccionarFila()
                _GestorNuevo.Elementos.Remove(orgSeleccionada)
                Dim indiceNuevaSeleccion As Integer = -1
                If _GestorNuevo.Elementos.Count > 0 Then
                    indiceNuevaSeleccion = If(indiceFilaSeleccionada >= _GestorNuevo.Elementos.Count, _GestorNuevo.Elementos.Count - 1, indiceFilaSeleccionada)
                    If indiceNuevaSeleccion < 0 Then indiceNuevaSeleccion = 0
                End If

                RecargarTabla()

                If indiceNuevaSeleccion >= 0 AndAlso indiceNuevaSeleccion < dgvOrganizaciones.Rows.Count Then
                    dgvOrganizaciones.CurrentCell = dgvOrganizaciones.Rows(indiceNuevaSeleccion).Cells(0)
                ElseIf dgvOrganizaciones.Rows.Count > 0 Then
                    dgvOrganizaciones.CurrentCell = dgvOrganizaciones.Rows(0).Cells(0)
                Else
                    LimpiarControlesDetalle() ' Limpia si no quedan filas
                End If

                AsociarHandlersAlSeleccionarFila()
                If dgvOrganizaciones.CurrentRow IsNot Nothing Then
                    AlSeleccionarFila(dgvOrganizaciones, EventArgs.Empty)
                End If
            End If
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        If MessageBox.Show($"¿Seguro que quieres deshacer los cambios?{ControlChars.NewLine}Todo aquello no guardado se perderá.", "Cancelar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            _GestorNuevo = _GestorOriginal.Clonar()
            dgvOrganizaciones.CancelEdit()
            RecargarTabla()
            _CambiosGuardados = True
            ActualizarEstadoBotones()
            If dgvOrganizaciones.Rows.Count > 0 Then
                dgvOrganizaciones.CurrentCell = dgvOrganizaciones.Rows(0).Cells(0)
                AlSeleccionarFila(dgvOrganizaciones, EventArgs.Empty)
            Else
                LimpiarControlesDetalle()
            End If
        End If
    End Sub

    Private Sub HabilitarBotonEliminar() Handles dgvOrganizaciones.SelectionChanged, dgvOrganizaciones.DataSourceChanged
        tsbEliminar.Enabled = (dgvOrganizaciones.Rows.Count > 0 AndAlso dgvOrganizaciones.CurrentRow IsNot Nothing)
    End Sub

    Private Sub ActualizarEstadoBotones()
        tsbGuardar.Enabled = Not _CambiosGuardados
        tsbCancelar.Enabled = Not _CambiosGuardados
    End Sub

    Private Sub FormOrganizacion_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If Not _CambiosGuardados Then
            Dim respuesta As DialogResult = MessageBox.Show("Hay cambios sin guardar. ¿Quieres guardarlos antes de salir?", "Cambios Pendientes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                If EntidadValida() Then
                    Try
                        Dim gestorCambios As New GestorCambios(Of Organizacion)(_GestorOriginal, _GestorNuevo)
                        gestorCambios.ProcesarCambios()
                        _Conector.Abrir()
                        For Each cambio As String In gestorCambios.Sentencias
                            _Conector.EjecutarModificacion(cambio)
                        Next
                        _Conector.Cerrar()
                        _CambiosGuardados = True
                    Catch ex As Exception
                        MessageBox.Show($"Error al intentar guardar los cambios antes de cerrar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        _Conector.Cerrar()
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