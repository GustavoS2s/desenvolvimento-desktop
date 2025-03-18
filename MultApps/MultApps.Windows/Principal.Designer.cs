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
            this.menuStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.carteirinhaToolStripMenuItem,
            this.aposentadoriaToolStripMenuItem});
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
            this.carteirinhaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
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
            this.aposentadoriaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.aposentadoriaToolStripMenuItem1.Text = "Aposentadoria";
            this.aposentadoriaToolStripMenuItem1.Click += new System.EventHandler(this.aposentadoriaToolStripMenuItem1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStripPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
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
    }
}