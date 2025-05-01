<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOds
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
        Me.tsOds = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.tstBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainerPrincipal = New System.Windows.Forms.SplitContainer()
        Me.dgvOds = New System.Windows.Forms.DataGridView()
        Me.colId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbDetallesOds = New System.Windows.Forms.GroupBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.tsOds.SuspendLayout()
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPrincipal.Panel1.SuspendLayout()
        Me.SplitContainerPrincipal.Panel2.SuspendLayout()
        Me.SplitContainerPrincipal.SuspendLayout()
        CType(Me.dgvOds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetallesOds.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsOds
        '
        Me.tsOds.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsOds.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbGuardar, Me.tsbEliminar, Me.tsbCancelar, Me.ToolStripSeparator1, Me.tslBuscar, Me.tstBuscar, Me.tsbBuscar})
        Me.tsOds.Location = New System.Drawing.Point(0, 0)
        Me.tsOds.Name = "tsOds"
        Me.tsOds.Size = New System.Drawing.Size(800, 27)
        Me.tsOds.TabIndex = 5
        Me.tsOds.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(56, 24)
        Me.tsbNuevo.Text = "Nuevo"
        ' *** TODO: Considerar deshabilitar o ocultar tsbNuevo, tsbGuardar, tsbEliminar para ODS ***
        ' Me.tsbNuevo.Visible = False
        '
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuardar.Enabled = False
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(66, 24)
        Me.tsbGuardar.Text = "Guardar"
        ' Me.tsbGuardar.Visible = False
        '
        'tsbEliminar
        '
        Me.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbEliminar.Enabled = False
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(67, 24)
        Me.tsbEliminar.Text = "Eliminar"
        ' Me.tsbEliminar.Visible = False
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCancelar.Enabled = False
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(70, 24)
        Me.tsbCancelar.Text = "Cancelar"
        ' Me.tsbCancelar.Visible = False ' Ocultar si no hay edición
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        ' Me.ToolStripSeparator1.Visible = False ' Ocultar si no hay botones de edición
        '
        'tslBuscar
        '
        Me.tslBuscar.Name = "tslBuscar"
        Me.tslBuscar.Size = New System.Drawing.Size(55, 24)
        Me.tslBuscar.Text = "Buscar:"
        '
        'tstBuscar
        '
        Me.tstBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstBuscar.Name = "tstBuscar"
        Me.tstBuscar.Size = New System.Drawing.Size(150, 27)
        '
        'tsbBuscar
        '
        Me.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(56, 24)
        Me.tsbBuscar.Text = "Buscar"
        '
        'SplitContainerPrincipal
        '
        Me.SplitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPrincipal.Location = New System.Drawing.Point(0, 27)
        Me.SplitContainerPrincipal.Name = "SplitContainerPrincipal"
        Me.SplitContainerPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerPrincipal.Panel1
        '
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.dgvOds)
        '
        'SplitContainerPrincipal.Panel2
        '
        Me.SplitContainerPrincipal.Panel2.Controls.Add(Me.gbDetallesOds)
        Me.SplitContainerPrincipal.Size = New System.Drawing.Size(800, 423)
        Me.SplitContainerPrincipal.SplitterDistance = 240
        Me.SplitContainerPrincipal.TabIndex = 6
        '
        'dgvOds
        '
        Me.dgvOds.AllowUserToAddRows = False
        Me.dgvOds.AllowUserToDeleteRows = False
        Me.dgvOds.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvOds.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOds.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOds.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvOds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOds.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colId, Me.colDescripcion})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOds.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvOds.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOds.Location = New System.Drawing.Point(0, 0)
        Me.dgvOds.MultiSelect = False
        Me.dgvOds.Name = "dgvOds"
        Me.dgvOds.ReadOnly = True
        Me.dgvOds.RowHeadersWidth = 51
        Me.dgvOds.RowTemplate.Height = 24
        Me.dgvOds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOds.Size = New System.Drawing.Size(800, 240)
        Me.dgvOds.TabIndex = 0
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
        'colDescripcion
        '
        Me.colDescripcion.DataPropertyName = "Descripcion"
        Me.colDescripcion.HeaderText = "Descripción"
        Me.colDescripcion.MinimumWidth = 6
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        '
        'gbDetallesOds
        '
        Me.gbDetallesOds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetallesOds.Controls.Add(Me.txtDescripcion)
        Me.gbDetallesOds.Controls.Add(Me.lblDescripcion)
        Me.gbDetallesOds.Controls.Add(Me.txtId)
        Me.gbDetallesOds.Controls.Add(Me.lblId)
        Me.gbDetallesOds.Location = New System.Drawing.Point(12, 15)
        Me.gbDetallesOds.Name = "gbDetallesOds"
        Me.gbDetallesOds.Size = New System.Drawing.Size(776, 142)
        Me.gbDetallesOds.TabIndex = 0
        Me.gbDetallesOds.TabStop = False
        Me.gbDetallesOds.Text = "Detalles del ODS"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(115, 73)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(641, 22)
        Me.txtDescripcion.TabIndex = 1
        ' *** TODO: Considerar poner ReadOnly = True si los ODS no son editables ***
        ' Me.txtDescripcion.ReadOnly = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(16, 76)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(82, 16)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripción:"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(115, 40)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True ' ID de ODS nunca se edita manualmente
        Me.txtId.Size = New System.Drawing.Size(100, 22)
        Me.txtId.TabIndex = 0
        Me.txtId.TabStop = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(16, 43)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(23, 16)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID:"
        '
        'frmOds
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainerPrincipal)
        Me.Controls.Add(Me.tsOds)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "frmOds"
        Me.Text = "Gestión de ODS"
        Me.tsOds.ResumeLayout(False)
        Me.tsOds.PerformLayout()
        Me.SplitContainerPrincipal.Panel1.ResumeLayout(False)
        Me.SplitContainerPrincipal.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPrincipal.ResumeLayout(False)
        CType(Me.dgvOds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetallesOds.ResumeLayout(False)
        Me.gbDetallesOds.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsOds As ToolStrip
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbEliminar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tslBuscar As ToolStripLabel
    Friend WithEvents tstBuscar As ToolStripTextBox
    Friend WithEvents tsbBuscar As ToolStripButton
    Friend WithEvents SplitContainerPrincipal As SplitContainer
    Friend WithEvents dgvOds As DataGridView
    Friend WithEvents gbDetallesOds As GroupBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colDescripcion As DataGridViewTextBoxColumn
End Class