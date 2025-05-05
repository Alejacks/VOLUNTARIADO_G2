Imports System.Data.SqlClient
Imports Conexion
Imports Configuracion
Imports Entidades
Imports FechaSencilla
Imports Gestores
Imports Microsoft.Win32
Imports System.Drawing

Public Class Principal
    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem.Click
        Dim formAjustes As New FormAjustes()
        formAjustes.ShowDialog(Me)
        formAjustes.Dispose()
    End Sub

    Private Sub ActividadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActividadesToolStripMenuItem.Click
        AbrirFormularioHijo(Of FormActividades)()
    End Sub

    Private Sub VoluntariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoluntariosToolStripMenuItem.Click
        AbrirFormularioHijo(Of FormVoluntario)()
    End Sub

    Private Sub OrganizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizacionesToolStripMenuItem.Click
        AbrirFormularioHijo(Of FormOrganizacion)()
    End Sub

    Private Sub CursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursosToolStripMenuItem.Click
        AbrirFormularioHijo(Of FormCursos)()
    End Sub

    Private Sub ODSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ODSToolStripMenuItem.Click
        AbrirFormularioHijo(Of FormOds)()
    End Sub

    Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub MosaicoVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub MosaicoHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub CerrarTodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodoToolStripMenuItem.Click, Me.Closing
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub OrganizarIconosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizarIconosToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub AbrirFormularioHijo(Of T As {Form, New})()
        For Each form As Form In Me.MdiChildren
            If form.GetType() Is GetType(T) Then
                form.Activate()
                Exit Sub
            End If
        Next

        Dim frmHijo As T = New T()
        frmHijo.MdiParent = Me
        frmHijo.Show()
    End Sub

End Class