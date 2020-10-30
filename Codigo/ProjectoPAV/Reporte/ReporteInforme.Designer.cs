namespace ProjectoPAV.Reporte
{
    partial class ReporteInforme
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
            this.cantidadUsuariosCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceReporteInforme = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReporteInforme = new ProjectoPAV.Reporte.DataSetReporteInforme();
            this.cantidadObjetivosCursoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.porcentajeAvanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadUsuariosCursoTableAdapter = new ProjectoPAV.Reporte.DataSetReporteInformeTableAdapters.CantidadUsuariosCursoTableAdapter();
            this.cantidadObjetivosCursoTableAdapter = new ProjectoPAV.Reporte.DataSetReporteInformeTableAdapters.CantidadObjetivosCursoTableAdapter();
            this.porcentajeAvanceTableAdapter = new ProjectoPAV.Reporte.DataSetReporteInformeTableAdapters.PorcentajeAvanceTableAdapter();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dateTimeVigente = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadUsuariosCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReporteInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadObjetivosCursoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeAvanceBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cantidadUsuariosCursoBindingSource
            // 
            this.cantidadUsuariosCursoBindingSource.DataMember = "CantidadUsuariosCurso";
            this.cantidadUsuariosCursoBindingSource.DataSource = this.bindingSourceReporteInforme;
            // 
            // bindingSourceReporteInforme
            // 
            this.bindingSourceReporteInforme.DataSource = this.dataSetReporteInforme;
            this.bindingSourceReporteInforme.Position = 0;
            // 
            // dataSetReporteInforme
            // 
            this.dataSetReporteInforme.DataSetName = "DataSetReporteInforme";
            this.dataSetReporteInforme.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cantidadObjetivosCursoBindingSource
            // 
            this.cantidadObjetivosCursoBindingSource.DataMember = "CantidadObjetivosCurso";
            this.cantidadObjetivosCursoBindingSource.DataSource = this.bindingSourceReporteInforme;
            // 
            // porcentajeAvanceBindingSource
            // 
            this.porcentajeAvanceBindingSource.DataMember = "PorcentajeAvance";
            this.porcentajeAvanceBindingSource.DataSource = this.bindingSourceReporteInforme;
            // 
            // cantidadUsuariosCursoTableAdapter
            // 
            this.cantidadUsuariosCursoTableAdapter.ClearBeforeFill = true;
            // 
            // cantidadObjetivosCursoTableAdapter
            // 
            this.cantidadObjetivosCursoTableAdapter.ClearBeforeFill = true;
            // 
            // porcentajeAvanceTableAdapter
            // 
            this.porcentajeAvanceTableAdapter.ClearBeforeFill = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 22;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 22;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 22;
            this.guna2Elipse3.TargetControl = this.reportViewer1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(737, 25);
            this.btnGenerar.MaximumSize = new System.Drawing.Size(86, 30);
            this.btnGenerar.MinimumSize = new System.Drawing.Size(86, 30);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(86, 30);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // dateTimeVigente
            // 
            this.dateTimeVigente.AutoRoundedCorners = true;
            this.dateTimeVigente.BackColor = System.Drawing.Color.Transparent;
            this.dateTimeVigente.BorderRadius = 12;
            this.dateTimeVigente.CheckedState.Parent = this.dateTimeVigente;
            this.dateTimeVigente.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.dateTimeVigente.Font = new System.Drawing.Font("Calibri", 9F);
            this.dateTimeVigente.ForeColor = System.Drawing.Color.White;
            this.dateTimeVigente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeVigente.HoverState.Parent = this.dateTimeVigente;
            this.dateTimeVigente.Location = new System.Drawing.Point(176, 25);
            this.dateTimeVigente.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimeVigente.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimeVigente.Name = "dateTimeVigente";
            this.dateTimeVigente.ShadowDecoration.Parent = this.dateTimeVigente;
            this.dateTimeVigente.ShowCheckBox = true;
            this.dateTimeVigente.Size = new System.Drawing.Size(121, 27);
            this.dateTimeVigente.TabIndex = 3;
            this.dateTimeVigente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTimeVigente.UseTransparentBackground = true;
            this.dateTimeVigente.Value = new System.DateTime(2020, 10, 23, 0, 0, 0, 0);
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProjectoPAV.Reporte.ReporteDiseño.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(55, 70);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(784, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.lblDescripcion.Location = new System.Drawing.Point(70, 31);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 18);
            this.lblDescripcion.TabIndex = 7;
            this.lblDescripcion.Text = "Fecha Vigencia";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.dateTimeVigente);
            this.panel1.Controls.Add(this.btnGenerar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 646);
            this.panel1.TabIndex = 7;
            // 
            // ReporteInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.ClientSize = new System.Drawing.Size(892, 644);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteInforme";
            this.Text = "ReporteInforme";
            this.Load += new System.EventHandler(this.ReporteInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cantidadUsuariosCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceReporteInforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteInforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadObjetivosCursoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentajeAvanceBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataSetReporteInforme dataSetReporteInforme;
        private DataSetReporteInformeTableAdapters.CantidadUsuariosCursoTableAdapter cantidadUsuariosCursoTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceReporteInforme;
        private System.Windows.Forms.BindingSource cantidadUsuariosCursoBindingSource;
        private DataSetReporteInformeTableAdapters.CantidadObjetivosCursoTableAdapter cantidadObjetivosCursoTableAdapter;
        private System.Windows.Forms.BindingSource cantidadObjetivosCursoBindingSource;
        private DataSetReporteInformeTableAdapters.PorcentajeAvanceTableAdapter porcentajeAvanceTableAdapter;
        private System.Windows.Forms.BindingSource porcentajeAvanceBindingSource;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescripcion;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimeVigente;
        private System.Windows.Forms.Button btnGenerar;
    }
}