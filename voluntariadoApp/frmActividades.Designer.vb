<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActividades
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tsActividades = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevo = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsbEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsbCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.tstBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbBuscar = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainerPrincipal = New System.Windows.Forms.SplitContainer()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrganizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tabDetalles = New System.Windows.Forms.TabControl()
        Me.tpDetallesActividad = New System.Windows.Forms.TabPage()
        Me.gbDetallesActividad = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.cmbTecnicidad = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpHoraFinActividad = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpHoraInicioActividad = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLugarActividad = New System.Windows.Forms.TextBox()
        Me.cmbOrganizacionActividad = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEstadoActividad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescActividad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombreActividad = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtIDActividad = New System.Windows.Forms.TextBox()
        Me.tpODS = New System.Windows.Forms.TabPage()
        Me.gbODS = New System.Windows.Forms.GroupBox()
        Me.btnQuitarOds = New System.Windows.Forms.Button()
        Me.btnAnadirOds = New System.Windows.Forms.Button()
        Me.lstOdsAsignados = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lstOdsDisponibles = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tpVoluntarios = New System.Windows.Forms.TabPage()
        Me.gbVoluntarios = New System.Windows.Forms.GroupBox()
        Me.btnQuitarVoluntario = New System.Windows.Forms.Button()
        Me.btnAnadirVoluntario = New System.Windows.Forms.Button()
        Me.lstVoluntariosAsignados = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lstVoluntariosDisponibles = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tpTipos = New System.Windows.Forms.TabPage()
        Me.gbTipos = New System.Windows.Forms.GroupBox()
        Me.btnQuitarTipo = New System.Windows.Forms.Button()
        Me.btnAnadirTipo = New System.Windows.Forms.Button()
        Me.lstTiposAsignados = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lstTiposDisponibles = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tsActividades.SuspendLayout()
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerPrincipal.Panel1.SuspendLayout()
        Me.SplitContainerPrincipal.Panel2.SuspendLayout()
        Me.SplitContainerPrincipal.SuspendLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDetalles.SuspendLayout()
        Me.tpDetallesActividad.SuspendLayout()
        Me.gbDetallesActividad.SuspendLayout()
        Me.tpODS.SuspendLayout()
        Me.gbODS.SuspendLayout()
        Me.tpVoluntarios.SuspendLayout()
        Me.gbVoluntarios.SuspendLayout()
        Me.tpTipos.SuspendLayout()
        Me.gbTipos.SuspendLayout()
        Me.SuspendLayout()
        '
        'tsActividades
        '
        Me.tsActividades.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.tsActividades.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbGuardar, Me.tsbEliminar, Me.tsbCancelar, Me.ToolStripSeparator1, Me.tslBuscar, Me.tstBuscar, Me.tsbBuscar})
        Me.tsActividades.Location = New System.Drawing.Point(0, 0)
        Me.tsActividades.Name = "tsActividades"
        Me.tsActividades.Size = New System.Drawing.Size(1107, 38)
        Me.tsActividades.TabIndex = 0
        Me.tsActividades.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(68, 33)
        Me.tsbNuevo.Text = "Nuevo"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuardar.Enabled = False
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(79, 33)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbEliminar.Enabled = False
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(78, 33)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCancelar.Enabled = False
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(82, 33)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'tslBuscar
        '
        Me.tslBuscar.Name = "tslBuscar"
        Me.tslBuscar.Size = New System.Drawing.Size(67, 33)
        Me.tslBuscar.Text = "Buscar:"
        '
        'tstBuscar
        '
        Me.tstBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstBuscar.Name = "tstBuscar"
        Me.tstBuscar.Size = New System.Drawing.Size(225, 38)
        '
        'tsbBuscar
        '
        Me.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBuscar.Name = "tsbBuscar"
        Me.tsbBuscar.Size = New System.Drawing.Size(67, 33)
        Me.tsbBuscar.Text = "Buscar"
        '
        'SplitContainerPrincipal
        '
        Me.SplitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPrincipal.Location = New System.Drawing.Point(0, 38)
        Me.SplitContainerPrincipal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainerPrincipal.Name = "SplitContainerPrincipal"
        Me.SplitContainerPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerPrincipal.Panel1
        '
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.dgvActividades)
        '
        'SplitContainerPrincipal.Panel2
        '
        Me.SplitContainerPrincipal.Panel2.Controls.Add(Me.tabDetalles)
        Me.SplitContainerPrincipal.Size = New System.Drawing.Size(1107, 906)
        Me.SplitContainerPrincipal.SplitterDistance = 308
        Me.SplitContainerPrincipal.SplitterWidth = 5
        Me.SplitContainerPrincipal.TabIndex = 1
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToAddRows = False
        Me.dgvActividades.AllowUserToDeleteRows = False
        Me.dgvActividades.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvActividades.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvActividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvActividades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colNombre, Me.colEstado, Me.colOrganizacion})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvActividades.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvActividades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvActividades.Location = New System.Drawing.Point(0, 0)
        Me.dgvActividades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvActividades.MultiSelect = False
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.ReadOnly = True
        Me.dgvActividades.RowHeadersWidth = 51
        Me.dgvActividades.RowTemplate.Height = 24
        Me.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActividades.Size = New System.Drawing.Size(1107, 308)
        Me.dgvActividades.TabIndex = 0
        '
        'colID
        '
        Me.colID.DataPropertyName = "ID"
        Me.colID.FillWeight = 50.0!
        Me.colID.HeaderText = "ID"
        Me.colID.MinimumWidth = 6
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.DataPropertyName = "NOMBRE"
        Me.colNombre.FillWeight = 150.0!
        Me.colNombre.HeaderText = "Nombre Actividad"
        Me.colNombre.MinimumWidth = 6
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'colEstado
        '
        Me.colEstado.DataPropertyName = "ESTADO"
        Me.colEstado.FillWeight = 70.0!
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.MinimumWidth = 6
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        '
        'colOrganizacion
        '
        Me.colOrganizacion.DataPropertyName = "CONVOCADA_POR"
        Me.colOrganizacion.HeaderText = "Organización"
        Me.colOrganizacion.MinimumWidth = 6
        Me.colOrganizacion.Name = "colOrganizacion"
        Me.colOrganizacion.ReadOnly = True
        '
        'tabDetalles
        '
        Me.tabDetalles.Controls.Add(Me.tpDetallesActividad)
        Me.tabDetalles.Controls.Add(Me.tpODS)
        Me.tabDetalles.Controls.Add(Me.tpVoluntarios)
        Me.tabDetalles.Controls.Add(Me.tpTipos)
        Me.tabDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDetalles.Location = New System.Drawing.Point(0, 0)
        Me.tabDetalles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tabDetalles.Name = "tabDetalles"
        Me.tabDetalles.SelectedIndex = 0
        Me.tabDetalles.Size = New System.Drawing.Size(1107, 593)
        Me.tabDetalles.TabIndex = 0
        '
        'tpDetallesActividad
        '
        Me.tpDetallesActividad.Controls.Add(Me.gbDetallesActividad)
        Me.tpDetallesActividad.Location = New System.Drawing.Point(4, 29)
        Me.tpDetallesActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpDetallesActividad.Name = "tpDetallesActividad"
        Me.tpDetallesActividad.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpDetallesActividad.Size = New System.Drawing.Size(1099, 560)
        Me.tpDetallesActividad.TabIndex = 0
        Me.tpDetallesActividad.Text = "Detalles Actividad"
        Me.tpDetallesActividad.UseVisualStyleBackColor = True
        '
        'gbDetallesActividad
        '
        Me.gbDetallesActividad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDetallesActividad.Controls.Add(Me.dtpFechaFin)
        Me.gbDetallesActividad.Controls.Add(Me.lblFechaFin)
        Me.gbDetallesActividad.Controls.Add(Me.dtpFechaInicio)
        Me.gbDetallesActividad.Controls.Add(Me.lblFechaInicio)
        Me.gbDetallesActividad.Controls.Add(Me.cmbTecnicidad)
        Me.gbDetallesActividad.Controls.Add(Me.Label8)
        Me.gbDetallesActividad.Controls.Add(Me.dtpHoraFinActividad)
        Me.gbDetallesActividad.Controls.Add(Me.Label7)
        Me.gbDetallesActividad.Controls.Add(Me.dtpHoraInicioActividad)
        Me.gbDetallesActividad.Controls.Add(Me.Label6)
        Me.gbDetallesActividad.Controls.Add(Me.Label4)
        Me.gbDetallesActividad.Controls.Add(Me.txtLugarActividad)
        Me.gbDetallesActividad.Controls.Add(Me.cmbOrganizacionActividad)
        Me.gbDetallesActividad.Controls.Add(Me.Label3)
        Me.gbDetallesActividad.Controls.Add(Me.cmbEstadoActividad)
        Me.gbDetallesActividad.Controls.Add(Me.Label2)
        Me.gbDetallesActividad.Controls.Add(Me.txtDescActividad)
        Me.gbDetallesActividad.Controls.Add(Me.Label1)
        Me.gbDetallesActividad.Controls.Add(Me.lblNombre)
        Me.gbDetallesActividad.Controls.Add(Me.txtNombreActividad)
        Me.gbDetallesActividad.Controls.Add(Me.lblID)
        Me.gbDetallesActividad.Controls.Add(Me.txtIDActividad)
        Me.gbDetallesActividad.Location = New System.Drawing.Point(7, 8)
        Me.gbDetallesActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbDetallesActividad.Name = "gbDetallesActividad"
        Me.gbDetallesActividad.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbDetallesActividad.Size = New System.Drawing.Size(1084, 542)
        Me.gbDetallesActividad.TabIndex = 0
        Me.gbDetallesActividad.TabStop = False
        Me.gbDetallesActividad.Text = "Información de la Actividad"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(382, 311)
        Me.dtpFechaFin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(134, 26)
        Me.dtpFechaFin.TabIndex = 7
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(304, 315)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(84, 20)
        Me.lblFechaFin.TabIndex = 23
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(124, 311)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(134, 26)
        Me.dtpFechaInicio.TabIndex = 6
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(18, 315)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(99, 20)
        Me.lblFechaInicio.TabIndex = 21
        Me.lblFechaInicio.Text = "Fecha Inicio:"
        '
        'cmbTecnicidad
        '
        Me.cmbTecnicidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTecnicidad.FormattingEnabled = True
        Me.cmbTecnicidad.Items.AddRange(New Object() {"Si", "No"})
        Me.cmbTecnicidad.Location = New System.Drawing.Point(181, 386)
        Me.cmbTecnicidad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbTecnicidad.Name = "cmbTecnicidad"
        Me.cmbTecnicidad.Size = New System.Drawing.Size(77, 28)
        Me.cmbTecnicidad.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tecnicidad (si aplica):"
        '
        'dtpHoraFinActividad
        '
        Me.dtpHoraFinActividad.CustomFormat = "HH:mm"
        Me.dtpHoraFinActividad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFinActividad.Location = New System.Drawing.Point(855, 311)
        Me.dtpHoraFinActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpHoraFinActividad.Name = "dtpHoraFinActividad"
        Me.dtpHoraFinActividad.ShowUpDown = True
        Me.dtpHoraFinActividad.Size = New System.Drawing.Size(100, 26)
        Me.dtpHoraFinActividad.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(776, 315)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Hora fin:"
        '
        'dtpHoraInicioActividad
        '
        Me.dtpHoraInicioActividad.CustomFormat = "HH:mm"
        Me.dtpHoraInicioActividad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicioActividad.Location = New System.Drawing.Point(652, 311)
        Me.dtpHoraInicioActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtpHoraInicioActividad.Name = "dtpHoraInicioActividad"
        Me.dtpHoraInicioActividad.ShowUpDown = True
        Me.dtpHoraInicioActividad.Size = New System.Drawing.Size(100, 26)
        Me.dtpHoraInicioActividad.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(562, 315)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Hora inicio:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 276)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Lugar:"
        '
        'txtLugarActividad
        '
        Me.txtLugarActividad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLugarActividad.Location = New System.Drawing.Point(191, 272)
        Me.txtLugarActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtLugarActividad.Name = "txtLugarActividad"
        Me.txtLugarActividad.Size = New System.Drawing.Size(874, 26)
        Me.txtLugarActividad.TabIndex = 5
        '
        'cmbOrganizacionActividad
        '
        Me.cmbOrganizacionActividad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOrganizacionActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrganizacionActividad.FormattingEnabled = True
        Me.cmbOrganizacionActividad.Location = New System.Drawing.Point(191, 234)
        Me.cmbOrganizacionActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbOrganizacionActividad.Name = "cmbOrganizacionActividad"
        Me.cmbOrganizacionActividad.Size = New System.Drawing.Size(540, 28)
        Me.cmbOrganizacionActividad.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Organización:"
        '
        'cmbEstadoActividad
        '
        Me.cmbEstadoActividad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEstadoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoActividad.FormattingEnabled = True
        Me.cmbEstadoActividad.Items.AddRange(New Object() {"Pendiente", "Activa", "Finalizada", "Cancelada", "Rechazada"})
        Me.cmbEstadoActividad.Location = New System.Drawing.Point(847, 234)
        Me.cmbEstadoActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbEstadoActividad.Name = "cmbEstadoActividad"
        Me.cmbEstadoActividad.Size = New System.Drawing.Size(218, 28)
        Me.cmbEstadoActividad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(775, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Estado:"
        '
        'txtDescActividad
        '
        Me.txtDescActividad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescActividad.Location = New System.Drawing.Point(191, 118)
        Me.txtDescActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescActividad.Multiline = True
        Me.txtDescActividad.Name = "txtDescActividad"
        Me.txtDescActividad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescActividad.Size = New System.Drawing.Size(874, 105)
        Me.txtDescActividad.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Descripción:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(18, 82)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombreActividad
        '
        Me.txtNombreActividad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreActividad.Location = New System.Drawing.Point(191, 79)
        Me.txtNombreActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombreActividad.Name = "txtNombreActividad"
        Me.txtNombreActividad.Size = New System.Drawing.Size(874, 26)
        Me.txtNombreActividad.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(18, 44)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(30, 20)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID:"
        '
        'txtIDActividad
        '
        Me.txtIDActividad.Location = New System.Drawing.Point(191, 40)
        Me.txtIDActividad.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtIDActividad.Name = "txtIDActividad"
        Me.txtIDActividad.ReadOnly = True
        Me.txtIDActividad.Size = New System.Drawing.Size(112, 26)
        Me.txtIDActividad.TabIndex = 0
        Me.txtIDActividad.TabStop = False
        '
        'tpODS
        '
        Me.tpODS.Controls.Add(Me.gbODS)
        Me.tpODS.Location = New System.Drawing.Point(4, 29)
        Me.tpODS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpODS.Name = "tpODS"
        Me.tpODS.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpODS.Size = New System.Drawing.Size(1099, 562)
        Me.tpODS.TabIndex = 1
        Me.tpODS.Text = "ODS"
        Me.tpODS.UseVisualStyleBackColor = True
        '
        'gbODS
        '
        Me.gbODS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbODS.Controls.Add(Me.btnQuitarOds)
        Me.gbODS.Controls.Add(Me.btnAnadirOds)
        Me.gbODS.Controls.Add(Me.lstOdsAsignados)
        Me.gbODS.Controls.Add(Me.Label10)
        Me.gbODS.Controls.Add(Me.lstOdsDisponibles)
        Me.gbODS.Controls.Add(Me.Label9)
        Me.gbODS.Location = New System.Drawing.Point(7, 8)
        Me.gbODS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbODS.Name = "gbODS"
        Me.gbODS.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbODS.Size = New System.Drawing.Size(1082, 544)
        Me.gbODS.TabIndex = 0
        Me.gbODS.TabStop = False
        Me.gbODS.Text = "ODS que Cumple la Actividad"
        '
        'btnQuitarOds
        '
        Me.btnQuitarOds.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnQuitarOds.Location = New System.Drawing.Point(506, 291)
        Me.btnQuitarOds.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuitarOds.Name = "btnQuitarOds"
        Me.btnQuitarOds.Size = New System.Drawing.Size(70, 38)
        Me.btnQuitarOds.TabIndex = 3
        Me.btnQuitarOds.Text = "<<"
        Me.btnQuitarOds.UseVisualStyleBackColor = True
        '
        'btnAnadirOds
        '
        Me.btnAnadirOds.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnadirOds.Location = New System.Drawing.Point(506, 229)
        Me.btnAnadirOds.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnadirOds.Name = "btnAnadirOds"
        Me.btnAnadirOds.Size = New System.Drawing.Size(70, 38)
        Me.btnAnadirOds.TabIndex = 1
        Me.btnAnadirOds.Text = ">>"
        Me.btnAnadirOds.UseVisualStyleBackColor = True
        '
        'lstOdsAsignados
        '
        Me.lstOdsAsignados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstOdsAsignados.FormattingEnabled = True
        Me.lstOdsAsignados.ItemHeight = 20
        Me.lstOdsAsignados.Location = New System.Drawing.Point(597, 64)
        Me.lstOdsAsignados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstOdsAsignados.Name = "lstOdsAsignados"
        Me.lstOdsAsignados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstOdsAsignados.Size = New System.Drawing.Size(465, 464)
        Me.lstOdsAsignados.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(594, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "ODS Asignados:"
        '
        'lstOdsDisponibles
        '
        Me.lstOdsDisponibles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstOdsDisponibles.FormattingEnabled = True
        Me.lstOdsDisponibles.ItemHeight = 20
        Me.lstOdsDisponibles.Location = New System.Drawing.Point(21, 64)
        Me.lstOdsDisponibles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstOdsDisponibles.Name = "lstOdsDisponibles"
        Me.lstOdsDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstOdsDisponibles.Size = New System.Drawing.Size(465, 464)
        Me.lstOdsDisponibles.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(134, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ODS Disponibles:"
        '
        'tpVoluntarios
        '
        Me.tpVoluntarios.Controls.Add(Me.gbVoluntarios)
        Me.tpVoluntarios.Location = New System.Drawing.Point(4, 29)
        Me.tpVoluntarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpVoluntarios.Name = "tpVoluntarios"
        Me.tpVoluntarios.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpVoluntarios.Size = New System.Drawing.Size(1099, 562)
        Me.tpVoluntarios.TabIndex = 2
        Me.tpVoluntarios.Text = "Voluntarios"
        Me.tpVoluntarios.UseVisualStyleBackColor = True
        '
        'gbVoluntarios
        '
        Me.gbVoluntarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbVoluntarios.Controls.Add(Me.btnQuitarVoluntario)
        Me.gbVoluntarios.Controls.Add(Me.btnAnadirVoluntario)
        Me.gbVoluntarios.Controls.Add(Me.lstVoluntariosAsignados)
        Me.gbVoluntarios.Controls.Add(Me.Label11)
        Me.gbVoluntarios.Controls.Add(Me.lstVoluntariosDisponibles)
        Me.gbVoluntarios.Controls.Add(Me.Label12)
        Me.gbVoluntarios.Location = New System.Drawing.Point(7, 8)
        Me.gbVoluntarios.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbVoluntarios.Name = "gbVoluntarios"
        Me.gbVoluntarios.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbVoluntarios.Size = New System.Drawing.Size(1082, 544)
        Me.gbVoluntarios.TabIndex = 1
        Me.gbVoluntarios.TabStop = False
        Me.gbVoluntarios.Text = "Voluntarios que Realizan la Actividad"
        '
        'btnQuitarVoluntario
        '
        Me.btnQuitarVoluntario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnQuitarVoluntario.Location = New System.Drawing.Point(506, 291)
        Me.btnQuitarVoluntario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuitarVoluntario.Name = "btnQuitarVoluntario"
        Me.btnQuitarVoluntario.Size = New System.Drawing.Size(70, 38)
        Me.btnQuitarVoluntario.TabIndex = 3
        Me.btnQuitarVoluntario.Text = "<<"
        Me.btnQuitarVoluntario.UseVisualStyleBackColor = True
        '
        'btnAnadirVoluntario
        '
        Me.btnAnadirVoluntario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnadirVoluntario.Location = New System.Drawing.Point(506, 229)
        Me.btnAnadirVoluntario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnadirVoluntario.Name = "btnAnadirVoluntario"
        Me.btnAnadirVoluntario.Size = New System.Drawing.Size(70, 38)
        Me.btnAnadirVoluntario.TabIndex = 1
        Me.btnAnadirVoluntario.Text = ">>"
        Me.btnAnadirVoluntario.UseVisualStyleBackColor = True
        '
        'lstVoluntariosAsignados
        '
        Me.lstVoluntariosAsignados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstVoluntariosAsignados.FormattingEnabled = True
        Me.lstVoluntariosAsignados.ItemHeight = 20
        Me.lstVoluntariosAsignados.Location = New System.Drawing.Point(597, 64)
        Me.lstVoluntariosAsignados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstVoluntariosAsignados.Name = "lstVoluntariosAsignados"
        Me.lstVoluntariosAsignados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstVoluntariosAsignados.Size = New System.Drawing.Size(465, 464)
        Me.lstVoluntariosAsignados.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(594, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(172, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Voluntarios Asignados:"
        '
        'lstVoluntariosDisponibles
        '
        Me.lstVoluntariosDisponibles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstVoluntariosDisponibles.FormattingEnabled = True
        Me.lstVoluntariosDisponibles.ItemHeight = 20
        Me.lstVoluntariosDisponibles.Location = New System.Drawing.Point(21, 64)
        Me.lstVoluntariosDisponibles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstVoluntariosDisponibles.Name = "lstVoluntariosDisponibles"
        Me.lstVoluntariosDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstVoluntariosDisponibles.Size = New System.Drawing.Size(465, 464)
        Me.lstVoluntariosDisponibles.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(179, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Voluntarios Disponibles:"
        '
        'tpTipos
        '
        Me.tpTipos.Controls.Add(Me.gbTipos)
        Me.tpTipos.Location = New System.Drawing.Point(4, 29)
        Me.tpTipos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpTipos.Name = "tpTipos"
        Me.tpTipos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tpTipos.Size = New System.Drawing.Size(1099, 562)
        Me.tpTipos.TabIndex = 3
        Me.tpTipos.Text = "Tipos"
        Me.tpTipos.UseVisualStyleBackColor = True
        '
        'gbTipos
        '
        Me.gbTipos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbTipos.Controls.Add(Me.btnQuitarTipo)
        Me.gbTipos.Controls.Add(Me.btnAnadirTipo)
        Me.gbTipos.Controls.Add(Me.lstTiposAsignados)
        Me.gbTipos.Controls.Add(Me.Label13)
        Me.gbTipos.Controls.Add(Me.lstTiposDisponibles)
        Me.gbTipos.Controls.Add(Me.Label14)
        Me.gbTipos.Location = New System.Drawing.Point(7, 8)
        Me.gbTipos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbTipos.Name = "gbTipos"
        Me.gbTipos.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.gbTipos.Size = New System.Drawing.Size(1082, 544)
        Me.gbTipos.TabIndex = 2
        Me.gbTipos.TabStop = False
        Me.gbTipos.Text = "Tipos de la Actividad"
        '
        'btnQuitarTipo
        '
        Me.btnQuitarTipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnQuitarTipo.Location = New System.Drawing.Point(506, 291)
        Me.btnQuitarTipo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnQuitarTipo.Name = "btnQuitarTipo"
        Me.btnQuitarTipo.Size = New System.Drawing.Size(70, 38)
        Me.btnQuitarTipo.TabIndex = 3
        Me.btnQuitarTipo.Text = "<<"
        Me.btnQuitarTipo.UseVisualStyleBackColor = True
        '
        'btnAnadirTipo
        '
        Me.btnAnadirTipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnadirTipo.Location = New System.Drawing.Point(506, 229)
        Me.btnAnadirTipo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnadirTipo.Name = "btnAnadirTipo"
        Me.btnAnadirTipo.Size = New System.Drawing.Size(70, 38)
        Me.btnAnadirTipo.TabIndex = 1
        Me.btnAnadirTipo.Text = ">>"
        Me.btnAnadirTipo.UseVisualStyleBackColor = True
        '
        'lstTiposAsignados
        '
        Me.lstTiposAsignados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstTiposAsignados.FormattingEnabled = True
        Me.lstTiposAsignados.ItemHeight = 20
        Me.lstTiposAsignados.Location = New System.Drawing.Point(597, 64)
        Me.lstTiposAsignados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstTiposAsignados.Name = "lstTiposAsignados"
        Me.lstTiposAsignados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTiposAsignados.Size = New System.Drawing.Size(465, 464)
        Me.lstTiposAsignados.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(594, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(130, 20)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Tipos Asignados:"
        '
        'lstTiposDisponibles
        '
        Me.lstTiposDisponibles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstTiposDisponibles.FormattingEnabled = True
        Me.lstTiposDisponibles.ItemHeight = 20
        Me.lstTiposDisponibles.Location = New System.Drawing.Point(21, 64)
        Me.lstTiposDisponibles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lstTiposDisponibles.Name = "lstTiposDisponibles"
        Me.lstTiposDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTiposDisponibles.Size = New System.Drawing.Size(465, 464)
        Me.lstTiposDisponibles.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 40)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 20)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Tipos Disponibles:"
        '
        'Actividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 944)
        Me.Controls.Add(Me.SplitContainerPrincipal)
        Me.Controls.Add(Me.tsActividades)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(897, 736)
        Me.Name = "Actividades"
        Me.Text = "Gestión de Actividades"
        Me.tsActividades.ResumeLayout(False)
        Me.tsActividades.PerformLayout()
        Me.SplitContainerPrincipal.Panel1.ResumeLayout(False)
        Me.SplitContainerPrincipal.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerPrincipal.ResumeLayout(False)
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDetalles.ResumeLayout(False)
        Me.tpDetallesActividad.ResumeLayout(False)
        Me.gbDetallesActividad.ResumeLayout(False)
        Me.gbDetallesActividad.PerformLayout()
        Me.tpODS.ResumeLayout(False)
        Me.gbODS.ResumeLayout(False)
        Me.gbODS.PerformLayout()
        Me.tpVoluntarios.ResumeLayout(False)
        Me.gbVoluntarios.ResumeLayout(False)
        Me.gbVoluntarios.PerformLayout()
        Me.tpTipos.ResumeLayout(False)
        Me.gbTipos.ResumeLayout(False)
        Me.gbTipos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsActividades As ToolStrip
    Friend WithEvents tsbNuevo As ToolStripButton
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbEliminar As ToolStripButton
    Friend WithEvents tsbCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tslBuscar As ToolStripLabel
    Friend WithEvents tstBuscar As ToolStripTextBox
    Friend WithEvents tsbBuscar As ToolStripButton
    Friend WithEvents SplitContainerPrincipal As SplitContainer
    Friend WithEvents dgvActividades As DataGridView
    Friend WithEvents tabDetalles As TabControl
    Friend WithEvents tpDetallesActividad As TabPage
    Friend WithEvents gbDetallesActividad As GroupBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombreActividad As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtIDActividad As TextBox
    Friend WithEvents txtDescActividad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbEstadoActividad As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbOrganizacionActividad As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLugarActividad As TextBox
    Friend WithEvents dtpHoraInicioActividad As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpHoraFinActividad As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tpODS As TabPage
    Friend WithEvents gbODS As GroupBox
    Friend WithEvents lstOdsDisponibles As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lstOdsAsignados As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnQuitarOds As Button
    Friend WithEvents btnAnadirOds As Button
    Friend WithEvents tpVoluntarios As TabPage
    Friend WithEvents gbVoluntarios As GroupBox
    Friend WithEvents btnQuitarVoluntario As Button
    Friend WithEvents btnAnadirVoluntario As Button
    Friend WithEvents lstVoluntariosAsignados As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lstVoluntariosDisponibles As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tpTipos As TabPage
    Friend WithEvents gbTipos As GroupBox
    Friend WithEvents btnQuitarTipo As Button
    Friend WithEvents btnAnadirTipo As Button
    Friend WithEvents lstTiposAsignados As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents lstTiposDisponibles As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colNombre As DataGridViewTextBoxColumn
    Friend WithEvents colEstado As DataGridViewTextBoxColumn
    Friend WithEvents colOrganizacion As DataGridViewTextBoxColumn
    Friend WithEvents cmbTecnicidad As ComboBox
    Friend WithEvents dtpFechaInicio As DateTimePicker ' *** NUEVO ***
    Friend WithEvents lblFechaInicio As Label ' *** NUEVO ***
    Friend WithEvents dtpFechaFin As DateTimePicker ' *** NUEVO ***
    Friend WithEvents lblFechaFin As Label ' *** NUEVO ***
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmbCursoTecnico As ComboBox
    Friend WithEvents lblCursoTecnico As Label
End Class