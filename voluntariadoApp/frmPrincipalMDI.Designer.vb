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
        components = New ComponentModel.Container()
        MenuStrip = New MenuStrip()
        GestionToolStripMenuItem = New ToolStripMenuItem()
        ActividadesToolStripMenuItem = New ToolStripMenuItem()
        VoluntariosToolStripMenuItem = New ToolStripMenuItem()
        OrganizacionesToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        CursosToolStripMenuItem = New ToolStripMenuItem()
        TiposDeActividadToolStripMenuItem = New ToolStripMenuItem()
        ODSToolStripMenuItem = New ToolStripMenuItem()
        VentanaToolStripMenuItem = New ToolStripMenuItem()
        CascadaToolStripMenuItem = New ToolStripMenuItem()
        MosaicoVerticalToolStripMenuItem = New ToolStripMenuItem()
        MosaicoHorizontalToolStripMenuItem = New ToolStripMenuItem()
        CerrarTodoToolStripMenuItem = New ToolStripMenuItem()
        OrganizarIconosToolStripMenuItem = New ToolStripMenuItem()
        AyudaToolStripMenuItem = New ToolStripMenuItem()
        AcercaDeToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip = New StatusStrip()
        ToolStripStatusLabel = New ToolStripStatusLabel()
        ToolTip = New ToolTip(components)
        MenuStrip.SuspendLayout()
        StatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.ImageScalingSize = New Size(20, 20)
        MenuStrip.Items.AddRange(New ToolStripItem() {GestionToolStripMenuItem, VentanaToolStripMenuItem, AyudaToolStripMenuItem})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.MdiWindowListItem = VentanaToolStripMenuItem
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(10, 3, 0, 3)
        MenuStrip.Size = New Size(1054, 35)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' GestionToolStripMenuItem
        ' 
        GestionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ActividadesToolStripMenuItem, VoluntariosToolStripMenuItem, OrganizacionesToolStripMenuItem, ToolStripSeparator1, CursosToolStripMenuItem, TiposDeActividadToolStripMenuItem, ODSToolStripMenuItem})
        GestionToolStripMenuItem.Name = "GestionToolStripMenuItem"
        GestionToolStripMenuItem.Size = New Size(88, 29)
        GestionToolStripMenuItem.Text = "&Gestión"
        ' 
        ' ActividadesToolStripMenuItem
        ' 
        ActividadesToolStripMenuItem.Name = "ActividadesToolStripMenuItem"
        ActividadesToolStripMenuItem.Size = New Size(261, 34)
        ActividadesToolStripMenuItem.Text = "&Actividades"
        ' 
        ' VoluntariosToolStripMenuItem
        ' 
        VoluntariosToolStripMenuItem.Name = "VoluntariosToolStripMenuItem"
        VoluntariosToolStripMenuItem.Size = New Size(261, 34)
        VoluntariosToolStripMenuItem.Text = "&Voluntarios"
        ' 
        ' OrganizacionesToolStripMenuItem
        ' 
        OrganizacionesToolStripMenuItem.Name = "OrganizacionesToolStripMenuItem"
        OrganizacionesToolStripMenuItem.Size = New Size(261, 34)
        OrganizacionesToolStripMenuItem.Text = "O&rganizaciones"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(258, 6)
        ' 
        ' CursosToolStripMenuItem
        ' 
        CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        CursosToolStripMenuItem.Size = New Size(261, 34)
        CursosToolStripMenuItem.Text = "&Cursos"
        ' 
        ' TiposDeActividadToolStripMenuItem
        ' 
        TiposDeActividadToolStripMenuItem.Name = "TiposDeActividadToolStripMenuItem"
        TiposDeActividadToolStripMenuItem.Size = New Size(261, 34)
        TiposDeActividadToolStripMenuItem.Text = "&Tipos de Actividad"
        ' 
        ' ODSToolStripMenuItem
        ' 
        ODSToolStripMenuItem.Name = "ODSToolStripMenuItem"
        ODSToolStripMenuItem.Size = New Size(261, 34)
        ODSToolStripMenuItem.Text = "&ODS"
        ' 
        ' VentanaToolStripMenuItem
        ' 
        VentanaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CascadaToolStripMenuItem, MosaicoVerticalToolStripMenuItem, MosaicoHorizontalToolStripMenuItem, CerrarTodoToolStripMenuItem, OrganizarIconosToolStripMenuItem})
        VentanaToolStripMenuItem.Name = "VentanaToolStripMenuItem"
        VentanaToolStripMenuItem.Size = New Size(91, 29)
        VentanaToolStripMenuItem.Text = "&Ventana"
        ' 
        ' CascadaToolStripMenuItem
        ' 
        CascadaToolStripMenuItem.Name = "CascadaToolStripMenuItem"
        CascadaToolStripMenuItem.Size = New Size(268, 34)
        CascadaToolStripMenuItem.Text = "&Cascada"
        ' 
        ' MosaicoVerticalToolStripMenuItem
        ' 
        MosaicoVerticalToolStripMenuItem.Name = "MosaicoVerticalToolStripMenuItem"
        MosaicoVerticalToolStripMenuItem.Size = New Size(268, 34)
        MosaicoVerticalToolStripMenuItem.Text = "Mosaico &Vertical"
        ' 
        ' MosaicoHorizontalToolStripMenuItem
        ' 
        MosaicoHorizontalToolStripMenuItem.Name = "MosaicoHorizontalToolStripMenuItem"
        MosaicoHorizontalToolStripMenuItem.Size = New Size(268, 34)
        MosaicoHorizontalToolStripMenuItem.Text = "Mosaico &Horizontal"
        ' 
        ' CerrarTodoToolStripMenuItem
        ' 
        CerrarTodoToolStripMenuItem.Name = "CerrarTodoToolStripMenuItem"
        CerrarTodoToolStripMenuItem.Size = New Size(268, 34)
        CerrarTodoToolStripMenuItem.Text = "C&errar todo"
        ' 
        ' OrganizarIconosToolStripMenuItem
        ' 
        OrganizarIconosToolStripMenuItem.Name = "OrganizarIconosToolStripMenuItem"
        OrganizarIconosToolStripMenuItem.Size = New Size(268, 34)
        OrganizarIconosToolStripMenuItem.Text = "&Organizar iconos"
        ' 
        ' AyudaToolStripMenuItem
        ' 
        AyudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AcercaDeToolStripMenuItem})
        AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        AyudaToolStripMenuItem.Size = New Size(79, 29)
        AyudaToolStripMenuItem.Text = "Ay&uda"
        ' 
        ' AcercaDeToolStripMenuItem
        ' 
        AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        AcercaDeToolStripMenuItem.Size = New Size(203, 34)
        AcercaDeToolStripMenuItem.Text = "&Acerca de..."
        ' 
        ' StatusStrip
        ' 
        StatusStrip.ImageScalingSize = New Size(20, 20)
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel})
        StatusStrip.Location = New Point(0, 840)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(1, 0, 24, 0)
        StatusStrip.Size = New Size(1054, 32)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"
        ' 
        ' ToolStripStatusLabel
        ' 
        ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        ToolStripStatusLabel.Size = New Size(66, 25)
        ToolStripStatusLabel.Text = "Estado"
        ' 
        ' frmPrincipalMDI
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1054, 872)
        Controls.Add(StatusStrip)
        Controls.Add(MenuStrip)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(5, 6, 5, 6)
        Name = "frmPrincipalMDI"
        Text = "Gestión de Voluntariado G2"
        WindowState = FormWindowState.Maximized
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

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