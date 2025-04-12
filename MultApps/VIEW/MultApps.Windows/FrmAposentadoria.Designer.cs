namespace MultApps.Windows
{
    partial class FrmAposentadoria
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
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtContribuicao = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.pnlResultado = new System.Windows.Forms.Panel();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblContribuicao = new System.Windows.Forms.Label();
            this.txtNascimento = new System.Windows.Forms.TextBox();
            this.pnlResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(157, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(432, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Verificador de Aposentadoria";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(9, 166);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 2;
            // 
            // txtContribuicao
            // 
            this.txtContribuicao.Location = new System.Drawing.Point(9, 231);
            this.txtContribuicao.Name = "txtContribuicao";
            this.txtContribuicao.Size = new System.Drawing.Size(100, 20);
            this.txtContribuicao.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Yellow;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(12, 318);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(142, 60);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "VERIFICAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // pnlResultado
            // 
            this.pnlResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultado.Controls.Add(this.lblResultado);
            this.pnlResultado.Location = new System.Drawing.Point(207, 281);
            this.pnlResultado.Name = "pnlResultado";
            this.pnlResultado.Size = new System.Drawing.Size(581, 50);
            this.pnlResultado.TabIndex = 5;
            this.pnlResultado.Visible = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(14, 17);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 25);
            this.lblResultado.TabIndex = 0;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.ForeColor = System.Drawing.Color.Black;
            this.lblNascimento.Location = new System.Drawing.Point(7, 74);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(224, 25);
            this.lblNascimento.TabIndex = 6;
            this.lblNascimento.Text = "Data de Nascimento";
            this.lblNascimento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sexo";
            // 
            // lblContribuicao
            // 
            this.lblContribuicao.AutoSize = true;
            this.lblContribuicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContribuicao.Location = new System.Drawing.Point(4, 203);
            this.lblContribuicao.Name = "lblContribuicao";
            this.lblContribuicao.Size = new System.Drawing.Size(326, 25);
            this.lblContribuicao.TabIndex = 8;
            this.lblContribuicao.Text = "Tempo de contribuição (anos)";
            // 
            // txtNascimento
            // 
            this.txtNascimento.Location = new System.Drawing.Point(9, 102);
            this.txtNascimento.Name = "txtNascimento";
            this.txtNascimento.Size = new System.Drawing.Size(126, 20);
            this.txtNascimento.TabIndex = 9;
            // 
            // FrmAposentadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNascimento);
            this.Controls.Add(this.lblContribuicao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.pnlResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtContribuicao);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAposentadoria";
            this.Text = "FrmAposentadoria";
            this.pnlResultado.ResumeLayout(false);
            this.pnlResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtContribuicao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel pnlResultado;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblContribuicao;
        private System.Windows.Forms.TextBox txtNascimento;
    }
}