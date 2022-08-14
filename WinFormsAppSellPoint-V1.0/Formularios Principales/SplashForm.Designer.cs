namespace WinFormsAppSellPoint_V1._0
{
    partial class SplashForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerSplashForm = new System.Windows.Forms.Timer(this.components);
            this.labelProgressBar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CircleProgressBarSplash = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pictureBoxSplash = new System.Windows.Forms.PictureBox();
            this.labelSplash = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.CircleProgressBarSplash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSplashForm
            // 
            this.timerSplashForm.Enabled = true;
            this.timerSplashForm.Tick += new System.EventHandler(this.timerSplashForm_Tick);
            // 
            // labelProgressBar
            // 
            this.labelProgressBar.AutoSize = true;
            this.labelProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProgressBar.Location = new System.Drawing.Point(510, 312);
            this.labelProgressBar.Name = "labelProgressBar";
            this.labelProgressBar.Size = new System.Drawing.Size(0, 20);
            this.labelProgressBar.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelSplash);
            this.panel1.Controls.Add(this.CircleProgressBarSplash);
            this.panel1.Controls.Add(this.labelProgressBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 344);
            this.panel1.TabIndex = 3;
            // 
            // CircleProgressBarSplash
            // 
            this.CircleProgressBarSplash.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressBarSplash.Controls.Add(this.pictureBoxSplash);
            this.CircleProgressBarSplash.ForeColor = System.Drawing.Color.Transparent;
            this.CircleProgressBarSplash.ImageSize = new System.Drawing.Size(80, 80);
            this.CircleProgressBarSplash.Location = new System.Drawing.Point(67, 64);
            this.CircleProgressBarSplash.Name = "CircleProgressBarSplash";
            this.CircleProgressBarSplash.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.CircleProgressBarSplash.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(8)))));
            this.CircleProgressBarSplash.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBarSplash.ShadowDecoration.Parent = this.CircleProgressBarSplash;
            this.CircleProgressBarSplash.Size = new System.Drawing.Size(213, 209);
            this.CircleProgressBarSplash.TabIndex = 4;
            // 
            // pictureBoxSplash
            // 
            this.pictureBoxSplash.Image = global::WinFormsAppSellPoint_V1._0.Properties.Resources.Recurso_1_72x_8;
            this.pictureBoxSplash.Location = new System.Drawing.Point(72, 52);
            this.pictureBoxSplash.Name = "pictureBoxSplash";
            this.pictureBoxSplash.Size = new System.Drawing.Size(72, 100);
            this.pictureBoxSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSplash.TabIndex = 0;
            this.pictureBoxSplash.TabStop = false;
            // 
            // labelSplash
            // 
            this.labelSplash.AutoSize = true;
            this.labelSplash.BackColor = System.Drawing.Color.Transparent;
            this.labelSplash.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSplash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(39)))), ((int)(((byte)(85)))));
            this.labelSplash.Location = new System.Drawing.Point(286, 129);
            this.labelSplash.Name = "labelSplash";
            this.labelSplash.Size = new System.Drawing.Size(295, 73);
            this.labelSplash.TabIndex = 5;
            this.labelSplash.Text = "Sell Point";
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(605, 344);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CircleProgressBarSplash.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerSplashForm;
        private System.Windows.Forms.Label labelProgressBar;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBarSplash;
        private System.Windows.Forms.PictureBox pictureBoxSplash;
        private System.Windows.Forms.Label labelSplash;
    }
}

