Imports System.Data.SqlClient
Imports Conexion
Imports Configuracion
Imports Entidades
Imports FechaSencilla
Imports Gestores
Imports Microsoft.Win32

Public Class Principal

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ajustes As New Configuracion.Ajustes()

        'MessageBox.Show(ajustes.ObtenerAjuste("origenBaseDatos"))
        'MessageBox.Show(ajustes.ObtenerAjuste("instanciaSQLServer"))

        'Dim conexionDB As New Conector(ajustes)

        'MessageBox.Show(conexionDB.Conexion.State.ToString)



        'Dim conexion As New SqlConnection("Data Source=.\SQLEXPRESS; Initial Catalog=VOLUNTARIADO_G2; Integrated Security=True;")
        'conexion.Open()
        'MessageBox.Show(conexion.State.ToString)

        'Dim gestorOriginal As New GestorEntidad(Of Organizacion)()

        'Using resultado As SqlDataReader = conexionDB.EjecutarConsultaMutilple("SELECT * FROM ORGANIZACION")
        '    While resultado.Read()
        '        gestorOriginal.Insertar(New Organizacion(
        '        resultado("ID"),
        '        resultado("NOMBRE"),
        '        resultado("NOMBRE_RESPONSABLE"),
        '        resultado("APELLIDO1_RESPONSABLE"),
        '        If(resultado("APELLIDO2_RESPONSABLE") IsNot DBNull.Value, resultado("APELLIDO2_RESPONSABLE"), Nothing),
        '        New Fecha(resultado("FECHA_REGISTRO"), "d/m/a")
        '        ))
        '    End While
        'End Using

        'For Each elemento As EntidadBD In gestorOriginal.Elementos
        '    MessageBox.Show(elemento.ToString())
        'Next

        'Private Function GetSqlServerName() As String
        '    Dim instances = GetLocalSqlInstances()
        '    Return If(instances.Count > 0, instances(0), String.Empty)
        'End Function

        'Private Function GetLocalSqlInstances() As List(Of String)
        '    Dim instances As New List(Of String)
        '    Try
        '        Using key As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL")
        '            If key IsNot Nothing Then
        '                For Each instanceName In key.GetValueNames()
        '                    If instanceName = "MSSQLSERVER" Then
        '                        instances.Add(Environment.MachineName)
        '                    Else
        '                        instances.Add(Environment.MachineName & "\" & instanceName)
        '                    End If
        '                Next
        '            End If
        '        End Using
        '    Catch ex As Exception
        '    End Try
        '    Return instances
        'End Function


        'Dim servidor As String = GetSqlServerName()
    End Sub

    Private Sub TiposDeActividadToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem.Click
        Dim formAjustes As New FormAjustes()
        formAjustes.ShowDialog()
    End Sub
End Class
