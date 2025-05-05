Imports System.Data.SqlClient
Imports Conexion
Imports Configuracion
Imports Entidades
Imports Gestores

Public Class FormOds
    Private _Ajustes As New Ajustes()
    Private _Conector As New Conector(_Ajustes)

    Private _CambiosGuardados As Boolean = True

    Private Const _ConsultaODS As String = "SELECT * FROM ODS"
    Private _GestorOriginal As New GestorEntidad(Of Ods)
    Private _GestorNuevo As New GestorEntidad(Of Ods)

    Private _ValidacionDeFilaActiva As Boolean = False

    Private Sub FormOds_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOds.Enabled = False

        _Conector.Abrir()
        Using registrosODS As SqlDataReader = _Conector.EjecutarConsultaMutilple(_ConsultaODS)
            While registrosODS.Read()
                _GestorOriginal.Insertar(New Ods(
                                     registrosODS("ID"),
                                     registrosODS("DESCRIPCION")
                                     ))
            End While
        End Using
        _Conector.Cerrar()

        Me._GestorOriginal.Elementos.Sort()
        Me._GestorNuevo = _GestorOriginal.Clonar()

        Me.dgvOds.DataSource = _GestorNuevo.Elementos()

        AsociarHandlersAlSeleccionarFila()
        AsociarHandlerCambioDeFila()

        dgvOds.Enabled = True
    End Sub

    Public Sub FormODS_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If dgvOds.Rows.Count > 0 Then
            dgvOds.CurrentCell = dgvOds.Rows(0).Cells(0)
            AlSeleccionarFila(dgvOds.Rows(0).Cells(0), Nothing)
        End If
        Me.dgvOds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub AsociarHandlersCamposObligatorios()
        AddHandler txtId.TextChanged, AddressOf AlCambiarContenido
        AddHandler txtDescripcion.TextChanged, AddressOf AlCambiarContenido
    End Sub

    Private Sub EliminarHandlersCamposObligatorios()
        RemoveHandler txtId.TextChanged, AddressOf AlCambiarContenido
        RemoveHandler txtDescripcion.TextChanged, AddressOf AlCambiarContenido
    End Sub

    Private Sub NuevaFila() Handles tsbNuevo.Click
        _CambiosGuardados = False
        If EntidadValida() Then
            _GestorNuevo.InsertarElementoVacio()
            RecargarTabla(True)
            txtDescripcion.Focus()
            If dgvOds.Rows.Count = 1 Then
                dgvOds.CurrentCell = dgvOds.Rows(0).Cells(0)
                AlSeleccionarFila(dgvOds.Rows(0).Cells(0), Nothing)
            Else
                dgvOds.CurrentCell = dgvOds.Rows(dgvOds.Rows.Count - 1).Cells(0)
                AlSeleccionarFila(dgvOds.Rows(0).Cells(0), Nothing)
            End If
        Else
            MessageBox.Show("Termina de modificar la actual actividad antes de añadir una nueva.")
        End If
    End Sub

    Private Sub AsociarHandlersAlSeleccionarFila()
        AddHandler dgvOds.SelectionChanged, AddressOf AlSeleccionarFila
        AddHandler dgvOds.CellContentClick, AddressOf AlSeleccionarFila
    End Sub

    Private Sub EliminarHandlersAlSeleccionarFila()
        RemoveHandler dgvOds.SelectionChanged, AddressOf AlSeleccionarFila
        RemoveHandler dgvOds.CellContentClick, AddressOf AlSeleccionarFila
    End Sub

    Private Sub AsociarHandlerCambioDeFila()
        _ValidacionDeFilaActiva = True
        AddHandler dgvOds.RowValidating, AddressOf EntidadValida
    End Sub

    Private Sub EliminarHandlerCambioDeFila()
        _ValidacionDeFilaActiva = False
        RemoveHandler dgvOds.RowValidating, AddressOf EntidadValida
    End Sub

    Private Sub LimpiarFilaVacia()
        _GestorNuevo.LimpiarElementoVacio()
    End Sub

    Private Sub FocoEnLaUltimaFila()
        If dgvOds.Rows.Count > 0 Then
            dgvOds.CurrentCell = dgvOds.Rows(dgvOds.Rows.Count - 1).Cells(0)
        ElseIf dgvOds.Rows.Count = 1 Then
            dgvOds.CurrentCell = dgvOds.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub AlSeleccionarFila(sender As Object, e As EventArgs)
        EliminarHandlersCamposObligatorios()
        Dim odsSeleccionada As Ods = TryCast(dgvOds.CurrentRow.DataBoundItem, Ods)
        If odsSeleccionada IsNot Nothing Then
            Me.txtId.Text = odsSeleccionada.Id
            Me.txtDescripcion.Text = odsSeleccionada.Descripcion
        Else
            Me.txtId.Text = ""
            Me.txtDescripcion.Text = ""
        End If
        AsociarHandlersCamposObligatorios()
    End Sub

    Private Sub AlCambiarContenido(sender As Object, e As EventArgs)
        _CambiosGuardados = False
        Dim odsSeleccionada As Ods = TryCast(dgvOds.CurrentRow.DataBoundItem, Ods)
        If odsSeleccionada IsNot Nothing Then
            odsSeleccionada.Id = If(txtId.Text = "", 0, txtId.Text)
            odsSeleccionada.Descripcion = txtDescripcion.Text
        Else
            odsSeleccionada = New Ods(txtId.Text, txtDescripcion.Text)
            EliminarHandlerCambioDeFila()
            LimpiarFilaVacia()
            _GestorNuevo.Elementos.Add(odsSeleccionada)
            If Not _ValidacionDeFilaActiva Then
                RecargarTabla()
                FocoEnLaUltimaFila()
            End If
            AsociarHandlerCambioDeFila()
        End If
    End Sub

    Private Sub RecargarTabla(Optional focoALaUltimiaFila As Boolean = False)
        dgvOds.EndEdit()
        dgvOds.CancelEdit()
        EliminarHandlerCambioDeFila()
        dgvOds.DataSource = Nothing
        dgvOds.DataSource = _GestorNuevo.Elementos()
        If focoALaUltimiaFila Then FocoEnLaUltimaFila()
        AsociarHandlerCambioDeFila()
    End Sub

    Private Function EntidadValida() As Boolean
        If Not ComprobarCamposObligatorios() Then
            MessageBox.Show("Hay campos obligatorios que no están completos")
            Return False
        Else
            Dim odsSeleccionada As Ods = TryCast(dgvOds.CurrentRow.DataBoundItem, Ods)
            Dim ods As New Ods(odsSeleccionada.Id, "")
            Dim indice As Integer = _GestorNuevo.Elementos.IndexOf(ods)
            If _GestorOriginal.Elementos.Contains(New Ods(odsSeleccionada.Id, "")) AndAlso Not _GestorOriginal.Elementos(indice).Equals(indice) Then
                MessageBox.Show("Ya existe una ODS con ese ID")
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
    End Sub

    Private Function ComprobarCamposObligatorios() As Boolean
        If txtDescripcion.Text = "" OrElse String.IsNullOrWhiteSpace(txtDescripcion.Text) OrElse txtId.Text = "" OrElse String.IsNullOrWhiteSpace(txtId.Text) Then Return False
        Return True
    End Function

    Private Sub EliminarFila() Handles tsbEliminar.Click
        _CambiosGuardados = False
        EliminarHandlersAlSeleccionarFila()
        Dim odsSeleccionada As Ods = TryCast(dgvOds.CurrentRow.DataBoundItem, Ods)
        Dim indiceFilaSeleccionada = _GestorNuevo.Elementos.IndexOf(odsSeleccionada) - 1
        _GestorNuevo.Elementos.Remove(odsSeleccionada)
        If indiceFilaSeleccionada > 0 Then
            dgvOds.CurrentCell = dgvOds.Rows(indiceFilaSeleccionada).Cells(0)
        End If
        RecargarTabla()
        AsociarHandlersAlSeleccionarFila()
    End Sub

    Private Sub tsbCancelar_Click(sender As Object, e As EventArgs) Handles tsbCancelar.Click
        _CambiosGuardados = True
        If MessageBox.Show($"¿Seguro que quieres restaurar los cambios?{ControlChars.NewLine}Todo aquello no guardado se perderá de manera irreversible", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes) Then
            _GestorNuevo = _GestorOriginal.Clonar()
            dgvOds.CancelEdit()
            RecargarTabla()
        End If
    End Sub

    Private Sub HabilitarBotonEliminar() Handles dgvOds.SelectionChanged, dgvOds.DataSourceChanged
        If dgvOds.Rows.Count > 0 Then
            tsbEliminar.Enabled = True
        Else
            tsbEliminar.Enabled = False
        End If
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        If MessageBox.Show("¿Seguro que quieres guardar los cambios?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).Equals(DialogResult.Yes) Then
            If EntidadValida() Then
                Dim gestorCambios As New GestorCambios(Of Ods)(_GestorOriginal, _GestorNuevo)
                gestorCambios.ProcesarCambios()

                _Conector.Abrir()
                For Each cambio As String In gestorCambios.Sentencias
                    _Conector.EjecutarModificacion(cambio)
                Next
                MessageBox.Show("Cambios guardados correctamente. A continuación se cerrará el formulario", "Guardado")
                _Conector.Cerrar()
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
                    Dim gestorCambios As New GestorCambios(Of Ods)(_GestorOriginal, _GestorNuevo)
                    gestorCambios.ProcesarCambios()

                    _Conector.Abrir()
                    For Each cambio As String In gestorCambios.Sentencias
                        _Conector.EjecutarModificacion(cambio)
                    Next
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

End Class