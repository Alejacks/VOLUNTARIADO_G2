Imports System.Data.SqlClient
Imports Conexion
Imports Configuracion
Imports Entidades
Imports Gestores
Imports Cambios

Public Class FormCursos

    Private _Ajustes As New Ajustes()
    Private _Conector As New Conector(_Ajustes)
    Private _CambiosGuardados As Boolean = True
    Private Const _ConsultaCursos As String = "SELECT * FROM CURSO"
    Private _GestorOriginal As New GestorEntidad(Of Curso)
    Private _GestorNuevo As GestorEntidad(Of Curso)
    Private _ValidacionDeFilaActiva As Boolean = False

    Private Sub FormCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvCursos.Enabled = False
        _Conector.Abrir()
        Using registrosCursos As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaCursos)
            While registrosCursos.Read()
                _GestorOriginal.Insertar(New Curso(
                                        registrosCursos("ID"),
                                        registrosCursos("DESCRIPCION")
                                        ))
            End While
        End Using
        _Conector.Cerrar()
        _GestorOriginal.Elementos.Sort()
        _GestorNuevo = _GestorOriginal.Clonar()
        Me.dgvCursos.DataSource = _GestorNuevo.Elementos()
        AsociarHandlersAlSeleccionarFila()
        AsociarHandlerCambioDeFila()
        ActualizarEstadoBotones()
        dgvCursos.Enabled = True
    End Sub

    Public Sub FormCursos_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If dgvCursos.Rows.Count > 0 Then
            dgvCursos.CurrentCell = dgvCursos.Rows(0).Cells(0)
            AlSeleccionarFila(dgvCursos, EventArgs.Empty)
        Else
            LimpiarControlesDetalle()
        End If
        Me.dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub AsociarHandlersCamposObligatorios()
        AddHandler txtDescripcion.TextChanged, AddressOf AlCambiarContenido
    End Sub

    Private Sub EliminarHandlersCamposObligatorios()
        RemoveHandler txtDescripcion.TextChanged, AddressOf AlCambiarContenido
    End Sub

    Private Sub AsociarHandlersAlSeleccionarFila()
        AddHandler dgvCursos.SelectionChanged, AddressOf AlSeleccionarFila
        AddHandler dgvCursos.CellContentClick, AddressOf AlSeleccionarFila
    End Sub

    Private Sub EliminarHandlersAlSeleccionarFila()
        RemoveHandler dgvCursos.SelectionChanged, AddressOf AlSeleccionarFila
        RemoveHandler dgvCursos.CellContentClick, AddressOf AlSeleccionarFila
    End Sub

    Private Sub AsociarHandlerCambioDeFila()
        _ValidacionDeFilaActiva = True
        AddHandler dgvCursos.RowValidating, AddressOf EntidadValidaHandler
    End Sub

    Private Sub EliminarHandlerCambioDeFila()
        _ValidacionDeFilaActiva = False
        RemoveHandler dgvCursos.RowValidating, AddressOf EntidadValidaHandler
    End Sub

    Private Sub AlSeleccionarFila(sender As Object, e As EventArgs)
        If dgvCursos.CurrentRow Is Nothing Then
            LimpiarControlesDetalle()
            Return
        End If

        EliminarHandlersCamposObligatorios()
        Dim cursoSeleccionado As Curso = TryCast(dgvCursos.CurrentRow.DataBoundItem, Curso)

        If cursoSeleccionado IsNot Nothing Then
            Me.txtId.Text = cursoSeleccionado.Id.ToString()
            Me.txtDescripcion.Text = cursoSeleccionado.Descripcion
        Else
            LimpiarControlesDetalle()
        End If
        AsociarHandlersCamposObligatorios()
    End Sub

    Private Sub LimpiarControlesDetalle()
        Me.txtId.Text = ""
        Me.txtDescripcion.Text = ""
    End Sub

    Private Sub AlCambiarContenido(sender As Object, e As EventArgs)
        If _ValidacionDeFilaActiva AndAlso dgvCursos.CurrentRow Is Nothing Then Exit Sub

        _CambiosGuardados = False
        ActualizarEstadoBotones()

        Dim cursoSeleccionado As Curso = Nothing
        If dgvCursos.CurrentRow IsNot Nothing Then
            cursoSeleccionado = TryCast(dgvCursos.CurrentRow.DataBoundItem, Curso)
        End If

        If cursoSeleccionado IsNot Nothing Then
            cursoSeleccionado.Descripcion = txtDescripcion.Text
            If Not _ValidacionDeFilaActiva Then RecargarTabla()
        Else
            If _GestorNuevo.Elementos.Count > 0 AndAlso _GestorNuevo.Elementos.LastOrDefault() Is Nothing OrElse _GestorNuevo.Elementos.LastOrDefault().Descripcion = "" Then
                Dim nuevoCurso As New Curso(0, txtDescripcion.Text)
                EliminarHandlerCambioDeFila()
                LimpiarFilaVacia()
                _GestorNuevo.Elementos.Add(nuevoCurso)
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
        If dgvCursos.CurrentRow IsNot Nothing Then
            filaSeleccionadaIdx = dgvCursos.CurrentRow.Index
        End If

        EliminarHandlersAlSeleccionarFila()
        EliminarHandlerCambioDeFila()
        dgvCursos.CancelEdit()
        dgvCursos.DataSource = Nothing
        dgvCursos.DataSource = _GestorNuevo.Elementos()

        If focoALaUltimiaFila Then
            FocoEnLaUltimaFila()
        ElseIf filaSeleccionadaIdx >= 0 AndAlso filaSeleccionadaIdx < dgvCursos.Rows.Count Then
            dgvCursos.CurrentCell = dgvCursos.Rows(filaSeleccionadaIdx).Cells(0)
        ElseIf dgvCursos.Rows.Count > 0 Then
            dgvCursos.CurrentCell = dgvCursos.Rows(0).Cells(0)
        End If

        AsociarHandlerCambioDeFila()
        AsociarHandlersAlSeleccionarFila()
        HabilitarBotonEliminar()
    End Sub

    Private Function ComprobarCamposObligatorios() As Boolean
        If String.IsNullOrWhiteSpace(txtDescripcion.Text) Then Return False
        Return True
    End Function

    Private Function EntidadValida() As Boolean
        If Not ComprobarCamposObligatorios() Then
            MessageBox.Show("Añada una descripción al curso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub EntidadValidaHandler(sender As Object, e As DataGridViewCellCancelEventArgs)
        If Not ComprobarCamposObligatorios() Then
            MessageBox.Show("Añada una descripción al curso.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
            Return
        End If
    End Sub

    Private Sub LimpiarFilaVacia()
        _GestorNuevo.LimpiarElementoVacio()
    End Sub

    Private Sub FocoEnLaUltimaFila()
        If dgvCursos.Rows.Count > 0 Then
            dgvCursos.CurrentCell = dgvCursos.Rows(dgvCursos.Rows.Count - 1).Cells(0)
        End If
    End Sub

    Private Sub tsbNuevo_Click(sender As Object, e As EventArgs) Handles tsbNuevo.Click
        If EntidadValida() Then
            _CambiosGuardados = False
            ActualizarEstadoBotones()
            _GestorNuevo.InsertarElementoVacio()
            RecargarTabla(True)
            txtDescripcion.Focus()
        Else
            MessageBox.Show("Termina de modificar el curso actual antes de añadir uno nuevo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        If MessageBox.Show("¿Seguro que quieres guardar los cambios?", "Confirmar Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If EntidadValida() Then
                Try
                    Dim gestorCambios As New GestorCambios(Of Curso)(_GestorOriginal, _GestorNuevo)
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
        If dgvCursos.CurrentRow IsNot Nothing Then
            Dim cursoSeleccionado As Curso = TryCast(dgvCursos.CurrentRow.DataBoundItem, Curso)
            If cursoSeleccionado IsNot Nothing Then
                _CambiosGuardados = False
                ActualizarEstadoBotones()
                Dim indiceFilaSeleccionada = dgvCursos.CurrentRow.Index
                EliminarHandlersAlSeleccionarFila()
                _GestorNuevo.Elementos.Remove(cursoSeleccionado)
                Dim indiceNuevaSeleccion As Integer = -1
                If _GestorNuevo.Elementos.Count > 0 Then
                    indiceNuevaSeleccion = If(indiceFilaSeleccionada >= _GestorNuevo.Elementos.Count, _GestorNuevo.Elementos.Count - 1, indiceFilaSeleccionada)
                    If indiceNuevaSeleccion < 0 Then indiceNuevaSeleccion = 0
                End If

                RecargarTabla()

                If indiceNuevaSeleccion >= 0 AndAlso indiceNuevaSeleccion < dgvCursos.Rows.Count Then
                    dgvCursos.CurrentCell = dgvCursos.Rows(indiceNuevaSeleccion).Cells(0)
                ElseIf dgvCursos.Rows.Count > 0 Then
                    dgvCursos.CurrentCell = dgvCursos.Rows(0).Cells(0)
                Else
                    LimpiarControlesDetalle()
                End If

                AsociarHandlersAlSeleccionarFila()
                If dgvCursos.CurrentRow IsNot Nothing Then
                    AlSeleccionarFila(dgvCursos, EventArgs.Empty)
                End If
            End If
        End If
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        If MessageBox.Show($"¿Seguro que quieres deshacer los cambios?{ControlChars.NewLine}Todo aquello no guardado se perderá.", "Cancelar Cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            _GestorNuevo = _GestorOriginal.Clonar()
            dgvCursos.CancelEdit()
            RecargarTabla()
            _CambiosGuardados = True
            ActualizarEstadoBotones()
            If dgvCursos.Rows.Count > 0 Then
                dgvCursos.CurrentCell = dgvCursos.Rows(0).Cells(0)
                AlSeleccionarFila(dgvCursos, EventArgs.Empty)
            Else
                LimpiarControlesDetalle()
            End If
        End If
    End Sub

    Private Sub HabilitarBotonEliminar() Handles dgvCursos.SelectionChanged, dgvCursos.DataSourceChanged
        tsbEliminar.Enabled = (dgvCursos.Rows.Count > 0 AndAlso dgvCursos.CurrentRow IsNot Nothing)
    End Sub

    Private Sub ActualizarEstadoBotones()
        tsbGuardar.Enabled = Not _CambiosGuardados
        tsbCancelar.Enabled = Not _CambiosGuardados
    End Sub

    Private Sub FormCursos_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.Closing
        If Not _CambiosGuardados Then
            Dim respuesta As DialogResult = MessageBox.Show("Hay cambios sin guardar. ¿Quieres guardarlos antes de salir?", "Cambios Pendientes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If respuesta = DialogResult.Yes Then
                If EntidadValida() Then
                    Try
                        Dim gestorCambios As New GestorCambios(Of Curso)(_GestorOriginal, _GestorNuevo)
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