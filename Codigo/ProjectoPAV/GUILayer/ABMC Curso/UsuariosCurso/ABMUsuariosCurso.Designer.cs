﻿namespace ProjectoPAV.GUILayer.ABMC_Curso
{
    partial class ABMUsuariosCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMUsuariosCurso));
            this.background = new System.Windows.Forms.PictureBox();
            this.dgvUsuariosDelCurso = new System.Windows.Forms.DataGridView();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bugTrackerGrupo9DataSet1 = new ProjectoPAV.BugTrackerGrupo9DataSet1();
            this.objetivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.usuarios = new ProjectoPAV.Usuarios();
            this.usuariosTableAdapter1 = new ProjectoPAV.BugTrackerGrupo9DataSet1TableAdapters.UsuariosTableAdapter();
            this.objetivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agregar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borradoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosDelCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).BeginInit();
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
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // dgvUsuariosDelCurso
            // 
            this.dgvUsuariosDelCurso.AllowUserToAddRows = false;
            this.dgvUsuariosDelCurso.AllowUserToDeleteRows = false;
            this.dgvUsuariosDelCurso.AllowUserToResizeColumns = false;
            this.dgvUsuariosDelCurso.AllowUserToResizeRows = false;
            this.dgvUsuariosDelCurso.AutoGenerateColumns = false;
            this.dgvUsuariosDelCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.dgvUsuariosDelCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuariosDelCurso.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuariosDelCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvUsuariosDelCurso.ColumnHeadersHeight = 25;
            this.dgvUsuariosDelCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuariosDelCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.usuario,
            this.email,
            this.agregar,
            this.idusuarioDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.borradoDataGridViewCheckBoxColumn});
            this.dgvUsuariosDelCurso.DataSource = this.usuariosBindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuariosDelCurso.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuariosDelCurso.GridColor = System.Drawing.Color.White;
            this.dgvUsuariosDelCurso.Location = new System.Drawing.Point(50, 84);
            this.dgvUsuariosDelCurso.MaximumSize = new System.Drawing.Size(343, 300);
            this.dgvUsuariosDelCurso.Name = "dgvUsuariosDelCurso";
            this.dgvUsuariosDelCurso.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosDelCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuariosDelCurso.RowHeadersWidth = 30;
            this.dgvUsuariosDelCurso.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuariosDelCurso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvUsuariosDelCurso.Size = new System.Drawing.Size(331, 289);
            this.dgvUsuariosDelCurso.TabIndex = 2;
            this.dgvUsuariosDelCurso.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvUsuarios_CurrentCellDirtyStateChanged);
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.bugTrackerGrupo9DataSet1;
            // 
            // bugTrackerGrupo9DataSet1
            // 
            this.bugTrackerGrupo9DataSet1.DataSetName = "BugTrackerGrupo9DataSet1";
            this.bugTrackerGrupo9DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objetivosBindingSource
            // 
            this.objetivosBindingSource.DataMember = "Objetivos";
            this.objetivosBindingSource.DataSource = this.bugTrackerGrupo9DataSet;
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
            this.guna2Elipse2.TargetControl = this.dgvUsuariosDelCurso;
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
            this.nombreCabecera.Size = new System.Drawing.Size(181, 19);
            this.nombreCabecera.TabIndex = 15;
            this.nombreCabecera.Text = "Agregar usuarios al curso";
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
            // usuarios
            // 
            this.usuarios.DataSetName = "Usuarios";
            this.usuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter1
            // 
            this.usuariosTableAdapter1.ClearBeforeFill = true;
            // 
            // objetivoBindingSource
            // 
            this.objetivoBindingSource.DataSource = typeof(ProjectoPAV.Entities.Objetivo);
            // 
            // id_usuario
            // 
            this.id_usuario.DataPropertyName = "id_usuario";
            this.id_usuario.HeaderText = "id_usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            this.id_usuario.Visible = false;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // agregar
            // 
            this.agregar.DataPropertyName = "borrado";
            this.agregar.HeaderText = "Agregar";
            this.agregar.Name = "agregar";
            this.agregar.Width = 50;
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
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // borradoDataGridViewCheckBoxColumn
            // 
            this.borradoDataGridViewCheckBoxColumn.DataPropertyName = "borrado";
            this.borradoDataGridViewCheckBoxColumn.HeaderText = "borrado";
            this.borradoDataGridViewCheckBoxColumn.Name = "borradoDataGridViewCheckBoxColumn";
            // 
            // ABMUsuariosCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.dgvUsuariosDelCurso);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ABMUsuariosCurso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ABMUsuariosCurso";
            this.Load += new System.EventHandler(this.ABMUsuariosCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosDelCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.DataGridView dgvUsuariosDelCurso;
        private System.Windows.Forms.BindingSource objetivoBindingSource;
        private BugTrackerGrupo9DataSet bugTrackerGrupo9DataSet;
        private System.Windows.Forms.BindingSource objetivosBindingSource;
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
        private System.Windows.Forms.PictureBox btnAdd;
        private Usuarios usuarios;
        private BugTrackerGrupo9DataSet1 bugTrackerGrupo9DataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private BugTrackerGrupo9DataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewCheckBoxColumn agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn borradoDataGridViewCheckBoxColumn;
    }
}