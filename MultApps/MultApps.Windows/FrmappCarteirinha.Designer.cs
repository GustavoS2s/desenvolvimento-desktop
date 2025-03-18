namespace MultApps.Windows
{
    partial class FrmappCarteirinha
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
            this.lblNome1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpf1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.pnlCarteirinha = new System.Windows.Forms.Panel();
            this.lblZona = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.PicIcone = new System.Windows.Forms.PictureBox();
            this.pnlCarteirinha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(83, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(628, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gerador de carteirinha de acesso ao parque";
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome1.Location = new System.Drawing.Point(13, 91);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(62, 24);
            this.lblNome1.TabIndex = 1;
            this.lblNome1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(17, 119);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(359, 20);
            this.txtNome.TabIndex = 2;
            // 
            // lblCpf1
            // 
            this.lblCpf1.AutoSize = true;
            this.lblCpf1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf1.Location = new System.Drawing.Point(13, 164);
            this.lblCpf1.Name = "lblCpf1";
            this.lblCpf1.Size = new System.Drawing.Size(47, 24);
            this.lblCpf1.TabIndex = 3;
            this.lblCpf1.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(17, 192);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(359, 20);
            this.txtCpf.TabIndex = 4;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(14, 237);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(179, 24);
            this.lblNascimento.TabIndex = 5;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(13, 265);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(363, 20);
            this.txtNascimento.TabIndex = 6;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(12, 320);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(364, 34);
            this.btnGerar.TabIndex = 7;
            this.btnGerar.Text = "Gerar carteirinha";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // pnlCarteirinha
            // 
            this.pnlCarteirinha.Controls.Add(this.lblZona);
            this.pnlCarteirinha.Controls.Add(this.lblIdade);
            this.pnlCarteirinha.Controls.Add(this.lblCPF);
            this.pnlCarteirinha.Controls.Add(this.lblNome);
            this.pnlCarteirinha.Controls.Add(this.PicIcone);
            this.pnlCarteirinha.Location = new System.Drawing.Point(511, 91);
            this.pnlCarteirinha.Name = "pnlCarteirinha";
            this.pnlCarteirinha.Size = new System.Drawing.Size(257, 309);
            this.pnlCarteirinha.TabIndex = 8;
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.Location = new System.Drawing.Point(38, 229);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(32, 13);
            this.lblZona.TabIndex = 4;
            this.lblZona.Text = "Zona";
            this.lblZona.Visible = false;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(38, 200);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade";
            this.lblIdade.Visible = false;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(35, 174);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF ";
            this.lblCPF.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNome.Location = new System.Drawing.Point(35, 146);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(93, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome do Visitante";
            this.lblNome.Visible = false;
            // 
            // PicIcone
            // 
            this.PicIcone.Location = new System.Drawing.Point(57, 28);
            this.PicIcone.Name = "PicIcone";
            this.PicIcone.Size = new System.Drawing.Size(156, 93);
            this.PicIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicIcone.TabIndex = 0;
            this.PicIcone.TabStop = false;
            // 
            // FrmappCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlCarteirinha);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblCpf1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmappCarteirinha";
            this.Text = "FrmappCarteirinha";
            this.pnlCarteirinha.ResumeLayout(false);
            this.pnlCarteirinha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicIcone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCpf1;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.TextBox txtNascimento;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Panel pnlCarteirinha;
        private System.Windows.Forms.PictureBox PicIcone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblZona;
    }
}