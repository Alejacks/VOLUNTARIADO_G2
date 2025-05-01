Imports System.IO
Imports Configuracion

Public Class FormAjustes

    Private _Actualizado As Boolean = False
    Private _Ajustes As New Ajustes()
    Private _Ayudas As New ToolTip()

    Private _FormularioModal As New Form With {
            .Text = "Contenido del fichero de configuración",
            .Size = New Size(600, 400),
            .StartPosition = FormStartPosition.CenterScreen,
            .FormBorderStyle = FormBorderStyle.FixedToolWindow
        }

    Private _TxtOrigenDatos As New TextBox With {
            .Name = "txtNombreMaquina",
            .Location = New Point(200, 18),
            .Width = 130,
            .Text = _Ajustes.ObtenerAjuste("origenBaseDatos")
        }

    Private _TxtInstancia As New TextBox With {
            .Name = "txtNombreServidor",
            .Location = New Point(200, 58),
            .Width = 200,
            .Text = _Ajustes.ObtenerAjuste("instanciaSQLServer")
        }

    Private _TxtCatalogo As New TextBox With {
            .Name = "txtCatalogoBD",
            .Location = New Point(200, 98),
            .Width = 200,
            .Text = _Ajustes.ObtenerAjuste("catalogoBaseDatos")
        }

    Private Sub FormAjustes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
        Me.Text = "Ajustes de conexión"
        Me.Size = Me.Size + New Size(20, 0) - New Size(0, 60)
        Me.StartPosition = FormStartPosition.CenterScreen

        Me.Controls.Add(_TxtOrigenDatos)
        Me.Controls.Add(_TxtInstancia)
        Me.Controls.Add(_TxtCatalogo)

        AddHandler _TxtOrigenDatos.TextChanged, AddressOf MarcarComoDesactualizado
        AddHandler _TxtInstancia.TextChanged, AddressOf MarcarComoDesactualizado
        AddHandler _TxtCatalogo.TextChanged, AddressOf MarcarComoDesactualizado

        Dim lblNombreMaquina As New Label With {
            .Text = "Nombre de la máquina",
            .Location = New Point(20, 20),
            .AutoSize = True
        }
        Me.Controls.Add(lblNombreMaquina)

        Dim lblNombreServidor As New Label With {
            .Text = "Nombre del servidor",
            .Location = New Point(20, 60),
            .AutoSize = True
        }
        Me.Controls.Add(lblNombreServidor)

        Dim lblCatalogoBD As New Label With {
            .Text = "Catálogo de la base de datos",
            .Location = New Point(20, 100),
            .AutoSize = True
        }
        Me.Controls.Add(lblCatalogoBD)

        Dim btnNombreMaquina As New Button With {
            .Name = "btnNombreMaquina",
            .Text = "Buscar",
            .Location = New Point(340, 18),
            .Size = New Size(60, 20)
        }
        Me.Controls.Add(btnNombreMaquina)
        AddHandler btnNombreMaquina.Click, AddressOf BuscarNombreMaquina

        Dim btnGuardar As New Button With {
            .Name = "btnGuardar",
            .Text = "Guardar",
            .Location = New Point(20, 130),
            .Size = New Size(100, 30)
        }
        Me.Controls.Add(btnGuardar)
        AddHandler btnGuardar.Click, AddressOf Guardar

        Dim btnDescartar As New Button With {
            .Name = "btnDescartar",
            .Text = "Descartar",
            .Location = New Point(140, 130),
            .Size = New Size(100, 30)
        }
        Me.Controls.Add(btnDescartar)
        AddHandler btnDescartar.Click, AddressOf DescartarCambios

        Dim btnAbrirFichero As New Button With {
            .Name = "btnAbrirFichero",
            .Text = "Abrir fichero",
            .Location = New Point(260, 130),
            .Size = New Size(140, 30)
        }
        Me.Controls.Add(btnAbrirFichero)
        AddHandler btnAbrirFichero.Click, AddressOf AbrirFicheroConfiguracion

        _Actualizado = True

        _Ayudas.SetToolTip(Me.Controls("txtNombreMaquina"), "Nombre o dirección IP de la máquina donde se aloja el servidor SQLServer")
        _Ayudas.SetToolTip(Me.Controls("txtNombreServidor"), "Nombre de la instancia de SQLServer alojada en el sevidor")
        _Ayudas.SetToolTip(Me.Controls("txtCatalogoBD"), "Catálogo o nombre de la base de datos a la que se desea acceder")
        _Ayudas.SetToolTip(btnGuardar, "Guarda los cambios")
        _Ayudas.SetToolTip(btnDescartar, "Descarta los cambios")
        _Ayudas.SetToolTip(btnAbrirFichero, "Abrir el fichero de configuración en un editor de texto")
    End Sub

    Private Function CajasConContenido() As Boolean
        Dim cajas As TextBox() = Me.Controls.OfType(Of TextBox)().ToArray()
        For Each caja As TextBox In cajas
            If caja.Text = "" OrElse String.IsNullOrWhiteSpace(caja.Text) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub BuscarNombreMaquina()
        Me.Controls(Me.Controls("txtNombreMaquina").Name).Text = Environment.MachineName.ToString()
    End Sub

    Private Sub Guardar()
        Try
            If CajasConContenido() Then
                _Ajustes.ActualizarAjuste("origenBaseDatos", Me.Controls("txtNombreMaquina").Text)
                _Ajustes.ActualizarAjuste("instanciaSQLServer", Me.Controls("txtNombreServidor").Text)
                _Ajustes.ActualizarAjuste("catalogoBaseDatos", Me.Controls("txtCatalogoBD").Text)
                _Actualizado = True
                MessageBox.Show("Ajustes guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Complete todos los campos antes de guardar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As FileNotFoundException
            MessageBox.Show("Error al guardar los ajustes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Error de permisos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Error inesperado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DescartarCambios(sender As Object, e As EventArgs)
        Me.Controls(Me.Controls("txtNombreMaquina").Name).Text = _Ajustes.ObtenerAjuste("origenBaseDatos")
        Me.Controls(Me.Controls("txtNombreServidor").Name).Text = _Ajustes.ObtenerAjuste("instanciaSQLServer")
        Me.Controls(Me.Controls("txtCatalogoBD").Name).Text = _Ajustes.ObtenerAjuste("catalogoBaseDatos")
        _Actualizado = True
    End Sub

    Public Async Sub AbrirFicheroConfiguracion(sender As Object, e As EventArgs)
        Dim rutaFichero As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "conf.txt")
        Dim contenidoOriginal As String = File.ReadAllText(rutaFichero)
        Dim procesoEditor As New Process()
        procesoEditor.StartInfo.FileName = rutaFichero
        procesoEditor.StartInfo.UseShellExecute = True
        procesoEditor.EnableRaisingEvents = True

        Dim completado As New TaskCompletionSource(Of Boolean)()
        AddHandler procesoEditor.Exited, Sub()
                                             If procesoEditor.HasExited Then
                                                 completado.TrySetResult(True)
                                             End If
                                         End Sub

        Try
            If procesoEditor.Start() Then
                Await completado.Task

                Dim contenidoActual As String = File.ReadAllText(rutaFichero)
                Try
                    Using fichero As New StreamWriter(_Ajustes.RutaFicheroConfiguracion, False)
                        fichero.WriteLine(contenidoActual)
                    End Using
                    _Actualizado = True
                    _Ajustes = New Ajustes()
                    Me.Controls(Me.Controls("txtNombreMaquina").Name).Text = _Ajustes.ObtenerAjuste("origenBaseDatos")
                    Me.Controls(Me.Controls("txtNombreServidor").Name).Text = _Ajustes.ObtenerAjuste("instanciaSQLServer")
                    Me.Controls(Me.Controls("txtCatalogoBD").Name).Text = _Ajustes.ObtenerAjuste("catalogoBaseDatos")
                Catch ex As Exception
                    _Actualizado = False
                End Try
            End If
        Catch ex As Exception
            _Actualizado = False
        End Try

    End Sub

    Private Sub AlCerrarFormularioAjustes(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not _Actualizado Then
            Dim resultado As DialogResult = MessageBox.Show("¿Desea guardar los cambios antes de salir?", "Atención", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If resultado = DialogResult.Yes Then
                Guardar()
            ElseIf resultado = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub MarcarComoDesactualizado(sender As Object, e As EventArgs)
        _Actualizado = False
    End Sub

End Class