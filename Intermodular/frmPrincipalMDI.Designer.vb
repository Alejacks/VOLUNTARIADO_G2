<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipalMDI
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
        Me.TiposDeActividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ODSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentanaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MosaicoVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MosaicoHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrganizarIconosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GestionToolStripMenuItem, Me.VentanaToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.VentanaToolStripMenuItem
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(843, 28)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'GestionToolStripMenuItem
        '
        Me.GestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActividadesToolStripMenuItem, Me.VoluntariosToolStripMenuItem, Me.OrganizacionesToolStripMenuItem, Me.ToolStripSeparator1, Me.CursosToolStripMenuItem, Me.TiposDeActividadToolStripMenuItem, Me.ODSToolStripMenuItem})
        Me.GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        Me.GestionToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.GestionToolStripMenuItem.Text = "&Gestión"
        '
        'ActividadesToolStripMenuItem
        '
        Me.ActividadesToolStripMenuItem.Name = "ActividadesToolStripMenuItem"
        Me.ActividadesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ActividadesToolStripMenuItem.Text = "&Actividades"
        '
        'VoluntariosToolStripMenuItem
        '
        Me.VoluntariosToolStripMenuItem.Name = "VoluntariosToolStripMenuItem"
        Me.VoluntariosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.VoluntariosToolStripMenuItem.Text = "&Voluntarios"
        '
        'OrganizacionesToolStripMenuItem
        '
        Me.OrganizacionesToolStripMenuItem.Name = "OrganizacionesToolStripMenuItem"
        Me.OrganizacionesToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OrganizacionesToolStripMenuItem.Text = "O&rganizaciones"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(221, 6)
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CursosToolStripMenuItem.Text = "&Cursos"
        '
        'TiposDeActividadToolStripMenuItem
        '
        Me.TiposDeActividadToolStripMenuItem.Name = "TiposDeActividadToolStripMenuItem"
        Me.TiposDeActividadToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TiposDeActividadToolStripMenuItem.Text = "&Tipos de Actividad"
        '
        'ODSToolStripMenuItem
        '
        Me.ODSToolStripMenuItem.Name = "ODSToolStripMenuItem"
        Me.ODSToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ODSToolStripMenuItem.Text = "&ODS"
        '
        'VentanaToolStripMenuItem
        '
        Me.VentanaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadaToolStripMenuItem, Me.MosaicoVerticalToolStripMenuItem, Me.MosaicoHorizontalToolStripMenuItem, Me.CerrarTodoToolStripMenuItem, Me.OrganizarIconosToolStripMenuItem})
        Me.VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        Me.VentanaToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.VentanaToolStripMenuItem.Text = "&Ventana"
        '
        'CascadaToolStripMenuItem
        '
        Me.CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        Me.CascadaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CascadaToolStripMenuItem.Text = "&Cascada"
        '
        'MosaicoVerticalToolStripMenuItem
        '
        Me.MosaicoVerticalToolStripMenuItem.Name = "MosaicoVerticalToolStripMenuItem"
        Me.MosaicoVerticalToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MosaicoVerticalToolStripMenuItem.Text = "Mosaico &Vertical"
        '
        'MosaicoHorizontalToolStripMenuItem
        '
        Me.MosaicoHorizontalToolStripMenuItem.Name = "MosaicoHorizontalToolStripMenuItem"
        Me.MosaicoHorizontalToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.MosaicoHorizontalToolStripMenuItem.Text = "Mosaico &Horizontal"
        '
        'CerrarTodoToolStripMenuItem
        '
        Me.CerrarTodoToolStripMenuItem.Name = "CerrarTodoToolStripMenuItem"
        Me.CerrarTodoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CerrarTodoToolStripMenuItem.Text = "C&errar todo"
        '
        'OrganizarIconosToolStripMenuItem
        '
        Me.OrganizarIconosToolStripMenuItem.Name = "OrganizarIconosToolStripMenuItem"
        Me.OrganizarIconosToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OrganizarIconosToolStripMenuItem.Text = "&Organizar iconos"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.AyudaToolStripMenuItem.Text = "Ay&uda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AcercaDeToolStripMenuItem.Text = "&Acerca de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 532)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(843, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'frmPrincipalMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 558)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPrincipalMDI"
        Me.Text = "Gestión de Voluntariado G2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents GestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActividadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoluntariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeActividadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ODSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentanaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CascadaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MosaicoVerticalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MosaicoHorizontalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarTodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OrganizarIconosToolStripMenuItem As ToolStripMenuItem

End Class