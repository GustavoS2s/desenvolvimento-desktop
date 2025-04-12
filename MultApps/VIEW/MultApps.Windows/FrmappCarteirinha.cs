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

            int idade = CalcularIdade(dataNascimento);
            if (idade == -1)
            {
                MessageBox.Show("Data de nascimento inválida! Use o formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string zona;
            Color corZona;
            string urlImagem = ""; 

            if (idade <= 12)
            {
                zona = "Zona Azul - Criança";
                corZona = Color.Blue;
                urlImagem = "https://e7.pngegg.com/pngimages/10/633/png-clipart-pocoyo-pocoyo-posing-at-the-movies-cartoons-thumbnail.png"; // URL da imagem da criança
            }
            else if (idade >= 60)
            {
                zona = "Zona Verde - Idoso";
                corZona = Color.Green;
                urlImagem = "https://img.cdndsgni.com/preview/12102238.jpg"; 
            }
            else if (idade >= 13 && idade <= 25)
            {
                zona = "Zona Amarela - Jovem";
                corZona = Color.Yellow;
                urlImagem = "https://cdn-icons-png.flaticon.com/512/15370/15370957.png"; 
            }
            else
            {
                zona = "Zona Roxa - Adulto";
                corZona = Color.Purple;
                urlImagem = "https://img.freepik.com/vetores-gratis/homem-idoso-sorridente-de-oculos_1308-174843.jpg";
            }

            lblNome.Text = $"Nome: {nome}";
            lblIdade.Text = $"Idade: {idade} anos";
            lblCPF.Text = $"CPF: {OfuscarCPF(cpf)}";
            lblZona.Text = zona;

            pnlCarteirinha.BackColor = corZona;

            try
            {
                if (!string.IsNullOrEmpty(urlImagem))
                {
                    PicIcone.Load(urlImagem); 
                }
                else
                {
                    PicIcone.Image = null;
                    MessageBox.Show("Imagem não encontrada! Verifique o caminho da imagem.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PicIcone.Image = null;
            }

            pnlCarteirinha.Visible = true;
            lblNome.Visible = true;
            lblIdade.Visible = true;
            lblCPF.Visible = true;
            lblZona.Visible = true;
            PicIcone.Visible = true;
        }

        private int CalcularIdade(string dataNascimento)
        {
            DateTime dataNasc;
            if (!DateTime.TryParse(dataNascimento, out dataNasc))
            {
                return -1;
            }

            int idade = DateTime.Now.Year - dataNasc.Year;
            if (DateTime.Now.DayOfYear < dataNasc.DayOfYear)
            {
                idade--;
            }

            return idade;
        }

        private string OfuscarCPF(string cpf)
        {
            if (cpf.Length != 11)
                return "CPF inválido";

            string parte1 = cpf.Substring(3, 3);
            string parte2 = cpf.Substring(6, 3);

            return $"***.{parte1}.{parte2}.***";
        }
    }
}

