namespace ProjectoPAV.GUILayer.ABMC_Curso
{
    partial class ObjetivosCurso
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
            this.background = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombrecortoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrelargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objetivosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugTrackerGrupo9DataSet = new ProjectoPAV.BugTrackerGrupo9DataSet();
            this.objetivosTableAdapter = new ProjectoPAV.BugTrackerGrupo9DataSetTableAdapters.ObjetivosTableAdapter();
            this.objetivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(800, 450);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 1;
            this.background.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombrecortoDataGridViewTextBoxColumn,
            this.nombrelargoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.objetivosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(86, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 215);
            this.dataGridView1.TabIndex = 2;
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
            // objetivoBindingSource
            // 
            this.objetivoBindingSource.DataSource = typeof(ProjectoPAV.Entities.Objetivo);
            // 
            // ObjetivosCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.background);
            this.Name = "ObjetivosCurso";
            this.Text = "ObjetivosCurso";
            this.Load += new System.EventHandler(this.ObjetivosCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugTrackerGrupo9DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objetivoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource objetivoBindingSource;
        private BugTrackerGrupo9DataSet bugTrackerGrupo9DataSet;
        private System.Windows.Forms.BindingSource objetivosBindingSource;
        private BugTrackerGrupo9DataSetTableAdapters.ObjetivosTableAdapter objetivosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrecortoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrelargoDataGridViewTextBoxColumn;
    }
}