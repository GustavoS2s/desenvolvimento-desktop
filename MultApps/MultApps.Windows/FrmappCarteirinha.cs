using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmappCarteirinha : Form
    {
        public FrmappCarteirinha()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string dataNascimento = txtNascimento.Text.Trim();
            string cpf = txtCpf.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(dataNascimento) || string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Visitante visitante = new Visitante(nome, dataNascimento, cpf);

            if (visitante.Idade == -1)
            {
                MessageBox.Show("Data de nascimento inválida! Use o formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblNome.Text = $"Nome: {visitante.Nome}";
            lblIdade.Text = $"Idade: {visitante.Idade} anos";
            lblCPF.Text = $"CPF: {OfuscarCpf(visitante.CPF)}";
            lblZona.Text = visitante.Zona; 

            pnlCarteirinha.BackColor = visitante.CorZona;
            string iconePath = visitante.IconePath;
            if (System.IO.File.Exists(iconePath))
            {
                PicIcone.Image = Image.FromFile(iconePath);
            }
            else
            {
                PicIcone.Image = null; 
            }


            pnlCarteirinha.Visible = true;
            lblNome.Visible = true;
            lblIdade.Visible = true;
            lblCPF.Visible = true;
            lblZona.Visible = true;
            PicIcone.Visible = true;
        }

        private string OfuscarCpf(string cpf)
        {
            if (cpf.Length == 11)
            {
                return $"***.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}.***";
            }
            return "CPF inválido!";
        }
    }

    public class Visitante
    {
        public string Nome { get; }
        public int Idade { get; }
        public string CPF { get; }
        public string Zona { get; }
        public Color CorZona { get; }
        public string IconePath { get; }

        public Visitante(string nome, string dataNascimento, string cpf)
        {
            Nome = nome;
            CPF = cpf;

            if (!DateTime.TryParse(dataNascimento, out DateTime dataNasc))
            {
                Idade = -1; 
                return;
            }

            Idade = DateTime.Now.Year - dataNasc.Year;
            if (DateTime.Now.DayOfYear < dataNasc.DayOfYear)
                Idade--; 

            if (Idade <= 12)
            {
                Zona = "Zona Azul - Criança";
                CorZona = Color.Blue;
                IconePath = Application.StartupPath + @"https://e7.pngegg.com/pngimages/10/633/png-clipart-pocoyo-pocoyo-posing-at-the-movies-cartoons-thumbnail.png";
            }
            else if (Idade >= 60)
            {
                Zona = "Zona Verde - Idoso";
                CorZona = Color.Green;
                IconePath = Application.StartupPath + @"\icones\idoso.png";
            }
            else if (Idade >= 13 && Idade <= 25)
            {
                Zona = "Zona Amarela - Jovem";
                CorZona = Color.Yellow;
                IconePath = Application.StartupPath + @"\icones\jovem.png";
            }
            else
            {
                Zona = "Zona Roxa - Adulto";
                CorZona = Color.Purple;
                IconePath = Application.StartupPath + @"\icones\adulto.png";
            }
        }
    }
}
