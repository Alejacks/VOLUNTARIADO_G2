<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVoluntarios
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
        Me.tsVoluntarios = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.tstBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainerPrincipal = New System.Windows.Forms.SplitContainer()
        Me.dgvVoluntarios = New System.Windows.Forms.DataGridView()
        Me.colNif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreCompleto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCorreo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCurso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabDetalles = New System.Windows.Forms.TabControl()
        Me.tpDetallesVoluntario = New System.Windows.Forms.TabPage()
        Me.gbDetallesVoluntario = New System.Windows.Forms.GroupBox()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.txtExperiencia = New System.Windows.Forms.TextBox()
        Me.lblExperiencia = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNif = New System.Windows.Forms.TextBox()
        Me.lblNif = New System.Windows.Forms.Label()
        Me.tpIntereses = New System.Windows.Forms.TabPage()
        Me.gbIntereses = New System.Windows.Forms.GroupBox()
        Me.btnQuitarInteres = New System.Windows.Forms.Button()
        Me.btnAnadirInteres = New System.Windows.Forms.Button()
        Me.lstTiposInteresado = New System.Windows.Forms.ListBox()
        Me.lblTiposInteresado = New System.Windows.Forms.Label()
        Me.lstTiposDisponibles = New System.Windows.Forms.ListBox()
        Me.lblTiposDisponibles = New System.Windows.Forms.Label()
        Me.tpDisponibilidad = New System.Windows.Forms.TabPage()
        Me.gbDisponibilidad = New System.Windows.Forms.GroupBox()
        Me.btnQuitarDisponibilidad = New System.Windows.Forms.Button()
        Me.btnAnadirDisponibilidad = New System.Windows.Forms.Button()
        Me.lstHorasAsignadas = New System.Windows.Forms.ListBox()
        Me.lblHorasAsignadas = New System.Windows.Forms.Label()
        Me.lstHorasDisponibles = New System.Windows.Forms.ListBox()
        Me.lblHorasDisponibles = New System.Windows.Forms.Label()
        Me.tsVoluntarios.SuspendLayout()
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPrincipal.Panel1.SuspendLayout()
        Me.SplitContainerPrincipal.Panel2.SuspendLayout()
        Me.SplitContainerPrincipal.SuspendLayout()
        CType(Me.dgvVoluntarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetalles.SuspendLayout()
        Me.tpDetallesVoluntario.SuspendLayout()
        Me.gbDetallesVoluntario.SuspendLayout()
        Me.tpIntereses.SuspendLayout()
        Me.gbIntereses.SuspendLayout()
        Me.tpDisponibilidad.SuspendLayout()
        Me.gbDisponibilidad.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsVoluntarios
        '
        Me.tsVoluntarios.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsVoluntarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbGuardar, Me.tsbEliminar, Me.tsbCancelar, Me.ToolStripSeparator1, Me.tslBuscar, Me.tstBuscar, Me.tsbBuscar})
        Me.tsVoluntarios.Location = New System.Drawing.Point(0, 0)
        Me.tsVoluntarios.Name = "tsVoluntarios"
        Me.tsVoluntarios.Size = New System.Drawing.Size(984, 27)
        Me.tsVoluntarios.TabIndex = 1
        Me.tsVoluntarios.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text ' Cambiado a Text
        Me.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(56, 24) ' Ajustar tamaño si es necesario
        Me.tsbNuevo.Text = "Nuevo"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text ' Cambiado a Text
        Me.tsbGuardar.Enabled = False
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(66, 24) ' Ajustar tamaño si es necesario
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text ' Cambiado a Text
        Me.tsbEliminar.Enabled = False
        Me.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(67, 24) ' Ajustar tamaño si es necesario
        Me.tsbEliminar.Text = "Eliminar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text ' Cambiado a Text
        Me.tsbCancelar.Enabled = False
        Me.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(70, 24) ' Ajustar tamaño si es necesario
        Me.tsbCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
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
        Me.tstBuscar.Size = New System.Drawing.Size(200, 27)
        '
        'tsbBuscar
        '
        Me.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text ' Cambiado a Text
        Me.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(56, 24) ' Ajustar tamaño si es necesario
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
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.dgvVoluntarios)
        '
        'SplitContainerPrincipal.Panel2
        '
        Me.SplitContainerPrincipal.Panel2.Controls.Add(Me.tabDetalles)
        Me.SplitContainerPrincipal.Size = New System.Drawing.Size(984, 728)
        Me.SplitContainerPrincipal.SplitterDistance = 248
        Me.SplitContainerPrincipal.TabIndex = 2
        '
        'dgvVoluntarios
        '
        Me.dgvVoluntarios.AllowUserToAddRows = False
        Me.dgvVoluntarios.AllowUserToDeleteRows = False
        Me.dgvVoluntarios.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvVoluntarios.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVoluntarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVoluntarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVoluntarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVoluntarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNif, Me.colNombreCompleto, Me.colCorreo, Me.colCurso})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVoluntarios.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVoluntarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVoluntarios.Location = New System.Drawing.Point(0, 0)
        Me.dgvVoluntarios.MultiSelect = False
        Me.dgvVoluntarios.Name = "dgvVoluntarios"
        Me.dgvVoluntarios.ReadOnly = True
        Me.dgvVoluntarios.RowHeadersWidth = 51
        Me.dgvVoluntarios.RowTemplate.Height = 24
        Me.dgvVoluntarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVoluntarios.Size = New System.Drawing.Size(984, 248)
        Me.dgvVoluntarios.TabIndex = 0
        '
        'colNif
        '
        Me.colNif.DataPropertyName = "Nif"
        Me.colNif.FillWeight = 80.0!
        Me.colNif.HeaderText = "NIF"
        Me.colNif.MinimumWidth = 6
        Me.colNif.Name = "colNif"
        Me.colNif.ReadOnly = True
        '
        'colNombreCompleto
        '
        Me.colNombreCompleto.DataPropertyName = "ApellidoNombre" ' Usamos la propiedad calculada
        Me.colNombreCompleto.FillWeight = 150.0!
        Me.colNombreCompleto.HeaderText = "Nombre Voluntario"
        Me.colNombreCompleto.MinimumWidth = 6
        Me.colNombreCompleto.Name = "colNombreCompleto"
        Me.colNombreCompleto.ReadOnly = True
        '
        'colCorreo
        '
        Me.colCorreo.DataPropertyName = "Correo"
        Me.colCorreo.HeaderText = "Correo Electrónico"
        Me.colCorreo.MinimumWidth = 6
        Me.colCorreo.Name = "colCorreo"
        Me.colCorreo.ReadOnly = True
        '
        'colCurso
        '
        Me.colCurso.DataPropertyName = "Estudia" ' El DataGridView mostrará el .ToString() del objeto Curso
        Me.colCurso.FillWeight = 70.0!
        Me.colCurso.HeaderText = "Curso"
        Me.colCurso.MinimumWidth = 6
        Me.colCurso.Name = "colCurso"
        Me.colCurso.ReadOnly = True
        '
        'tabDetalles
        '
        Me.tabDetalles.Controls.Add(Me.tpDetallesVoluntario)
        Me.tabDetalles.Controls.Add(Me.tpIntereses)
        Me.tabDetalles.Controls.Add(Me.tpDisponibilidad)
        Me.tabDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDetalles.Location = New System.Drawing.Point(0, 0)
        Me.tabDetalles.Name = "tabDetalles"
        Me.tabDetalles.SelectedIndex = 0
        Me.tabDetalles.Size = New System.Drawing.Size(984, 476)
        Me.tabDetalles.TabIndex = 0
        '
        'tpDetallesVoluntario
        '
        Me.tpDetallesVoluntario.Controls.Add(Me.gbDetallesVoluntario)
        Me.tpDetallesVoluntario.Location = New System.Drawing.Point(4, 25)
        Me.tpDetallesVoluntario.Name = "tpDetallesVoluntario"
        Me.tpDetallesVoluntario.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDetallesVoluntario.Size = New System.Drawing.Size(976, 447)
        Me.tpDetallesVoluntario.TabIndex = 0
        Me.tpDetallesVoluntario.Text = "Detalles Voluntario"
        Me.tpDetallesVoluntario.UseVisualStyleBackColor = True
        '
        'gbDetallesVoluntario
        '
        Me.gbDetallesVoluntario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetallesVoluntario.Controls.Add(Me.cmbCurso)
        Me.gbDetallesVoluntario.Controls.Add(Me.lblCurso)
        Me.gbDetallesVoluntario.Controls.Add(Me.txtExperiencia)
        Me.gbDetallesVoluntario.Controls.Add(Me.lblExperiencia)
        Me.gbDetallesVoluntario.Controls.Add(Me.txtCorreo)
        Me.gbDetallesVoluntario.Controls.Add(Me.lblCorreo)
        Me.gbDetallesVoluntario.Controls.Add(Me.txtTelefono)
        Me.gbDetallesVoluntario.Controls.Add(Me.lblTelefono)
        Me.gbDetallesVoluntario.Controls.Add(Me.txtApellido2)
        Me.gbDetallesVoluntario.Controls.Add(Me.lblApellido2)
        Me.gbDetallesVoluntario.Controls.Add(Me.txtApellido1)
        Me.gbDetallesVoluntario.Controls.Add(Me.lblApellido1)
        Me.gbDetallesVoluntario.Controls.Add(Me.txtNombre)
        Me.gbDetallesVoluntario.Controls.Add(Me.lblNombre)
        Me.gbDetallesVoluntario.Controls.Add(Me.txtNif)
        Me.gbDetallesVoluntario.Controls.Add(Me.lblNif)
        Me.gbDetallesVoluntario.Location = New System.Drawing.Point(6, 6)
        Me.gbDetallesVoluntario.Name = "gbDetallesVoluntario"
        Me.gbDetallesVoluntario.Size = New System.Drawing.Size(964, 435)
        Me.gbDetallesVoluntario.TabIndex = 0
        Me.gbDetallesVoluntario.TabStop = False
        Me.gbDetallesVoluntario.Text = "Información Personal"
        '
        'cmbCurso
        '
        Me.cmbCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(125, 169)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(290, 24)
        Me.cmbCurso.TabIndex = 7
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(16, 172)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(47, 16)
        Me.lblCurso.TabIndex = 14
        Me.lblCurso.Text = "Curso:"
        '
        'txtExperiencia
        '
        Me.txtExperiencia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExperiencia.Location = New System.Drawing.Point(125, 202)
        Me.txtExperiencia.Multiline = True
        Me.txtExperiencia.Name = "txtExperiencia"
        Me.txtExperiencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtExperiencia.Size = New System.Drawing.Size(818, 90)
        Me.txtExperiencia.TabIndex = 8
        '
        'lblExperiencia
        '
        Me.lblExperiencia.AutoSize = True
        Me.lblExperiencia.Location = New System.Drawing.Point(16, 205)
        Me.lblExperiencia.Name = "lblExperiencia"
        Me.lblExperiencia.Size = New System.Drawing.Size(81, 16)
        Me.lblExperiencia.TabIndex = 12
        Me.lblExperiencia.Text = "Experiencia:"
        '
        'txtCorreo
        '
        Me.txtCorreo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorreo.Location = New System.Drawing.Point(125, 136)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(818, 22)
        Me.txtCorreo.TabIndex = 6
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(16, 139)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(51, 16)
        Me.lblCorreo.TabIndex = 10
        Me.lblCorreo.Text = "Correo:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(555, 103)
        Me.txtTelefono.MaxLength = 9
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(130, 22)
        Me.txtTelefono.TabIndex = 5
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(475, 106)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(64, 16)
        Me.lblTelefono.TabIndex = 8
        Me.lblTelefono.Text = "Teléfono:"
        '
        'txtApellido2
        '
        Me.txtApellido2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApellido2.Location = New System.Drawing.Point(555, 70)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(388, 22)
        Me.txtApellido2.TabIndex = 3
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(475, 73)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(70, 16)
        Me.lblApellido2.TabIndex = 6
        Me.lblApellido2.Text = "Apellido 2:"
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(125, 70)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(290, 22)
        Me.txtApellido1.TabIndex = 2
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(16, 73)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(70, 16)
        Me.lblApellido1.TabIndex = 4
        Me.lblApellido1.Text = "Apellido 1:"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(330, 37)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(613, 22)
        Me.txtNombre.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(258, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(59, 16)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNif
        '
        Me.txtNif.Location = New System.Drawing.Point(125, 37)
        Me.txtNif.MaxLength = 10 ' Ajustar si NIE tiene formato diferente
        Me.txtNif.Name = "txtNif"
        Me.txtNif.Size = New System.Drawing.Size(115, 22)
        Me.txtNif.TabIndex = 0
        '
        'lblNif
        '
        Me.lblNif.AutoSize = True
        Me.lblNif.Location = New System.Drawing.Point(16, 40)
        Me.lblNif.Name = "lblNif"
        Me.lblNif.Size = New System.Drawing.Size(31, 16)
        Me.lblNif.TabIndex = 0
        Me.lblNif.Text = "NIF:"
        '
        'tpIntereses
        '
        Me.tpIntereses.Controls.Add(Me.gbIntereses)
        Me.tpIntereses.Location = New System.Drawing.Point(4, 25)
        Me.tpIntereses.Name = "tpIntereses"
        Me.tpIntereses.Padding = New System.Windows.Forms.Padding(3)
        Me.tpIntereses.Size = New System.Drawing.Size(976, 447)
        Me.tpIntereses.TabIndex = 1
        Me.tpIntereses.Text = "Intereses"
        Me.tpIntereses.UseVisualStyleBackColor = True
        '
        'gbIntereses
        '
        Me.gbIntereses.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbIntereses.Controls.Add(Me.btnQuitarInteres)
        Me.gbIntereses.Controls.Add(Me.btnAnadirInteres)
        Me.gbIntereses.Controls.Add(Me.lstTiposInteresado)
        Me.gbIntereses.Controls.Add(Me.lblTiposInteresado)
        Me.gbIntereses.Controls.Add(Me.lstTiposDisponibles)
        Me.gbIntereses.Controls.Add(Me.lblTiposDisponibles)
        Me.gbIntereses.Location = New System.Drawing.Point(6, 6)
        Me.gbIntereses.Name = "gbIntereses"
        Me.gbIntereses.Size = New System.Drawing.Size(962, 435)
        Me.gbIntereses.TabIndex = 1
        Me.gbIntereses.TabStop = False
        Me.gbIntereses.Text = "Áreas de Interés del Voluntario"
        '
        'btnQuitarInteres
        '
        Me.btnQuitarInteres.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnQuitarInteres.Enabled = False
        Me.btnQuitarInteres.Location = New System.Drawing.Point(450, 233)
        Me.btnQuitarInteres.Name = "btnQuitarInteres"
        Me.btnQuitarInteres.Size = New System.Drawing.Size(62, 30)
        Me.btnQuitarInteres.TabIndex = 3
        Me.btnQuitarInteres.Text = "<<"
        Me.btnQuitarInteres.UseVisualStyleBackColor = True
        '
        'btnAnadirInteres
        '
        Me.btnAnadirInteres.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnadirInteres.Enabled = False
        Me.btnAnadirInteres.Location = New System.Drawing.Point(450, 183)
        Me.btnAnadirInteres.Name = "btnAnadirInteres"
        Me.btnAnadirInteres.Size = New System.Drawing.Size(62, 30)
        Me.btnAnadirInteres.TabIndex = 1
        Me.btnAnadirInteres.Text = ">>"
        Me.btnAnadirInteres.UseVisualStyleBackColor = True
        '
        'lstTiposInteresado
        '
        Me.lstTiposInteresado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstTiposInteresado.DisplayMember = "Descripcion" ' Asume que la entidad Tipo tiene esta propiedad
        Me.lstTiposInteresado.Enabled = False
        Me.lstTiposInteresado.FormattingEnabled = True
        Me.lstTiposInteresado.ItemHeight = 16
        Me.lstTiposInteresado.Location = New System.Drawing.Point(531, 51)
        Me.lstTiposInteresado.Name = "lstTiposInteresado"
        Me.lstTiposInteresado.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTiposInteresado.Size = New System.Drawing.Size(414, 372)
        Me.lstTiposInteresado.TabIndex = 2
        '
        'lblTiposInteresado
        '
        Me.lblTiposInteresado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTiposInteresado.AutoSize = True
        Me.lblTiposInteresado.Location = New System.Drawing.Point(528, 32)
        Me.lblTiposInteresado.Name = "lblTiposInteresado"
        Me.lblTiposInteresado.Size = New System.Drawing.Size(133, 16)
        Me.lblTiposInteresado.TabIndex = 2
        Me.lblTiposInteresado.Text = "Interesado/a en tipo:"
        '
        'lstTiposDisponibles
        '
        Me.lstTiposDisponibles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstTiposDisponibles.DisplayMember = "Descripcion" ' Asume que la entidad Tipo tiene esta propiedad
        Me.lstTiposDisponibles.Enabled = False
        Me.lstTiposDisponibles.FormattingEnabled = True
        Me.lstTiposDisponibles.ItemHeight = 16
        Me.lstTiposDisponibles.Location = New System.Drawing.Point(19, 51)
        Me.lstTiposDisponibles.Name = "lstTiposDisponibles"
        Me.lstTiposDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTiposDisponibles.Size = New System.Drawing.Size(414, 372)
        Me.lstTiposDisponibles.TabIndex = 0
        '
        'lblTiposDisponibles
        '
        Me.lblTiposDisponibles.AutoSize = True
        Me.lblTiposDisponibles.Location = New System.Drawing.Point(16, 32)
        Me.lblTiposDisponibles.Name = "lblTiposDisponibles"
        Me.lblTiposDisponibles.Size = New System.Drawing.Size(120, 16)
        Me.lblTiposDisponibles.TabIndex = 0
        Me.lblTiposDisponibles.Text = "Tipos Disponibles:"
        '
        'tpDisponibilidad
        '
        Me.tpDisponibilidad.Controls.Add(Me.gbDisponibilidad)
        Me.tpDisponibilidad.Location = New System.Drawing.Point(4, 25)
        Me.tpDisponibilidad.Name = "tpDisponibilidad"
        Me.tpDisponibilidad.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDisponibilidad.Size = New System.Drawing.Size(976, 447)
        Me.tpDisponibilidad.TabIndex = 2
        Me.tpDisponibilidad.Text = "Disponibilidad"
        Me.tpDisponibilidad.UseVisualStyleBackColor = True
        '
        'gbDisponibilidad
        '
        Me.gbDisponibilidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDisponibilidad.Controls.Add(Me.btnQuitarDisponibilidad)
        Me.gbDisponibilidad.Controls.Add(Me.btnAnadirDisponibilidad)
        Me.gbDisponibilidad.Controls.Add(Me.lstHorasAsignadas)
        Me.gbDisponibilidad.Controls.Add(Me.lblHorasAsignadas)
        Me.gbDisponibilidad.Controls.Add(Me.lstHorasDisponibles)
        Me.gbDisponibilidad.Controls.Add(Me.lblHorasDisponibles)
        Me.gbDisponibilidad.Location = New System.Drawing.Point(6, 6)
        Me.gbDisponibilidad.Name = "gbDisponibilidad"
        Me.gbDisponibilidad.Size = New System.Drawing.Size(962, 435)
        Me.gbDisponibilidad.TabIndex = 2
        Me.gbDisponibilidad.TabStop = False
        Me.gbDisponibilidad.Text = "Horas de Disponibilidad del Voluntario"
        '
        'btnQuitarDisponibilidad
        '
        Me.btnQuitarDisponibilidad.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnQuitarDisponibilidad.Enabled = False
        Me.btnQuitarDisponibilidad.Location = New System.Drawing.Point(450, 233)
        Me.btnQuitarDisponibilidad.Name = "btnQuitarDisponibilidad"
        Me.btnQuitarDisponibilidad.Size = New System.Drawing.Size(62, 30)
        Me.btnQuitarDisponibilidad.TabIndex = 3
        Me.btnQuitarDisponibilidad.Text = "<<"
        Me.btnQuitarDisponibilidad.UseVisualStyleBackColor = True
        '
        'btnAnadirDisponibilidad
        '
        Me.btnAnadirDisponibilidad.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnadirDisponibilidad.Enabled = False
        Me.btnAnadirDisponibilidad.Location = New System.Drawing.Point(450, 183)
        Me.btnAnadirDisponibilidad.Name = "btnAnadirDisponibilidad"
        Me.btnAnadirDisponibilidad.Size = New System.Drawing.Size(62, 30)
        Me.btnAnadirDisponibilidad.TabIndex = 1
        Me.btnAnadirDisponibilidad.Text = ">>"
        Me.btnAnadirDisponibilidad.UseVisualStyleBackColor = True
        '
        'lstHorasAsignadas
        '
        Me.lstHorasAsignadas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstHorasAsignadas.DisplayMember = "DescripcionCompleta" ' Asume que la entidad Hora tiene esta propiedad (ej: "Lunes 09:00-14:00")
        Me.lstHorasAsignadas.Enabled = False
        Me.lstHorasAsignadas.FormattingEnabled = True
        Me.lstHorasAsignadas.ItemHeight = 16
        Me.lstHorasAsignadas.Location = New System.Drawing.Point(531, 51)
        Me.lstHorasAsignadas.Name = "lstHorasAsignadas"
        Me.lstHorasAsignadas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstHorasAsignadas.Size = New System.Drawing.Size(414, 372)
        Me.lstHorasAsignadas.TabIndex = 2
        '
        'lblHorasAsignadas
        '
        Me.lblHorasAsignadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHorasAsignadas.AutoSize = True
        Me.lblHorasAsignadas.Location = New System.Drawing.Point(528, 32)
        Me.lblHorasAsignadas.Name = "lblHorasAsignadas"
        Me.lblHorasAsignadas.Size = New System.Drawing.Size(139, 16)
        Me.lblHorasAsignadas.TabIndex = 2
        Me.lblHorasAsignadas.Text = "Disponible en Horas:"
        '
        'lstHorasDisponibles
        '
        Me.lstHorasDisponibles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstHorasDisponibles.DisplayMember = "DescripcionCompleta" ' Asume que la entidad Hora tiene esta propiedad (ej: "Lunes 09:00-14:00")
        Me.lstHorasDisponibles.Enabled = False
        Me.lstHorasDisponibles.FormattingEnabled = True
        Me.lstHorasDisponibles.ItemHeight = 16
        Me.lstHorasDisponibles.Location = New System.Drawing.Point(19, 51)
        Me.lstHorasDisponibles.Name = "lstHorasDisponibles"
        Me.lstHorasDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstHorasDisponibles.Size = New System.Drawing.Size(414, 372)
        Me.lstHorasDisponibles.TabIndex = 0
        '
        'lblHorasDisponibles
        '
        Me.lblHorasDisponibles.AutoSize = True
        Me.lblHorasDisponibles.Location = New System.Drawing.Point(16, 32)
        Me.lblHorasDisponibles.Name = "lblHorasDisponibles"
        Me.lblHorasDisponibles.Size = New System.Drawing.Size(185, 16)
        Me.lblHorasDisponibles.TabIndex = 0
        Me.lblHorasDisponibles.Text = "Posibles Horas Disponibles:"
        '
        'frmVoluntarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 755)
        Me.Controls.Add(Me.SplitContainerPrincipal)
        Me.Controls.Add(Me.tsVoluntarios)
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frmVoluntarios"
        Me.Text = "Gestión de Voluntarios"
        Me.tsVoluntarios.ResumeLayout(False)
        Me.tsVoluntarios.PerformLayout()
        Me.SplitContainerPrincipal.Panel1.ResumeLayout(False)
        Me.SplitContainerPrincipal.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPrincipal.ResumeLayout(False)
        CType(Me.dgvVoluntarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetalles.ResumeLayout(False)
        Me.tpDetallesVoluntario.ResumeLayout(False)
        Me.gbDetallesVoluntario.ResumeLayout(False)
        Me.gbDetallesVoluntario.PerformLayout()
        Me.tpIntereses.ResumeLayout(False)
        Me.gbIntereses.ResumeLayout(False)
        Me.gbIntereses.PerformLayout()
        Me.tpDisponibilidad.ResumeLayout(False)
        Me.gbDisponibilidad.ResumeLayout(False)
        Me.gbDisponibilidad.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    '*** Lista ÚNICA de declaraciones WithEvents ***
    Friend WithEvents tsVoluntarios As ToolStrip
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbEliminar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tslBuscar As ToolStripLabel
    Friend WithEvents tstBuscar As ToolStripTextBox
    Friend WithEvents tsbBuscar As ToolStripButton
    Friend WithEvents SplitContainerPrincipal As SplitContainer
    Friend WithEvents dgvVoluntarios As DataGridView
    Friend WithEvents tabDetalles As TabControl
    Friend WithEvents tpDetallesVoluntario As TabPage
    Friend WithEvents gbDetallesVoluntario As GroupBox
    Friend WithEvents txtNif As TextBox
    Friend WithEvents lblNif As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtExperiencia As TextBox
    Friend WithEvents lblExperiencia As Label
    Friend WithEvents cmbCurso As ComboBox
    Friend WithEvents lblCurso As Label
    Friend WithEvents tpIntereses As TabPage
    Friend WithEvents gbIntereses As GroupBox
    Friend WithEvents btnQuitarInteres As Button
    Friend WithEvents btnAnadirInteres As Button
    Friend WithEvents lstTiposInteresado As ListBox
    Friend WithEvents lblTiposInteresado As Label
    Friend WithEvents lstTiposDisponibles As ListBox
    Friend WithEvents lblTiposDisponibles As Label
    Friend WithEvents tpDisponibilidad As TabPage
    Friend WithEvents gbDisponibilidad As GroupBox
    Friend WithEvents btnQuitarDisponibilidad As Button
    Friend WithEvents btnAnadirDisponibilidad As Button
    Friend WithEvents lstHorasAsignadas As ListBox
    Friend WithEvents lblHorasAsignadas As Label
    Friend WithEvents lstHorasDisponibles As ListBox
    Friend WithEvents lblHorasDisponibles As Label ' Asegurarse que solo está aquí una vez
    Friend WithEvents colNif As DataGridViewTextBoxColumn
    Friend WithEvents colNombreCompleto As DataGridViewTextBoxColumn
    Friend WithEvents colCorreo As DataGridViewTextBoxColumn
    Friend WithEvents colCurso As DataGridViewTextBoxColumn
End Class