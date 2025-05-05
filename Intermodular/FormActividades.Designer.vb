<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormActividades
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
        Me.SplitContainerPrincipal = New System.Windows.Forms.SplitContainer()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOrganizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTecnicoDe = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me._ControlesObligatorios = New Control() {Me.SplitContainerPrincipal,
            Me.txtNombreActividad,
            Me.cmbOrganizacionActividad,
            Me.cmbEstadoActividad,
            Me.dtpHoraInicioActividad,
            Me.dtpHoraFinActividad,
            Me.dtpFechaInicio,
            Me.dtpFechaFin}
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
        Me.tsActividades.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevo, Me.tsbGuardar, Me.tsbEliminar, Me.tsbCancelar})
        Me.tsActividades.Location = New System.Drawing.Point(0, 0)
        Me.tsActividades.Name = "tsActividades"
        Me.tsActividades.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.tsActividades.Size = New System.Drawing.Size(1476, 42)
        Me.tsActividades.TabIndex = 0
        Me.tsActividades.Text = "ToolStrip1"
        '
        'tsbNuevo
        '
        Me.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbNuevo.Name = "tsbNuevo"
        Me.tsbNuevo.Size = New System.Drawing.Size(89, 36)
        Me.tsbNuevo.Text = "Nuevo"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbGuardar.Enabled = True
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(102, 36)
        Me.tsbGuardar.Text = "Guardar"
        '
        'tsbEliminar
        '
        Me.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbEliminar.Enabled = False
        Me.tsbEliminar.Name = "tsbEliminar"
        Me.tsbEliminar.Size = New System.Drawing.Size(103, 36)
        Me.tsbEliminar.Text = "Eliminar"
        '
        'tsbCancelar
        '
        Me.tsbCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbCancelar.Enabled = True
        Me.tsbCancelar.Name = "tsbCancelar"
        Me.tsbCancelar.Size = New System.Drawing.Size(109, 36)
        Me.tsbCancelar.Text = "Cancelar"
        '
        'SplitContainerPrincipal
        '
        Me.SplitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPrincipal.Location = New System.Drawing.Point(0, 42)
        Me.SplitContainerPrincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
        Me.SplitContainerPrincipal.Size = New System.Drawing.Size(1476, 1138)
        Me.SplitContainerPrincipal.SplitterDistance = 386
        Me.SplitContainerPrincipal.SplitterWidth = 6
        Me.SplitContainerPrincipal.TabIndex = 1
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToAddRows = True
        Me.dgvActividades.AllowUserToDeleteRows = True
        Me.dgvActividades.AllowUserToResizeRows = False
        Me.dgvActividades.AutoGenerateColumns = False
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
        Me.dgvActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colNombre, Me.colDescripcion, Me.colEstado, Me.colOrganizacion, Me.colInicio, Me.colFin, Me.colTecnicoDe})
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
        Me.dgvActividades.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvActividades.MultiSelect = False
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.RowHeadersWidth = 51
        Me.dgvActividades.RowTemplate.Height = 24
        Me.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvActividades.Size = New System.Drawing.Size(1476, 386)
        Me.dgvActividades.TabIndex = 0
        '
        'colID
        '
        Me.colID.DataPropertyName = "Id"
        Me.colID.FillWeight = 50.0!
        Me.colID.HeaderText = "ID"
        Me.colID.MinimumWidth = 6
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        '
        'colNombre
        '
        Me.colNombre.DataPropertyName = "Nombre"
        Me.colNombre.FillWeight = 150.0!
        Me.colNombre.HeaderText = "Nombre"
        Me.colNombre.MinimumWidth = 6
        Me.colNombre.Name = "colNombre"
        Me.colNombre.ReadOnly = True
        '
        'colDescripcion
        '
        Me.colDescripcion.DataPropertyName = "Descripcion"
        Me.colDescripcion.FillWeight = 200.0!
        Me.colDescripcion.HeaderText = "Descripción"
        Me.colDescripcion.MinimumWidth = 6
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.ReadOnly = True
        '
        'colEstado
        '
        Me.colEstado.DataPropertyName = "Estado"
        Me.colEstado.FillWeight = 70.0!
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.MinimumWidth = 6
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        '
        'colOrganizacion
        '
        Me.colOrganizacion.DataPropertyName = "ConvocadaPor"
        Me.colOrganizacion.HeaderText = "Organización"
        Me.colOrganizacion.MinimumWidth = 6
        Me.colOrganizacion.Name = "colOrganizacion"
        Me.colOrganizacion.ReadOnly = True
        '
        'colInicio
        '
        Me.colInicio.DataPropertyName = "FechaHoraInicio"
        Me.colInicio.HeaderText = "Fin"
        Me.colInicio.MinimumWidth = 6
        Me.colInicio.Name = "colInicio"
        Me.colInicio.ReadOnly = True
        Me.colInicio.DefaultCellStyle.Format = "g"
        '
        'colFin
        '
        Me.colFin.DataPropertyName = "FechaHoraFin"
        Me.colFin.HeaderText = "Inicio"
        Me.colFin.MinimumWidth = 6
        Me.colFin.Name = "colFin"
        Me.colFin.ReadOnly = True
        Me.colFin.DefaultCellStyle.Format = "g"
        '
        'conTecnicoDe
        '
        Me.colTecnicoDe.DataPropertyName = "TecnicoDe"
        Me.colTecnicoDe.HeaderText = "Curso"
        Me.colTecnicoDe.MinimumWidth = 6
        Me.colTecnicoDe.Name = "colTecnicoDe"
        Me.colTecnicoDe.ReadOnly = True
        '
        'tabDetalles
        '
        Me.tabDetalles.Controls.Add(Me.tpDetallesActividad)
        Me.tabDetalles.Controls.Add(Me.tpODS)
        Me.tabDetalles.Controls.Add(Me.tpVoluntarios)
        Me.tabDetalles.Controls.Add(Me.tpTipos)
        Me.tabDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDetalles.Location = New System.Drawing.Point(0, 0)
        Me.tabDetalles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabDetalles.Name = "tabDetalles"
        Me.tabDetalles.SelectedIndex = 0
        Me.tabDetalles.Size = New System.Drawing.Size(1476, 746)
        Me.tabDetalles.TabIndex = 0
        '
        'tpDetallesActividad
        '
        Me.tpDetallesActividad.Controls.Add(Me.gbDetallesActividad)
        Me.tpDetallesActividad.Location = New System.Drawing.Point(8, 39)
        Me.tpDetallesActividad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpDetallesActividad.Name = "tpDetallesActividad"
        Me.tpDetallesActividad.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpDetallesActividad.Size = New System.Drawing.Size(1460, 699)
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
        Me.gbDetallesActividad.Location = New System.Drawing.Point(9, 10)
        Me.gbDetallesActividad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbDetallesActividad.Name = "gbDetallesActividad"
        Me.gbDetallesActividad.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbDetallesActividad.Size = New System.Drawing.Size(1445, 683)
        Me.gbDetallesActividad.TabIndex = 0
        Me.gbDetallesActividad.TabStop = False
        Me.gbDetallesActividad.Text = "Información de la Actividad"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(509, 389)
        Me.dtpFechaFin.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(177, 31)
        Me.dtpFechaFin.TabIndex = 7
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(395, 394)
        Me.lblFechaFin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(114, 25)
        Me.lblFechaFin.TabIndex = 23
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(165, 389)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(177, 31)
        Me.dtpFechaInicio.TabIndex = 6
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(24, 394)
        Me.lblFechaInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(134, 25)
        Me.lblFechaInicio.TabIndex = 21
        Me.lblFechaInicio.Text = "Fecha Inicio:"
        '
        'cmbTecnicidad
        '
        Me.cmbTecnicidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTecnicidad.FormattingEnabled = True
        Me.cmbTecnicidad.Location = New System.Drawing.Point(241, 482)
        Me.cmbTecnicidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbTecnicidad.Name = "cmbTecnicidad"
        Me.cmbTecnicidad.Size = New System.Drawing.Size(120, 33)
        Me.cmbTecnicidad.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 488)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(222, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Tecnicidad (si aplica):"
        '
        'dtpHoraFinActividad
        '
        Me.dtpHoraFinActividad.CustomFormat = "HH:mm"
        Me.dtpHoraFinActividad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFinActividad.Location = New System.Drawing.Point(1140, 389)
        Me.dtpHoraFinActividad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpHoraFinActividad.Name = "dtpHoraFinActividad"
        Me.dtpHoraFinActividad.ShowUpDown = True
        Me.dtpHoraFinActividad.Size = New System.Drawing.Size(132, 31)
        Me.dtpHoraFinActividad.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1035, 394)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Hora fin:"
        '
        'dtpHoraInicioActividad
        '
        Me.dtpHoraInicioActividad.CustomFormat = "HH:mm"
        Me.dtpHoraInicioActividad.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicioActividad.Location = New System.Drawing.Point(869, 389)
        Me.dtpHoraInicioActividad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtpHoraInicioActividad.Name = "dtpHoraInicioActividad"
        Me.dtpHoraInicioActividad.ShowUpDown = True
        Me.dtpHoraInicioActividad.Size = New System.Drawing.Size(132, 31)
        Me.dtpHoraInicioActividad.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(749, 394)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Hora inicio:"
        '
        'cmbOrganizacionActividad
        '
        Me.cmbOrganizacionActividad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOrganizacionActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrganizacionActividad.FormattingEnabled = True
        Me.cmbOrganizacionActividad.Location = New System.Drawing.Point(255, 292)
        Me.cmbOrganizacionActividad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbOrganizacionActividad.Name = "cmbOrganizacionActividad"
        Me.cmbOrganizacionActividad.Size = New System.Drawing.Size(719, 33)
        Me.cmbOrganizacionActividad.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 298)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Organización:"
        '
        'cmbEstadoActividad
        '
        Me.cmbEstadoActividad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbEstadoActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstadoActividad.FormattingEnabled = True
        Me.cmbEstadoActividad.Location = New System.Drawing.Point(1129, 292)
        Me.cmbEstadoActividad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbEstadoActividad.Name = "cmbEstadoActividad"
        Me.cmbEstadoActividad.Size = New System.Drawing.Size(289, 33)
        Me.cmbEstadoActividad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1033, 298)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = " Estado:"
        '
        'txtDescActividad
        '
        Me.txtDescActividad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescActividad.Location = New System.Drawing.Point(255, 148)
        Me.txtDescActividad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescActividad.Multiline = True
        Me.txtDescActividad.Name = "txtDescActividad"
        Me.txtDescActividad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescActividad.Size = New System.Drawing.Size(1164, 130)
        Me.txtDescActividad.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 151)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Descripción:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(24, 102)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(93, 25)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombreActividad
        '
        Me.txtNombreActividad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombreActividad.Location = New System.Drawing.Point(255, 99)
        Me.txtNombreActividad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombreActividad.Name = "txtNombreActividad"
        Me.txtNombreActividad.Size = New System.Drawing.Size(1164, 31)
        Me.txtNombreActividad.TabIndex = 1
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(24, 55)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(38, 25)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "ID:"
        '
        'txtIDActividad
        '
        Me.txtIDActividad.Location = New System.Drawing.Point(255, 50)
        Me.txtIDActividad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIDActividad.Name = "txtIDActividad"
        Me.txtIDActividad.ReadOnly = True
        Me.txtIDActividad.Size = New System.Drawing.Size(148, 31)
        Me.txtIDActividad.TabIndex = 0
        Me.txtIDActividad.TabStop = False
        '
        'tpODS
        '
        Me.tpODS.Controls.Add(Me.gbODS)
        Me.tpODS.Location = New System.Drawing.Point(8, 39)
        Me.tpODS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpODS.Name = "tpODS"
        Me.tpODS.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpODS.Size = New System.Drawing.Size(1460, 699)
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
        Me.gbODS.Location = New System.Drawing.Point(9, 10)
        Me.gbODS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbODS.Name = "gbODS"
        Me.gbODS.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbODS.Size = New System.Drawing.Size(1443, 680)
        Me.gbODS.TabIndex = 0
        Me.gbODS.TabStop = False
        Me.gbODS.Text = "ODS que Cumple la Actividad"
        '
        'btnQuitarOds
        '
        Me.btnQuitarOds.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnQuitarOds.Location = New System.Drawing.Point(675, 364)
        Me.btnQuitarOds.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuitarOds.Name = "btnQuitarOds"
        Me.btnQuitarOds.Size = New System.Drawing.Size(93, 48)
        Me.btnQuitarOds.TabIndex = 3
        Me.btnQuitarOds.Text = "<<"
        Me.btnQuitarOds.UseVisualStyleBackColor = True
        '
        'btnAnadirOds
        '
        Me.btnAnadirOds.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnadirOds.Location = New System.Drawing.Point(675, 286)
        Me.btnAnadirOds.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnadirOds.Name = "btnAnadirOds"
        Me.btnAnadirOds.Size = New System.Drawing.Size(93, 48)
        Me.btnAnadirOds.TabIndex = 1
        Me.btnAnadirOds.Text = ">>"
        Me.btnAnadirOds.UseVisualStyleBackColor = True
        '
        'lstOdsAsignados
        '
        Me.lstOdsAsignados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstOdsAsignados.FormattingEnabled = True
        Me.lstOdsAsignados.ItemHeight = 25
        Me.lstOdsAsignados.Location = New System.Drawing.Point(796, 80)
        Me.lstOdsAsignados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstOdsAsignados.Name = "lstOdsAsignados"
        Me.lstOdsAsignados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstOdsAsignados.Size = New System.Drawing.Size(619, 579)
        Me.lstOdsAsignados.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(792, 50)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(170, 25)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "ODS Asignados:"
        '
        'lstOdsDisponibles
        '
        Me.lstOdsDisponibles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstOdsDisponibles.FormattingEnabled = True
        Me.lstOdsDisponibles.ItemHeight = 25
        Me.lstOdsDisponibles.Location = New System.Drawing.Point(28, 80)
        Me.lstOdsDisponibles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstOdsDisponibles.Name = "lstOdsDisponibles"
        Me.lstOdsDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstOdsDisponibles.Size = New System.Drawing.Size(619, 579)
        Me.lstOdsDisponibles.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 50)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 25)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ODS Disponibles:"
        '
        'tpVoluntarios
        '
        Me.tpVoluntarios.Controls.Add(Me.gbVoluntarios)
        Me.tpVoluntarios.Location = New System.Drawing.Point(8, 39)
        Me.tpVoluntarios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpVoluntarios.Name = "tpVoluntarios"
        Me.tpVoluntarios.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpVoluntarios.Size = New System.Drawing.Size(1460, 699)
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
        Me.gbVoluntarios.Location = New System.Drawing.Point(9, 10)
        Me.gbVoluntarios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbVoluntarios.Name = "gbVoluntarios"
        Me.gbVoluntarios.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbVoluntarios.Size = New System.Drawing.Size(1443, 680)
        Me.gbVoluntarios.TabIndex = 1
        Me.gbVoluntarios.TabStop = False
        Me.gbVoluntarios.Text = "Voluntarios que Realizan la Actividad"
        '
        'btnQuitarVoluntario
        '
        Me.btnQuitarVoluntario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnQuitarVoluntario.Location = New System.Drawing.Point(675, 364)
        Me.btnQuitarVoluntario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuitarVoluntario.Name = "btnQuitarVoluntario"
        Me.btnQuitarVoluntario.Size = New System.Drawing.Size(93, 48)
        Me.btnQuitarVoluntario.TabIndex = 3
        Me.btnQuitarVoluntario.Text = "<<"
        Me.btnQuitarVoluntario.UseVisualStyleBackColor = True
        '
        'btnAnadirVoluntario
        '
        Me.btnAnadirVoluntario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnadirVoluntario.Location = New System.Drawing.Point(675, 286)
        Me.btnAnadirVoluntario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnadirVoluntario.Name = "btnAnadirVoluntario"
        Me.btnAnadirVoluntario.Size = New System.Drawing.Size(93, 48)
        Me.btnAnadirVoluntario.TabIndex = 1
        Me.btnAnadirVoluntario.Text = ">>"
        Me.btnAnadirVoluntario.UseVisualStyleBackColor = True
        '
        'lstVoluntariosAsignados
        '
        Me.lstVoluntariosAsignados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstVoluntariosAsignados.FormattingEnabled = True
        Me.lstVoluntariosAsignados.ItemHeight = 25
        Me.lstVoluntariosAsignados.Location = New System.Drawing.Point(796, 80)
        Me.lstVoluntariosAsignados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstVoluntariosAsignados.Name = "lstVoluntariosAsignados"
        Me.lstVoluntariosAsignados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstVoluntariosAsignados.Size = New System.Drawing.Size(619, 579)
        Me.lstVoluntariosAsignados.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(792, 50)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(233, 25)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Voluntarios Asignados:"
        '
        'lstVoluntariosDisponibles
        '
        Me.lstVoluntariosDisponibles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstVoluntariosDisponibles.FormattingEnabled = True
        Me.lstVoluntariosDisponibles.ItemHeight = 25
        Me.lstVoluntariosDisponibles.Location = New System.Drawing.Point(28, 80)
        Me.lstVoluntariosDisponibles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstVoluntariosDisponibles.Name = "lstVoluntariosDisponibles"
        Me.lstVoluntariosDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstVoluntariosDisponibles.Size = New System.Drawing.Size(619, 579)
        Me.lstVoluntariosDisponibles.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 50)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(244, 25)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Voluntarios Disponibles:"
        '
        'tpTipos
        '
        Me.tpTipos.Controls.Add(Me.gbTipos)
        Me.tpTipos.Location = New System.Drawing.Point(8, 39)
        Me.tpTipos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpTipos.Name = "tpTipos"
        Me.tpTipos.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tpTipos.Size = New System.Drawing.Size(1460, 699)
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
        Me.gbTipos.Location = New System.Drawing.Point(9, 10)
        Me.gbTipos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbTipos.Name = "gbTipos"
        Me.gbTipos.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gbTipos.Size = New System.Drawing.Size(1443, 680)
        Me.gbTipos.TabIndex = 2
        Me.gbTipos.TabStop = False
        Me.gbTipos.Text = "Tipos de la Actividad"
        '
        'btnQuitarTipo
        '
        Me.btnQuitarTipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnQuitarTipo.Location = New System.Drawing.Point(675, 364)
        Me.btnQuitarTipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnQuitarTipo.Name = "btnQuitarTipo"
        Me.btnQuitarTipo.Size = New System.Drawing.Size(93, 48)
        Me.btnQuitarTipo.TabIndex = 3
        Me.btnQuitarTipo.Text = "<<"
        Me.btnQuitarTipo.UseVisualStyleBackColor = True
        '
        'btnAnadirTipo
        '
        Me.btnAnadirTipo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAnadirTipo.Location = New System.Drawing.Point(675, 286)
        Me.btnAnadirTipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAnadirTipo.Name = "btnAnadirTipo"
        Me.btnAnadirTipo.Size = New System.Drawing.Size(93, 48)
        Me.btnAnadirTipo.TabIndex = 1
        Me.btnAnadirTipo.Text = ">>"
        Me.btnAnadirTipo.UseVisualStyleBackColor = True
        '
        'lstTiposAsignados
        '
        Me.lstTiposAsignados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstTiposAsignados.FormattingEnabled = True
        Me.lstTiposAsignados.ItemHeight = 25
        Me.lstTiposAsignados.Location = New System.Drawing.Point(796, 80)
        Me.lstTiposAsignados.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstTiposAsignados.Name = "lstTiposAsignados"
        Me.lstTiposAsignados.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTiposAsignados.Size = New System.Drawing.Size(619, 579)
        Me.lstTiposAsignados.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(792, 50)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 25)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Tipos Asignados:"
        '
        'lstTiposDisponibles
        '
        Me.lstTiposDisponibles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstTiposDisponibles.FormattingEnabled = True
        Me.lstTiposDisponibles.ItemHeight = 25
        Me.lstTiposDisponibles.Location = New System.Drawing.Point(28, 80)
        Me.lstTiposDisponibles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstTiposDisponibles.Name = "lstTiposDisponibles"
        Me.lstTiposDisponibles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstTiposDisponibles.Size = New System.Drawing.Size(619, 579)
        Me.lstTiposDisponibles.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 50)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(189, 25)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Tipos Disponibles:"
        '
        'FormActividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1476, 1180)
        Me.Controls.Add(Me.SplitContainerPrincipal)
        Me.Controls.Add(Me.tsActividades)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1187, 902)
        Me.Name = "FormActividades"
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
    Friend WithEvents colDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents colEstado As DataGridViewTextBoxColumn
    Friend WithEvents colOrganizacion As DataGridViewTextBoxColumn
    Friend WithEvents colInicio As DataGridViewTextBoxColumn
    Friend WithEvents colFin As DataGridViewTextBoxColumn
    Friend WithEvents colTecnicoDe As DataGridViewTextBoxColumn
    Friend WithEvents cmbTecnicidad As ComboBox
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblFechaFin As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmbCursoTecnico As ComboBox
    Friend WithEvents lblCursoTecnico As Label
    Friend _ControlesObligatorios As Control()
End Class