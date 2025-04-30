Public Class frmPrincipalMDI


    Public Class frmPrincipalMDI

        ' Variable para evitar abrir múltiples instancias del mismo formulario
        Private Shared Function GetInstance(Of T As {Form, New})() As T
            For Each f As Form In My.Application.OpenForms
                If f.GetType = GetType(T) Then
                    Return CType(f, T)
                End If
            Next
            Return New T()
        End Function

        ' Función genérica para mostrar formularios hijos MDI
        Private Sub ShowMdiChild(Of T As {Form, New})()
            Dim frm As T = GetInstance(Of T)()
            If frm.IsDisposed Then
                frm = New T() ' Si se cerró, crear uno nuevo
            End If
            frm.MdiParent = Me
            frm.Show()
            frm.Activate() ' Traer al frente
        End Sub


        ' --- Eventos del Menú ---

        Private Sub ActividadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActividadesToolStripMenuItem.Click
            ShowMdiChild(Of Actividades)() ' Asume que tu form se llama Actividades
        End Sub

        Private Sub VoluntariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoluntariosToolStripMenuItem.Click
            ShowMdiChild(Of frmVoluntarios)()
        End Sub

        Private Sub OrganizacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizacionesToolStripMenuItem.Click
            ShowMdiChild(Of frmOrganizaciones)()
        End Sub

        Private Sub CursosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CursosToolStripMenuItem.Click
            ShowMdiChild(Of frmCursos)()
        End Sub

        Private Sub TiposDeActividadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeActividadToolStripMenuItem.Click
            ShowMdiChild(Of frmTipos)()
        End Sub

        Private Sub OdsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OdsToolStripMenuItem.Click
            ShowMdiChild(Of frmOds)()
        End Sub

        Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
            Me.Close() ' Cierra el formulario principal y, por ende, la aplicación
        End Sub


        ' --- Eventos del Menú Ventana (Opcional, pero útil en MDI) ---

        Private Sub CascadaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadaToolStripMenuItem.Click
            Me.LayoutMdi(MdiLayout.Cascade)
        End Sub

        Private Sub MosaicoVerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoVerticalToolStripMenuItem.Click
            Me.LayoutMdi(MdiLayout.TileVertical)
        End Sub

        Private Sub MosaicoHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MosaicoHorizontalToolStripMenuItem.Click
            Me.LayoutMdi(MdiLayout.TileHorizontal)
        End Sub

        Private Sub OrganizarIconosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrganizarIconosToolStripMenuItem.Click
            Me.LayoutMdi(MdiLayout.ArrangeIcons)
        End Sub

    End Class

End Class
