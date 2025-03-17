namespace MultApps.Windows
{
    partial class FrmCarteirinha
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(104, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(637, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerador de carteirinha de acesso  ao parque";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(12, 101);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(16, 129);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(256, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(12, 171);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(47, 24);
            this.lblCpf.TabIndex = 3;
            this.lblCpf.Text = "CPF";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 199);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(16, 243);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(179, 24);
            this.lblNascimento.TabIndex = 5;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(16, 271);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(256, 20);
            this.txtNascimento.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(20, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Gerar Carteirinha";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblTitulo);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmCarteirinha";
            this.Text = "FrmCarteirinha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Button button1;
    }
}