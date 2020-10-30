namespace ProjectoPAV.GUILayer.ABMC_Curso
{
    partial class UsuariosCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosCurso));
            this.background = new System.Windows.Forms.PictureBox();
            this.dgvUsuariosCurso = new System.Windows.Forms.DataGridView();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porc_avance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosDelCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProjectoPAV.DataSet1();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugTrackerGrupo9DataSetUsuariosPorCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugTrackerGrupo9DataSetUsuariosPorCurso = new ProjectoPAV.BugTrackerGrupo9DataSetUsuariosPorCurso();
            this.usuarios = new ProjectoPAV.Usuarios();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.nombreCabecera = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.lblDescripcionContenido = new System.Windows.Forms.Label();
            this.lblFechaContenido = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.usuariosTableAdapter = new ProjectoPAV.UsuariosTableAdapters.UsuariosTableAdapter();
            this.usuariosTableAdapter1 = new ProjectoPAV.BugTrackerGrupo9DataSetUsuariosPorCursoTableAdapters.UsuariosTableAdapter();
            this.usuariosCursoTableAdapter = new ProjectoPAV.BugTrackerGrupo9DataSetUsuariosPorCursoTableAdapters.UsuariosCursoTableAdapter();
            this.usuariosCursoAvanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugTrackerGrupo9DataSet1 = new ProjectoPAV.BugTrackerGrupo9DataSet1();
            this.usuariosDelCursoTableAdapter = new ProjectoPAV.DataSet1TableAdapters.UsuariosDelCursoTableAdapter();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borradoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idcursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcavanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDelCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSetUsuariosPorCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSetUsuariosPorCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosCursoAvanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.background.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.background.Location = new System.Drawing.Point(0, 30);
            this.background.MaximumSize = new System.Drawing.Size(430, 420);
            this.background.MinimumSize = new System.Drawing.Size(430, 420);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(430, 420);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // dgvUsuariosCurso
            // 
            this.dgvUsuariosCurso.AllowUserToAddRows = false;
            this.dgvUsuariosCurso.AllowUserToDeleteRows = false;
            this.dgvUsuariosCurso.AllowUserToResizeColumns = false;
            this.dgvUsuariosCurso.AllowUserToResizeRows = false;
            this.dgvUsuariosCurso.AutoGenerateColumns = false;
            this.dgvUsuariosCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.dgvUsuariosCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuariosCurso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuariosCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuariosCurso.ColumnHeadersHeight = 25;
            this.dgvUsuariosCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuariosCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuario,
            this.email,
            this.porc_avance,
            this.idusuarioDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.borradoDataGridViewCheckBoxColumn,
            this.idcursoDataGridViewTextBoxColumn,
            this.porcavanceDataGridViewTextBoxColumn});
            this.dgvUsuariosCurso.DataSource = this.usuariosDelCursoBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuariosCurso.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuariosCurso.GridColor = System.Drawing.Color.White;
            this.dgvUsuariosCurso.Location = new System.Drawing.Point(50, 126);
            this.dgvUsuariosCurso.MaximumSize = new System.Drawing.Size(343, 300);
            this.dgvUsuariosCurso.Name = "dgvUsuariosCurso";
            this.dgvUsuariosCurso.ReadOnly = true;
            this.dgvUsuariosCurso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuariosCurso.RowHeadersWidth = 30;
            this.dgvUsuariosCurso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuariosCurso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvUsuariosCurso.Size = new System.Drawing.Size(331, 251);
            this.dgvUsuariosCurso.TabIndex = 2;
            this.dgvUsuariosCurso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuariosCurso_CellClick);
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.MinimumWidth = 10;
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // porc_avance
            // 
            this.porc_avance.DataPropertyName = "porc_avance";
            this.porc_avance.HeaderText = "avance";
            this.porc_avance.Name = "porc_avance";
            this.porc_avance.ReadOnly = true;
            // 
            // usuariosDelCursoBindingSource
            // 
            this.usuariosDelCursoBindingSource.DataMember = "UsuariosDelCurso";
            this.usuariosDelCursoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.bugTrackerGrupo9DataSetUsuariosPorCursoBindingSource;
            // 
            // bugTrackerGrupo9DataSetUsuariosPorCursoBindingSource
            // 
            this.bugTrackerGrupo9DataSetUsuariosPorCursoBindingSource.DataSource = this.bugTrackerGrupo9DataSetUsuariosPorCurso;
            this.bugTrackerGrupo9DataSetUsuariosPorCursoBindingSource.Position = 0;
            // 
            // bugTrackerGrupo9DataSetUsuariosPorCurso
            // 
            this.bugTrackerGrupo9DataSetUsuariosPorCurso.DataSetName = "BugTrackerGrupo9DataSetUsuariosPorCurso";
            this.bugTrackerGrupo9DataSetUsuariosPorCurso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarios
            // 
            this.usuarios.DataSetName = "Usuarios";
            this.usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 22;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 22;
            this.guna2Elipse2.TargetControl = this.dgvUsuariosCurso;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 22;
            this.guna2Elipse3.TargetControl = this.background;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.nombreCabecera);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 27);
            this.panel1.TabIndex = 3;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // nombreCabecera
            // 
            this.nombreCabecera.AutoSize = true;
            this.nombreCabecera.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCabecera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.nombreCabecera.Location = new System.Drawing.Point(12, 5);
            this.nombreCabecera.Name = "nombreCabecera";
            this.nombreCabecera.Size = new System.Drawing.Size(133, 19);
            this.nombreCabecera.TabIndex = 15;
            this.nombreCabecera.Text = "Usuarios del curso";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(378, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(404, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblCurso.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.lblCurso.Location = new System.Drawing.Point(47, 53);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(50, 18);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Curso: ";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.lblDescripcion.Location = new System.Drawing.Point(47, 75);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(87, 18);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripcion: ";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblFecha.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.lblFecha.Location = new System.Drawing.Point(47, 99);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(107, 18);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha Vigencia: ";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblNombreCurso.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.lblNombreCurso.Location = new System.Drawing.Point(103, 55);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(82, 15);
            this.lblNombreCurso.TabIndex = 7;
            this.lblNombreCurso.Text = "NombreCurso";
            // 
            // lblDescripcionContenido
            // 
            this.lblDescripcionContenido.AutoSize = true;
            this.lblDescripcionContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblDescripcionContenido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionContenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.lblDescripcionContenido.Location = new System.Drawing.Point(140, 77);
            this.lblDescripcionContenido.Name = "lblDescripcionContenido";
            this.lblDescripcionContenido.Size = new System.Drawing.Size(82, 15);
            this.lblDescripcionContenido.TabIndex = 8;
            this.lblDescripcionContenido.Text = "NombreCurso";
            // 
            // lblFechaContenido
            // 
            this.lblFechaContenido.AutoSize = true;
            this.lblFechaContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblFechaContenido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaContenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.lblFechaContenido.Location = new System.Drawing.Point(161, 101);
            this.lblFechaContenido.Name = "lblFechaContenido";
            this.lblFechaContenido.Size = new System.Drawing.Size(82, 15);
            this.lblFechaContenido.TabIndex = 9;
            this.lblFechaContenido.Text = "NombreCurso";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(339, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 40);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // usuariosCursoTableAdapter
            // 
            this.usuariosCursoTableAdapter.ClearBeforeFill = true;
            // 
            // usuariosCursoAvanceBindingSource
            // 
            this.usuariosCursoAvanceBindingSource.DataMember = "UsuariosCursoAvance";
            this.usuariosCursoAvanceBindingSource.DataSource = this.bugTrackerGrupo9DataSetUsuariosPorCursoBindingSource;
            // 
            // bugTrackerGrupo9DataSet1
            // 
            this.bugTrackerGrupo9DataSet1.DataSetName = "BugTrackerGrupo9DataSet1";
            this.bugTrackerGrupo9DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosDelCursoTableAdapter
            // 
            this.usuariosDelCursoTableAdapter.ClearBeforeFill = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(241, 394);
            this.btnActualizar.MaximumSize = new System.Drawing.Size(86, 30);
            this.btnActualizar.MinimumSize = new System.Drawing.Size(86, 30);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(86, 30);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // borradoDataGridViewCheckBoxColumn
            // 
            this.borradoDataGridViewCheckBoxColumn.DataPropertyName = "borrado";
            this.borradoDataGridViewCheckBoxColumn.HeaderText = "borrado";
            this.borradoDataGridViewCheckBoxColumn.Name = "borradoDataGridViewCheckBoxColumn";
            this.borradoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // idcursoDataGridViewTextBoxColumn
            // 
            this.idcursoDataGridViewTextBoxColumn.DataPropertyName = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.HeaderText = "id_curso";
            this.idcursoDataGridViewTextBoxColumn.Name = "idcursoDataGridViewTextBoxColumn";
            this.idcursoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcavanceDataGridViewTextBoxColumn
            // 
            this.porcavanceDataGridViewTextBoxColumn.DataPropertyName = "porc_avance";
            this.porcavanceDataGridViewTextBoxColumn.HeaderText = "porc_avance";
            this.porcavanceDataGridViewTextBoxColumn.Name = "porcavanceDataGridViewTextBoxColumn";
            this.porcavanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UsuariosCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblFechaContenido);
            this.Controls.Add(this.lblDescripcionContenido);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvUsuariosCurso);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuariosCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UsuariosCurso";
            this.Load += new System.EventHandler(this.UsuariosCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosDelCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSetUsuariosPorCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSetUsuariosPorCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosCursoAvanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.DataGridView dgvUsuariosCurso;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nombreCabecera;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblFechaContenido;
        private System.Windows.Forms.Label lblDescripcionContenido;
        private System.Windows.Forms.PictureBox btnAdd;
        private Usuarios usuarios;
        private UsuariosTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource bugTrackerGrupo9DataSetUsuariosPorCursoBindingSource;
        private BugTrackerGrupo9DataSetUsuariosPorCurso bugTrackerGrupo9DataSetUsuariosPorCurso;
        private BugTrackerGrupo9DataSetUsuariosPorCursoTableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private BugTrackerGrupo9DataSetUsuariosPorCursoTableAdapters.UsuariosCursoTableAdapter usuariosCursoTableAdapter;
        private System.Windows.Forms.BindingSource usuariosCursoAvanceBindingSource;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private BugTrackerGrupo9DataSet1 bugTrackerGrupo9DataSet1;
        private System.Windows.Forms.BindingSource usuariosDelCursoBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.UsuariosDelCursoTableAdapter usuariosDelCursoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn porc_avance;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn borradoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcavanceDataGridViewTextBoxColumn;
    }
}