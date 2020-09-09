namespace ProjectoPAV
{
    partial class Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadbar = new System.Windows.Forms.Panel();
            this.loadsegment = new System.Windows.Forms.Panel();
            this.timerload = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loadbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // loadbar
            // 
            this.loadbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.loadbar.Controls.Add(this.loadsegment);
            this.loadbar.Location = new System.Drawing.Point(-2, 327);
            this.loadbar.Name = "loadbar";
            this.loadbar.Size = new System.Drawing.Size(602, 10);
            this.loadbar.TabIndex = 1;
            // 
            // loadsegment
            // 
            this.loadsegment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(57)))));
            this.loadsegment.Location = new System.Drawing.Point(2, 0);
            this.loadsegment.Name = "loadsegment";
            this.loadsegment.Size = new System.Drawing.Size(22, 10);
            this.loadsegment.TabIndex = 2;
            // 
            // timerload
            // 
            this.timerload.Enabled = true;
            this.timerload.Interval = 15;
            this.timerload.Tick += new System.EventHandler(this.timerload_Tick);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 337);
            this.Controls.Add(this.loadbar);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(599, 337);
            this.MinimumSize = new System.Drawing.Size(599, 337);
            this.Name = "Load";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loadbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel loadbar;
        private System.Windows.Forms.Panel loadsegment;
        private System.Windows.Forms.Timer timerload;
    }
}

