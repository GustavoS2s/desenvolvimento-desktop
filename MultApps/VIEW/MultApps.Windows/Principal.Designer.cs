namespace MultApps.Windows
{
    partial class Principal
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
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalculadoraImc = new System.Windows.Forms.ToolStripMenuItem();
            this.carteirinhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carteirinhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aposentadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aposentadoriaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.carteirinhaToolStripMenuItem,
            this.aposentadoriaToolStripMenuItem,
            this.acaiToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuStripPrincipal.TabIndex = 1;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalculadoraImc});
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // menuCalculadoraImc
            // 
            this.menuCalculadoraImc.Name = "menuCalculadoraImc";
            this.menuCalculadoraImc.Size = new System.Drawing.Size(178, 22);
            this.menuCalculadoraImc.Text = "Calculadora de IMC";
            this.menuCalculadoraImc.Click += new System.EventHandler(this.menuCalculadoraImc_Click);
            // 
            // carteirinhaToolStripMenuItem
            // 
            this.carteirinhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.carteirinhaToolStripMenuItem1});
            this.carteirinhaToolStripMenuItem.Name = "carteirinhaToolStripMenuItem";
            this.carteirinhaToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.carteirinhaToolStripMenuItem.Text = "Carteirinha";
            // 
            // carteirinhaToolStripMenuItem1
            // 
            this.carteirinhaToolStripMenuItem1.Name = "carteirinhaToolStripMenuItem1";
            this.carteirinhaToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.carteirinhaToolStripMenuItem1.Text = "Carteirinha";
            this.carteirinhaToolStripMenuItem1.Click += new System.EventHandler(this.carteirinhaToolStripMenuItem1_Click);
            // 
            // aposentadoriaToolStripMenuItem
            // 
            this.aposentadoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aposentadoriaToolStripMenuItem1});
            this.aposentadoriaToolStripMenuItem.Name = "aposentadoriaToolStripMenuItem";
            this.aposentadoriaToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.aposentadoriaToolStripMenuItem.Text = "Aposentadoria";
            // 
            // aposentadoriaToolStripMenuItem1
            // 
            this.aposentadoriaToolStripMenuItem1.Name = "aposentadoriaToolStripMenuItem1";
            this.aposentadoriaToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.aposentadoriaToolStripMenuItem1.Text = "Aposentadoria";
            this.aposentadoriaToolStripMenuItem1.Click += new System.EventHandler(this.aposentadoriaToolStripMenuItem1_Click);
            // 
            // acaiToolStripMenuItem
            // 
            this.acaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açaiToolStripMenuItem});
            this.acaiToolStripMenuItem.Name = "acaiToolStripMenuItem";
            this.acaiToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.acaiToolStripMenuItem.Text = "Acai";
            // 
            // açaiToolStripMenuItem
            // 
            this.açaiToolStripMenuItem.Name = "açaiToolStripMenuItem";
            this.açaiToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.açaiToolStripMenuItem.Text = "Açai";
            this.açaiToolStripMenuItem.Click += new System.EventHandler(this.açaiToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelUsuario
            // 
            this.statusLabelUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelUsuario.ForeColor = System.Drawing.Color.Blue;
            this.statusLabelUsuario.Name = "statusLabelUsuario";
            this.statusLabelUsuario.Size = new System.Drawing.Size(151, 20);
            this.statusLabelUsuario.Text = "toolStripStatusLabel1";
            this.statusLabelUsuario.VisitedLinkColor = System.Drawing.Color.Purple;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::MultApps.Windows.Properties.Resources.Captura_de_tela_2025_03_13_1954541;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripPrincipal);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCalculadoraImc;
        private System.Windows.Forms.ToolStripMenuItem carteirinhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carteirinhaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aposentadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aposentadoriaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açaiToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelUsuario;
    }
}