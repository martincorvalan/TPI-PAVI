namespace ProjectoPAV.GUILayer.ABMC_Curso
{
    partial class ABMObjetivosCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMObjetivosCurso));
            this.background = new System.Windows.Forms.PictureBox();
            this.dgvObjetivos = new System.Windows.Forms.DataGridView();
            this.nombre_corto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_largo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.id_objetivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idobjetivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrecortoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrelargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugTrackerGrupo9DataSet2 = new ProjectoPAV.BugTrackerGrupo9DataSet2();
            this.bugTrackerGrupo9DataSet = new ProjectoPAV.BugTrackerGrupo9DataSet();
            this.objetivosTableAdapter = new ProjectoPAV.BugTrackerGrupo9DataSetTableAdapters.ObjetivosTableAdapter();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.nombreCabecera = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.btnAddAll = new System.Windows.Forms.PictureBox();
            this.usuarios = new ProjectoPAV.Usuarios();
            this.objetivosTableAdapter1 = new ProjectoPAV.BugTrackerGrupo9DataSet2TableAdapters.ObjetivosTableAdapter();
            this.bugTrackerGrupo9DataSet1 = new ProjectoPAV.BugTrackerGrupo9DataSet1();
            this.usuariosTableAdapter1 = new ProjectoPAV.BugTrackerGrupo9DataSet1TableAdapters.UsuariosTableAdapter();
            this.lblNombreCorto = new System.Windows.Forms.Label();
            this.lblNombreLargo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNombreCorto = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNombreLargo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.lblFaltaNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.background.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.background.Location = new System.Drawing.Point(0, 30);
            this.background.MaximumSize = new System.Drawing.Size(430, 470);
            this.background.MinimumSize = new System.Drawing.Size(430, 470);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(430, 470);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // dgvObjetivos
            // 
            this.dgvObjetivos.AllowUserToAddRows = false;
            this.dgvObjetivos.AllowUserToDeleteRows = false;
            this.dgvObjetivos.AllowUserToResizeColumns = false;
            this.dgvObjetivos.AllowUserToResizeRows = false;
            this.dgvObjetivos.AutoGenerateColumns = false;
            this.dgvObjetivos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.dgvObjetivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvObjetivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvObjetivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvObjetivos.ColumnHeadersHeight = 25;
            this.dgvObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvObjetivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_corto,
            this.nombre_largo,
            this.agregar,
            this.id_objetivo,
            this.idobjetivoDataGridViewTextBoxColumn,
            this.nombrecortoDataGridViewTextBoxColumn,
            this.nombrelargoDataGridViewTextBoxColumn});
            this.dgvObjetivos.DataSource = this.objetivosBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvObjetivos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvObjetivos.GridColor = System.Drawing.Color.White;
            this.dgvObjetivos.Location = new System.Drawing.Point(50, 137);
            this.dgvObjetivos.MaximumSize = new System.Drawing.Size(343, 300);
            this.dgvObjetivos.Name = "dgvObjetivos";
            this.dgvObjetivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvObjetivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvObjetivos.RowHeadersWidth = 30;
            this.dgvObjetivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvObjetivos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvObjetivos.Size = new System.Drawing.Size(331, 289);
            this.dgvObjetivos.TabIndex = 2;
            this.dgvObjetivos.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvUsuarios_CurrentCellDirtyStateChanged);
            // 
            // nombre_corto
            // 
            this.nombre_corto.DataPropertyName = "nombre_corto";
            this.nombre_corto.HeaderText = "nombre_corto";
            this.nombre_corto.Name = "nombre_corto";
            // 
            // nombre_largo
            // 
            this.nombre_largo.DataPropertyName = "nombre_largo";
            this.nombre_largo.HeaderText = "nombre_largo";
            this.nombre_largo.Name = "nombre_largo";
            // 
            // agregar
            // 
            this.agregar.HeaderText = "Agregar";
            this.agregar.Name = "agregar";
            // 
            // id_objetivo
            // 
            this.id_objetivo.DataPropertyName = "id_objetivo";
            this.id_objetivo.HeaderText = "id_objetivo";
            this.id_objetivo.Name = "id_objetivo";
            this.id_objetivo.ReadOnly = true;
            this.id_objetivo.Visible = false;
            // 
            // idobjetivoDataGridViewTextBoxColumn
            // 
            this.idobjetivoDataGridViewTextBoxColumn.DataPropertyName = "id_objetivo";
            this.idobjetivoDataGridViewTextBoxColumn.HeaderText = "id_objetivo";
            this.idobjetivoDataGridViewTextBoxColumn.Name = "idobjetivoDataGridViewTextBoxColumn";
            this.idobjetivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombrecortoDataGridViewTextBoxColumn
            // 
            this.nombrecortoDataGridViewTextBoxColumn.DataPropertyName = "nombre_corto";
            this.nombrecortoDataGridViewTextBoxColumn.HeaderText = "nombre_corto";
            this.nombrecortoDataGridViewTextBoxColumn.Name = "nombrecortoDataGridViewTextBoxColumn";
            // 
            // nombrelargoDataGridViewTextBoxColumn
            // 
            this.nombrelargoDataGridViewTextBoxColumn.DataPropertyName = "nombre_largo";
            this.nombrelargoDataGridViewTextBoxColumn.HeaderText = "nombre_largo";
            this.nombrelargoDataGridViewTextBoxColumn.Name = "nombrelargoDataGridViewTextBoxColumn";
            // 
            // objetivosBindingSource
            // 
            this.objetivosBindingSource.DataMember = "Objetivos";
            this.objetivosBindingSource.DataSource = this.bugTrackerGrupo9DataSet2;
            // 
            // bugTrackerGrupo9DataSet2
            // 
            this.bugTrackerGrupo9DataSet2.DataSetName = "BugTrackerGrupo9DataSet2";
            this.bugTrackerGrupo9DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugTrackerGrupo9DataSet
            // 
            this.bugTrackerGrupo9DataSet.DataSetName = "BugTrackerGrupo9DataSet";
            this.bugTrackerGrupo9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objetivosTableAdapter
            // 
            this.objetivosTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 22;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 22;
            this.guna2Elipse2.TargetControl = this.dgvObjetivos;
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
            this.nombreCabecera.Size = new System.Drawing.Size(182, 19);
            this.nombreCabecera.TabIndex = 15;
            this.nombreCabecera.Text = "Agregar objetivos a curso";
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
            this.lblCurso.Location = new System.Drawing.Point(47, 44);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(50, 18);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Curso: ";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblNombreCurso.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.lblNombreCurso.Location = new System.Drawing.Point(103, 46);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(82, 15);
            this.lblNombreCurso.TabIndex = 7;
            this.lblNombreCurso.Text = "NombreCurso";
            // 
            // btnAddAll
            // 
            this.btnAddAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.btnAddAll.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAll.Image")));
            this.btnAddAll.Location = new System.Drawing.Point(339, 438);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(42, 40);
            this.btnAddAll.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddAll.TabIndex = 16;
            this.btnAddAll.TabStop = false;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // usuarios
            // 
            this.usuarios.DataSetName = "Usuarios";
            this.usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objetivosTableAdapter1
            // 
            this.objetivosTableAdapter1.ClearBeforeFill = true;
            // 
            // bugTrackerGrupo9DataSet1
            // 
            this.bugTrackerGrupo9DataSet1.DataSetName = "BugTrackerGrupo9DataSet1";
            this.bugTrackerGrupo9DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // lblNombreCorto
            // 
            this.lblNombreCorto.AutoSize = true;
            this.lblNombreCorto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblNombreCorto.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCorto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.lblNombreCorto.Location = new System.Drawing.Point(47, 73);
            this.lblNombreCorto.Name = "lblNombreCorto";
            this.lblNombreCorto.Size = new System.Drawing.Size(94, 18);
            this.lblNombreCorto.TabIndex = 17;
            this.lblNombreCorto.Text = "Nombre corto";
            // 
            // lblNombreLargo
            // 
            this.lblNombreLargo.AutoSize = true;
            this.lblNombreLargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblNombreLargo.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.lblNombreLargo.Location = new System.Drawing.Point(47, 103);
            this.lblNombreLargo.Name = "lblNombreLargo";
            this.lblNombreLargo.Size = new System.Drawing.Size(95, 18);
            this.lblNombreLargo.TabIndex = 18;
            this.lblNombreLargo.Text = "Nombre Largo";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(146, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 1);
            this.panel2.TabIndex = 20;
            // 
            // txtNombreCorto
            // 
            this.txtNombreCorto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.txtNombreCorto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreCorto.ForeColor = System.Drawing.Color.White;
            this.txtNombreCorto.Location = new System.Drawing.Point(146, 73);
            this.txtNombreCorto.MaxLength = 50;
            this.txtNombreCorto.Name = "txtNombreCorto";
            this.txtNombreCorto.Size = new System.Drawing.Size(170, 13);
            this.txtNombreCorto.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(146, 118);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 1);
            this.panel3.TabIndex = 22;
            // 
            // txtNombreLargo
            // 
            this.txtNombreLargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.txtNombreLargo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreLargo.ForeColor = System.Drawing.Color.White;
            this.txtNombreLargo.Location = new System.Drawing.Point(146, 103);
            this.txtNombreLargo.MaxLength = 50;
            this.txtNombreLargo.Name = "txtNombreLargo";
            this.txtNombreLargo.Size = new System.Drawing.Size(170, 13);
            this.txtNombreLargo.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(322, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 31);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAdd.TabIndex = 23;
            this.btnAdd.TabStop = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFaltaNombre
            // 
            this.lblFaltaNombre.AutoSize = true;
            this.lblFaltaNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblFaltaNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFaltaNombre.ForeColor = System.Drawing.Color.Red;
            this.lblFaltaNombre.Location = new System.Drawing.Point(168, 61);
            this.lblFaltaNombre.Name = "lblFaltaNombre";
            this.lblFaltaNombre.Size = new System.Drawing.Size(123, 13);
            this.lblFaltaNombre.TabIndex = 24;
            this.lblFaltaNombre.Text = "Falta ingresar un nomnre";
            this.lblFaltaNombre.Visible = false;
            // 
            // ABMObjetivosCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(430, 500);
            this.Controls.Add(this.lblFaltaNombre);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtNombreLargo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNombreCorto);
            this.Controls.Add(this.lblNombreLargo);
            this.Controls.Add(this.lblNombreCorto);
            this.Controls.Add(this.dgvObjetivos);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABMObjetivosCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABMObjetivosCurso";
            this.Load += new System.EventHandler(this.ABMObjetivosCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjetivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.DataGridView dgvObjetivos;
        private BugTrackerGrupo9DataSet bugTrackerGrupo9DataSet;
        private BugTrackerGrupo9DataSetTableAdapters.ObjetivosTableAdapter objetivosTableAdapter;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nombreCabecera;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.PictureBox btnAddAll;
        private Usuarios usuarios;
        private BugTrackerGrupo9DataSet1 bugTrackerGrupo9DataSet1;
        private BugTrackerGrupo9DataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private BugTrackerGrupo9DataSet2 bugTrackerGrupo9DataSet2;
        private System.Windows.Forms.BindingSource objetivosBindingSource;
        private BugTrackerGrupo9DataSet2TableAdapters.ObjetivosTableAdapter objetivosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_corto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_largo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_objetivo;
        private System.Windows.Forms.Label lblNombreLargo;
        private System.Windows.Forms.Label lblNombreCorto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idobjetivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecortoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrelargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNombreLargo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNombreCorto;
        private System.Windows.Forms.Label lblFaltaNombre;
    }
}