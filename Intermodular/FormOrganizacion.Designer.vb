<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOrganizacion
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsOrganizaciones = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainerPrincipal = New System.Windows.Forms.SplitContainer()
        Me.dgvOrganizaciones = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreOrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colResponsable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbDetallesOrganizacion = New System.Windows.Forms.GroupBox()
        Me.dtpFechaRegistro = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaRegistro = New System.Windows.Forms.Label()
        Me.txtRespApellido2 = New System.Windows.Forms.TextBox()
        Me.lblRespApellido2 = New System.Windows.Forms.Label()
        Me.txtRespApellido1 = New System.Windows.Forms.TextBox()
        Me.lblRespApellido1 = New System.Windows.Forms.Label()
        Me.txtRespNombre = New System.Windows.Forms.TextBox()
        Me.lblRespNombre = New System.Windows.Forms.Label()
        Me.txtNombreOrg = New System.Windows.Forms.TextBox()
        Me.lblNombreOrg = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me._ControlesObligatorios = New Control() {Me.txtNombreOrg, Me.txtRespNombre, Me.txtRespApellido1}
        Me.tsOrganizaciones.SuspendLayout()
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPrincipal.Panel1.SuspendLayout()
        Me.SplitContainerPrincipal.Panel2.SuspendLayout()
        Me.SplitContainerPrincipal.SuspendLayout()
        CType(Me.dgvOrganizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetallesOrganizacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsOrganizaciones
        '
        Me.tsOrganizaciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsOrganizaciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbGuardar, Me.tsbEliminar, Me.tsbCancelar, Me.ToolStripSeparator1})
        Me.tsOrganizaciones.Location = New System.Drawing.Point(0, 0)
        Me.tsOrganizaciones.Name = "tsOrganizaciones"
        Me.tsOrganizaciones.Size = New System.Drawing.Size(738, 25)
        Me.tsOrganizaciones.TabIndex = 2
        Me.tsOrganizaciones.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(46, 22)
        Me.tsbNuevo.Text = "Nuevo"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuardar.Enabled = True
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(53, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbEliminar.Enabled = False
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(54, 22)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCancelar.Enabled = True
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(57, 22)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'SplitContainerPrincipal
        '
        Me.SplitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPrincipal.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainerPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainerPrincipal.Name = "SplitContainerPrincipal"
        Me.SplitContainerPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerPrincipal.Panel1
        '
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.dgvOrganizaciones)
        '
        'SplitContainerPrincipal.Panel2
        '
        Me.SplitContainerPrincipal.Panel2.Controls.Add(Me.gbDetallesOrganizacion)
        Me.SplitContainerPrincipal.Size = New System.Drawing.Size(738, 350)
        Me.SplitContainerPrincipal.SplitterDistance = 171
        Me.SplitContainerPrincipal.SplitterWidth = 3
        Me.SplitContainerPrincipal.TabIndex = 3
        '
        'dgvOrganizaciones
        '
        Me.dgvOrganizaciones.AllowUserToAddRows = True
        Me.dgvOrganizaciones.AllowUserToDeleteRows = True
        Me.dgvOrganizaciones.AllowUserToResizeRows = False
        Me.dgvOrganizaciones.AutoGenerateColumns = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvOrganizaciones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrganizaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOrganizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrganizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colNombreOrg, Me.colResponsable, Me.colFechaRegistro})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrganizaciones.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOrganizaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOrganizaciones.Location = New System.Drawing.Point(0, 0)
        Me.dgvOrganizaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvOrganizaciones.MultiSelect = False
        Me.dgvOrganizaciones.Name = "dgvOrganizaciones"
        Me.dgvOrganizaciones.ReadOnly = True
        Me.dgvOrganizaciones.RowHeadersWidth = 51
        Me.dgvOrganizaciones.RowTemplate.Height = 24
        Me.dgvOrganizaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOrganizaciones.Size = New System.Drawing.Size(738, 171)
        Me.dgvOrganizaciones.TabIndex = 0
        '
        'colId
        '
        Me.colId.DataPropertyName = "Id"
        Me.colId.FillWeight = 50.0!
        Me.colId.HeaderText = "ID"
        Me.colId.MinimumWidth = 6
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
        '
        'colNombreOrg
        '
        Me.colNombreOrg.DataPropertyName = "Nombre"
        Me.colNombreOrg.FillWeight = 150.0!
        Me.colNombreOrg.HeaderText = "Nombre Organización"
        Me.colNombreOrg.MinimumWidth = 6
        Me.colNombreOrg.Name = "colNombreOrg"
        Me.colNombreOrg.ReadOnly = True
        '
        'colResponsable
        '
        Me.colResponsable.DataPropertyName = "NombreResponsableCompleto"
        Me.colResponsable.HeaderText = "Responsable"
        Me.colResponsable.MinimumWidth = 6
        Me.colResponsable.Name = "colResponsable"
        Me.colResponsable.ReadOnly = True
        '
        'colFechaRegistro
        '
        Me.colFechaRegistro.DataPropertyName = "FechaRegistro"
        Me.colFechaRegistro.FillWeight = 80.0!
        Me.colFechaRegistro.HeaderText = "Fecha Registro"
        Me.colFechaRegistro.MinimumWidth = 6
        Me.colFechaRegistro.Name = "colFechaRegistro"
        Me.colFechaRegistro.ReadOnly = True
        '
        'gbDetallesOrganizacion
        '
        Me.gbDetallesOrganizacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetallesOrganizacion.Controls.Add(Me.dtpFechaRegistro)
        Me.gbDetallesOrganizacion.Controls.Add(Me.lblFechaRegistro)
        Me.gbDetallesOrganizacion.Controls.Add(Me.txtRespApellido2)
        Me.gbDetallesOrganizacion.Controls.Add(Me.lblRespApellido2)
        Me.gbDetallesOrganizacion.Controls.Add(Me.txtRespApellido1)
        Me.gbDetallesOrganizacion.Controls.Add(Me.lblRespApellido1)
        Me.gbDetallesOrganizacion.Controls.Add(Me.txtRespNombre)
        Me.gbDetallesOrganizacion.Controls.Add(Me.lblRespNombre)
        Me.gbDetallesOrganizacion.Controls.Add(Me.txtNombreOrg)
        Me.gbDetallesOrganizacion.Controls.Add(Me.lblNombreOrg)
        Me.gbDetallesOrganizacion.Controls.Add(Me.txtId)
        Me.gbDetallesOrganizacion.Controls.Add(Me.lblId)
        Me.gbDetallesOrganizacion.Location = New System.Drawing.Point(9, 12)
        Me.gbDetallesOrganizacion.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDetallesOrganizacion.Name = "gbDetallesOrganizacion"
        Me.gbDetallesOrganizacion.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDetallesOrganizacion.Size = New System.Drawing.Size(720, 155)
        Me.gbDetallesOrganizacion.TabIndex = 0
        Me.gbDetallesOrganizacion.TabStop = False
        Me.gbDetallesOrganizacion.Text = "Detalles de la Organización"
        '
        'dtpFechaRegistro
        '
        Me.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRegistro.Location = New System.Drawing.Point(111, 115)
        Me.dtpFechaRegistro.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFechaRegistro.Name = "dtpFechaRegistro"
        Me.dtpFechaRegistro.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaRegistro.TabIndex = 5
        '
        'lblFechaRegistro
        '
        Me.lblFechaRegistro.AutoSize = True
        Me.lblFechaRegistro.Location = New System.Drawing.Point(12, 117)
        Me.lblFechaRegistro.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaRegistro.Name = "lblFechaRegistro"
        Me.lblFechaRegistro.Size = New System.Drawing.Size(82, 13)
        Me.lblFechaRegistro.TabIndex = 10
        Me.lblFechaRegistro.Text = "Fecha Registro:"
        '
        'txtRespApellido2
        '
        Me.txtRespApellido2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRespApellido2.Location = New System.Drawing.Point(454, 86)
        Me.txtRespApellido2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRespApellido2.Name = "txtRespApellido2"
        Me.txtRespApellido2.Size = New System.Drawing.Size(252, 20)
        Me.txtRespApellido2.TabIndex = 4
        '
        'lblRespApellido2
        '
        Me.lblRespApellido2.AutoSize = True
        Me.lblRespApellido2.Location = New System.Drawing.Point(356, 89)
        Me.lblRespApellido2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRespApellido2.Name = "lblRespApellido2"
        Me.lblRespApellido2.Size = New System.Drawing.Size(87, 13)
        Me.lblRespApellido2.TabIndex = 8
        Me.lblRespApellido2.Text = "Resp. Apellido 2:"
        '
        'txtRespApellido1
        '
        Me.txtRespApellido1.Location = New System.Drawing.Point(111, 86)
        Me.txtRespApellido1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRespApellido1.Name = "txtRespApellido1"
        Me.txtRespApellido1.Size = New System.Drawing.Size(218, 20)
        Me.txtRespApellido1.TabIndex = 3
        '
        'lblRespApellido1
        '
        Me.lblRespApellido1.AutoSize = True
        Me.lblRespApellido1.Location = New System.Drawing.Point(12, 89)
        Me.lblRespApellido1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRespApellido1.Name = "lblRespApellido1"
        Me.lblRespApellido1.Size = New System.Drawing.Size(87, 13)
        Me.lblRespApellido1.TabIndex = 6
        Me.lblRespApellido1.Text = "Resp. Apellido 1:"
        '
        'txtRespNombre
        '
        Me.txtRespNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRespNombre.Location = New System.Drawing.Point(111, 59)
        Me.txtRespNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRespNombre.Name = "txtRespNombre"
        Me.txtRespNombre.Size = New System.Drawing.Size(595, 20)
        Me.txtRespNombre.TabIndex = 2
        '
        'lblRespNombre
        '
        Me.lblRespNombre.AutoSize = True
        Me.lblRespNombre.Location = New System.Drawing.Point(12, 62)
        Me.lblRespNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRespNombre.Name = "lblRespNombre"
        Me.lblRespNombre.Size = New System.Drawing.Size(78, 13)
        Me.lblRespNombre.TabIndex = 4
        Me.lblRespNombre.Text = "Resp. Nombre:"
        '
        'txtNombreOrg
        '
        Me.txtNombreOrg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreOrg.Location = New System.Drawing.Point(232, 32)
        Me.txtNombreOrg.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreOrg.Name = "txtNombreOrg"
        Me.txtNombreOrg.Size = New System.Drawing.Size(474, 20)
        Me.txtNombreOrg.TabIndex = 1
        '
        'lblNombreOrg
        '
        Me.lblNombreOrg.AutoSize = True
        Me.lblNombreOrg.Location = New System.Drawing.Point(128, 35)
        Me.lblNombreOrg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreOrg.Name = "lblNombreOrg"
        Me.lblNombreOrg.Size = New System.Drawing.Size(112, 13)
        Me.lblNombreOrg.TabIndex = 2
        Me.lblNombreOrg.Text = "Nombre Organización:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(34, 32)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(76, 20)
        Me.txtId.TabIndex = 0
        Me.txtId.TabStop = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(12, 35)
        Me.lblId.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID:"
        '
        'FormOrganizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 375)
        Me.Controls.Add(Me.SplitContainerPrincipal)
        Me.Controls.Add(Me.tsOrganizaciones)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(604, 414)
        Me.Name = "FormOrganizacion"
        Me.Text = "Gestión de Organizaciones"
        Me.tsOrganizaciones.ResumeLayout(False)
        Me.tsOrganizaciones.PerformLayout()
        Me.SplitContainerPrincipal.Panel1.ResumeLayout(False)
        Me.SplitContainerPrincipal.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPrincipal.ResumeLayout(False)
        CType(Me.dgvOrganizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetallesOrganizacion.ResumeLayout(False)
        Me.gbDetallesOrganizacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsOrganizaciones As ToolStrip
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbEliminar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SplitContainerPrincipal As SplitContainer
    Friend WithEvents dgvOrganizaciones As DataGridView
    Friend WithEvents gbDetallesOrganizacion As GroupBox
    Friend WithEvents dtpFechaRegistro As DateTimePicker
    Friend WithEvents lblFechaRegistro As Label
    Friend WithEvents txtRespApellido2 As TextBox
    Friend WithEvents lblRespApellido2 As Label
    Friend WithEvents txtRespApellido1 As TextBox
    Friend WithEvents lblRespApellido1 As Label
    Friend WithEvents txtRespNombre As TextBox
    Friend WithEvents lblRespNombre As Label
    Friend WithEvents txtNombreOrg As TextBox
    Friend WithEvents lblNombreOrg As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colNombreOrg As DataGridViewTextBoxColumn
    Friend WithEvents colResponsable As DataGridViewTextBoxColumn
    Friend WithEvents colFechaRegistro As DataGridViewTextBoxColumn
    Friend _ControlesObligatorios As Control()
End Class