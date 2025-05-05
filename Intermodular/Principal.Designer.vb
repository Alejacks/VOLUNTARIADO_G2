<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.GestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActividadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VoluntariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ODSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MosaicoVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MosaicoHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarIconosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.VentanaToolStripMenuItem
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActividadesToolStripMenuItem, Me.VoluntariosToolStripMenuItem, Me.OrganizacionesToolStripMenuItem, Me.ToolStripSeparator1, Me.CursosToolStripMenuItem, Me.ODSToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.GestionToolStripMenuItem.Text = "&Gestión"
        '
        'ActividadesToolStripMenuItem
        '
        Me.ActividadesToolStripMenuItem.Name = "ActividadesToolStripMenuItem"
        Me.ActividadesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ActividadesToolStripMenuItem.Text = "&Actividades"
        '
        'VoluntariosToolStripMenuItem
        '
        Me.VoluntariosToolStripMenuItem.Name = "VoluntariosToolStripMenuItem"
        Me.VoluntariosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.VoluntariosToolStripMenuItem.Text = "&Voluntarios"
        '
        'OrganizacionesToolStripMenuItem
        '
        Me.OrganizacionesToolStripMenuItem.Name = "OrganizacionesToolStripMenuItem"
        Me.OrganizacionesToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.OrganizacionesToolStripMenuItem.Text = "O&rganizaciones"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CursosToolStripMenuItem.Text = "&Cursos"
        '
        'ODSToolStripMenuItem
        '
        Me.ODSToolStripMenuItem.Name = "ODSToolStripMenuItem"
        Me.ODSToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ODSToolStripMenuItem.Text = "&ODS"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaToolStripMenuItem, Me.MosaicoVerticalToolStripMenuItem, Me.MosaicoHorizontalToolStripMenuItem, Me.CerrarTodoToolStripMenuItem, Me.OrganizarIconosToolStripMenuItem})
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.VentanaToolStripMenuItem.Text = "&Ventana"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CascadaToolStripMenuItem.Text = "&Cascada"
        '
        'MosaicoVerticalToolStripMenuItem
        '
        Me.MosaicoVerticalToolStripMenuItem.Name = "MosaicoVerticalToolStripMenuItem"
        Me.MosaicoVerticalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.MosaicoVerticalToolStripMenuItem.Text = "Mosaico &Vertical"
        '
        'MosaicoHorizontalToolStripMenuItem
        '
        Me.MosaicoHorizontalToolStripMenuItem.Name = "MosaicoHorizontalToolStripMenuItem"
        Me.MosaicoHorizontalToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.MosaicoHorizontalToolStripMenuItem.Text = "Mosaico &Horizontal"
        '
        'CerrarTodoToolStripMenuItem
        '
        Me.CerrarTodoToolStripMenuItem.Name = "CerrarTodoToolStripMenuItem"
        Me.CerrarTodoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.CerrarTodoToolStripMenuItem.Text = "C&errar todo"
        '
        'OrganizarIconosToolStripMenuItem
        '
        Me.OrganizarIconosToolStripMenuItem.Name = "OrganizarIconosToolStripMenuItem"
        Me.OrganizarIconosToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.OrganizarIconosToolStripMenuItem.Text = "&Organizar iconos"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.AjustesToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "&Acerca de..."
        '
        'AjustesToolStripMenuItem
        '
        Me.AjustesToolStripMenuItem.Name = "AjustesToolStripMenuItem"
        Me.AjustesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AjustesToolStripMenuItem.Text = "Ajustes"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Principal"
        Me.Text = "Voluntariado 4V"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActividadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoluntariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ODSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MosaicoVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MosaicoHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizarIconosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjustesToolStripMenuItem As ToolStripMenuItem
End Class