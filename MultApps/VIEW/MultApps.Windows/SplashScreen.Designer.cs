namespace MultApps.Windows
{
    partial class SplashScreen
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
            this.Piclogo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.pgbLoad = new System.Windows.Forms.ProgressBar();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.Piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Piclogo
            // 
            this.Piclogo.BackgroundImage = global::MultApps.Windows.Properties.Resources.Captura_de_tela_2025_03_13_195454;
            this.Piclogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Piclogo.Location = new System.Drawing.Point(321, 114);
            this.Piclogo.Name = "Piclogo";
            this.Piclogo.Size = new System.Drawing.Size(228, 167);
            this.Piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Piclogo.TabIndex = 0;
            this.Piclogo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Rockwell Condensed", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(308, 295);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(269, 75);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "MultApps";
            // 
            // pgbLoad
            // 
            this.pgbLoad.BackColor = System.Drawing.Color.DarkKhaki;
            this.pgbLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pgbLoad.Location = new System.Drawing.Point(309, 401);
            this.pgbLoad.Name = "pgbLoad";
            this.pgbLoad.Size = new System.Drawing.Size(268, 20);
            this.pgbLoad.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbLoad.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(21, 524);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(863, 556);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pgbLoad);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.Piclogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Shown += new System.EventHandler(this.SplashScreen_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.Piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Piclogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ProgressBar pgbLoad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}