namespace ProjectoPAV.GUILayer
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelBar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.logoMenu = new System.Windows.Forms.PictureBox();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.lblLogueado = new System.Windows.Forms.Label();
            this.userLogo = new System.Windows.Forms.PictureBox();
            this.btnOpcion = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategorias = new Guna.UI2.WinForms.Guna2Button();
            this.btnCursos = new Guna.UI2.WinForms.Guna2Button();
            this.lblManager = new System.Windows.Forms.Label();
            this.LblCourses = new System.Windows.Forms.Label();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.imageCurve = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelContainer.SuspendLayout();
            this.panelBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoMenu)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCurve)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.panelContainer.Controls.Add(this.panelBar);
            this.panelContainer.Controls.Add(this.panelCentral);
            this.panelContainer.Controls.Add(this.leftPanel);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1148, 678);
            this.panelContainer.TabIndex = 0;
            // 
            // panelBar
            // 
            this.panelBar.Controls.Add(this.pictureBox2);
            this.panelBar.Controls.Add(this.pictureBox1);
            this.panelBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBar.Location = new System.Drawing.Point(251, 0);
            this.panelBar.Name = "panelBar";
            this.panelBar.Size = new System.Drawing.Size(897, 27);
            this.panelBar.TabIndex = 2;
            this.panelBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBar_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(847, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(14, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(872, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 14);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.panelCentral.Controls.Add(this.logoMenu);
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCentral.Location = new System.Drawing.Point(251, 31);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(897, 647);
            this.panelCentral.TabIndex = 1;
            // 
            // logoMenu
            // 
            this.logoMenu.Image = ((System.Drawing.Image)(resources.GetObject("logoMenu.Image")));
            this.logoMenu.Location = new System.Drawing.Point(0, 5);
            this.logoMenu.Name = "logoMenu";
            this.logoMenu.Size = new System.Drawing.Size(897, 625);
            this.logoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoMenu.TabIndex = 0;
            this.logoMenu.TabStop = false;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.lblLogueado);
            this.leftPanel.Controls.Add(this.userLogo);
            this.leftPanel.Controls.Add(this.btnOpcion);
            this.leftPanel.Controls.Add(this.btnCategorias);
            this.leftPanel.Controls.Add(this.btnCursos);
            this.leftPanel.Controls.Add(this.lblManager);
            this.leftPanel.Controls.Add(this.LblCourses);
            this.leftPanel.Controls.Add(this.pictureLogo);
            this.leftPanel.Controls.Add(this.imageCurve);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(251, 678);
            this.leftPanel.TabIndex = 0;
            // 
            // lblLogueado
            // 
            this.lblLogueado.AutoSize = true;
            this.lblLogueado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogueado.ForeColor = System.Drawing.Color.White;
            this.lblLogueado.Location = new System.Drawing.Point(56, 641);
            this.lblLogueado.Name = "lblLogueado";
            this.lblLogueado.Size = new System.Drawing.Size(51, 15);
            this.lblLogueado.TabIndex = 6;
            this.lblLogueado.Text = "Usuario";
            // 
            // userLogo
            // 
            this.userLogo.Image = ((System.Drawing.Image)(resources.GetObject("userLogo.Image")));
            this.userLogo.Location = new System.Drawing.Point(12, 632);
            this.userLogo.Name = "userLogo";
            this.userLogo.Size = new System.Drawing.Size(38, 34);
            this.userLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userLogo.TabIndex = 5;
            this.userLogo.TabStop = false;
            // 
            // btnOpcion
            // 
            this.btnOpcion.BackColor = System.Drawing.Color.Transparent;
            this.btnOpcion.BorderRadius = 22;
            this.btnOpcion.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOpcion.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.btnOpcion.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.btnOpcion.CheckedState.Parent = this.btnOpcion;
            this.btnOpcion.CustomImages.Parent = this.btnOpcion;
            this.btnOpcion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.btnOpcion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpcion.ForeColor = System.Drawing.Color.White;
            this.btnOpcion.HoverState.Parent = this.btnOpcion;
            this.btnOpcion.Location = new System.Drawing.Point(22, 327);
            this.btnOpcion.Name = "btnOpcion";
            this.btnOpcion.ShadowDecoration.Parent = this.btnOpcion;
            this.btnOpcion.Size = new System.Drawing.Size(226, 45);
            this.btnOpcion.TabIndex = 4;
            this.btnOpcion.Text = "Objetivos";
            this.btnOpcion.UseTransparentBackground = true;
            this.btnOpcion.CheckedChanged += new System.EventHandler(this.btnCursos_CheckedChanged);
            this.btnOpcion.Click += new System.EventHandler(this.btnOpcion_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.BorderRadius = 22;
            this.btnCategorias.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCategorias.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.btnCategorias.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.btnCategorias.CheckedState.Parent = this.btnCategorias;
            this.btnCategorias.CustomImages.Parent = this.btnCategorias;
            this.btnCategorias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.btnCategorias.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.HoverState.Parent = this.btnCategorias;
            this.btnCategorias.Location = new System.Drawing.Point(22, 245);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.ShadowDecoration.Parent = this.btnCategorias;
            this.btnCategorias.Size = new System.Drawing.Size(226, 45);
            this.btnCategorias.TabIndex = 3;
            this.btnCategorias.Text = "Categorias";
            this.btnCategorias.UseTransparentBackground = true;
            this.btnCategorias.CheckedChanged += new System.EventHandler(this.btnCursos_CheckedChanged);
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.Transparent;
            this.btnCursos.BorderRadius = 22;
            this.btnCursos.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCursos.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.btnCursos.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.btnCursos.CheckedState.Parent = this.btnCursos;
            this.btnCursos.CustomImages.Parent = this.btnCursos;
            this.btnCursos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.btnCursos.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.btnCursos.ForeColor = System.Drawing.Color.White;
            this.btnCursos.HoverState.Parent = this.btnCursos;
            this.btnCursos.Location = new System.Drawing.Point(22, 160);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.ShadowDecoration.Parent = this.btnCursos;
            this.btnCursos.Size = new System.Drawing.Size(226, 45);
            this.btnCursos.TabIndex = 1;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseTransparentBackground = true;
            this.btnCursos.CheckedChanged += new System.EventHandler(this.btnCursos_CheckedChanged);
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.ForeColor = System.Drawing.Color.White;
            this.lblManager.Location = new System.Drawing.Point(114, 53);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(105, 26);
            this.lblManager.TabIndex = 2;
            this.lblManager.Text = "MANAGER";
            // 
            // LblCourses
            // 
            this.LblCourses.AutoSize = true;
            this.LblCourses.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCourses.ForeColor = System.Drawing.Color.White;
            this.LblCourses.Location = new System.Drawing.Point(107, 26);
            this.LblCourses.Name = "LblCourses";
            this.LblCourses.Size = new System.Drawing.Size(119, 33);
            this.LblCourses.TabIndex = 1;
            this.LblCourses.Text = "COURSES";
            // 
            // pictureLogo
            // 
            this.pictureLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureLogo.Image")));
            this.pictureLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(88, 81);
            this.pictureLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // imageCurve
            // 
            this.imageCurve.Image = ((System.Drawing.Image)(resources.GetObject("imageCurve.Image")));
            this.imageCurve.Location = new System.Drawing.Point(188, 129);
            this.imageCurve.Name = "imageCurve";
            this.imageCurve.Size = new System.Drawing.Size(70, 109);
            this.imageCurve.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageCurve.TabIndex = 1;
            this.imageCurve.TabStop = false;
            this.imageCurve.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 22;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 22;
            this.guna2Elipse2.TargetControl = this.panelCentral;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 678);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelContainer.ResumeLayout(false);
            this.panelBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoMenu)).EndInit();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCurve)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label LblCourses;
        private System.Windows.Forms.PictureBox pictureLogo;
        private Guna.UI2.WinForms.Guna2Button btnCursos;
        private System.Windows.Forms.PictureBox imageCurve;
        private Guna.UI2.WinForms.Guna2Button btnOpcion;
        private Guna.UI2.WinForms.Guna2Button btnCategorias;
        private System.Windows.Forms.Panel panelCentral;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panelBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox logoMenu;
        private System.Windows.Forms.PictureBox userLogo;
        private System.Windows.Forms.Label lblLogueado;
    }
}