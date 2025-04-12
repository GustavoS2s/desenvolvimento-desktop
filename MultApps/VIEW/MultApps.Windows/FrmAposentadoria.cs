using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmAposentadoria : Form
    {
        public FrmAposentadoria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime dataNascimento;
            bool dataValida = DateTime.TryParseExact(txtNascimento.Text, "dd/MM/yyyy",
                                                     CultureInfo.InvariantCulture,
                                                     DateTimeStyles.None, out dataNascimento);

            if (!dataValida)
            {
                MessageBox.Show("Por favor, insira uma data válida no formato dd/MM/yyyy.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idade = CalcularIdade(dataNascimento);
            int tempoContribuicao;
            bool isNumero = int.TryParse(txtContribuicao.Text, out tempoContribuicao);

            if (!isNumero || tempoContribuicao < 0)
            {
                MessageBox.Show("Por favor, insira um tempo de contribuição válido.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sexoSelecionado = cbSexo.SelectedItem.ToString();
            bool ehHomem = sexoSelecionado == "Masculino";
            bool ehMulher = sexoSelecionado == "Feminino";

            bool podeAposentar = (ehHomem && idade >= 65 && tempoContribuicao >= 20) ||
                                 (ehMulher && idade >= 62 && tempoContribuicao >= 15);

            if (podeAposentar)
            {
                lblResultado.Text = "✅ Você pode dar entrada no processo de aposentadoria!";
                pnlResultado.BackColor = Color.LightGreen;
            }
            else
            {
                lblResultado.Text = "❌ Você não cumpre os requisitos para se aposentar.";
                pnlResultado.BackColor = Color.LightCoral;
            }

            pnlResultado.Visible = true;
        }

        private int CalcularIdade(DateTime dataNascimento)
        {
            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataNascimento.Year;
            if (dataNascimento.Date > hoje.AddYears(-idade)) idade--;
            return idade;
        }
    }
}