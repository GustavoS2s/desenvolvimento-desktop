using System;
using System.Windows.Forms;

namespace AcaiApp
{
    public partial class FrmAçai : Form
    {
        private decimal valorAcai = 0;
        private decimal valorComplementos = 0;
        private const int MaxComplementos = 4;
        private string descricaoTamanho = "";

        public FrmAçai()
        {
            InitializeComponent();
        }

        private void AtualizarTotal()
        {
            decimal total = valorAcai + valorComplementos;
            lblTotal.Text = $"Total: R$ {total:F2}";
        }

        private void btnSelecionarTamanho_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnPequeno":
                    valorAcai = 15.00m;
                    descricaoTamanho = "Açaí Pequeno - R$15,00";
                    break;
                case "btnMedio":
                    valorAcai = 20.00m;
                    descricaoTamanho = "Açaí Médio - R$20,00";
                    break;
                case "btnGrande":
                    valorAcai = 25.00m;
                    descricaoTamanho = "Açaí Grande - R$25,00";
                    break;
                case "btnFamilia":
                    valorAcai = 35.00m;
                    descricaoTamanho = "Açaí Família - R$35,00";
                    break;
            }

            AtualizarListagem();
            AtualizarTotal();
        }

        private void nud_ValueChanged(object sender, EventArgs e)
        {
            int totalSelecionado = (int)(NudGranola.Value + NudBanana.Value + nudMorango.Value +
                                         nudLeiteCond.Value + NudLeiteNinho.Value + nudMm.Value);

            if (totalSelecionado > MaxComplementos)
            {
                MessageBox.Show("Você pode escolher no máximo 4 complementos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NumericUpDown nud = sender as NumericUpDown;
                nud.Value--;
                return;
            }

            valorComplementos = (NudGranola.Value * 2.50m) + (NudBanana.Value * 2.50m) +
                                (nudMorango.Value * 3.00m) + (nudLeiteCond.Value * 2.00m) +
                                (NudLeiteNinho.Value * 2.00m) + (nudMm.Value * 3.00m);

            AtualizarListagem();
            AtualizarTotal();
        }

        private void AtualizarListagem()
        {
            listBoxPedidos.Items.Clear();

            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                listBoxPedidos.Items.Add($"Cliente: {txtNome.Text}");
            }

            if (!string.IsNullOrEmpty(descricaoTamanho))
                listBoxPedidos.Items.Add(descricaoTamanho);

            if (NudGranola.Value > 0) listBoxPedidos.Items.Add($"Granola (x{NudGranola.Value}) - R$ {(NudGranola.Value * 2.50m):F2}");
            if (NudBanana.Value > 0) listBoxPedidos.Items.Add($"Banana (x{NudBanana.Value}) - R$ {(NudBanana.Value * 2.50m):F2}");
            if (nudMorango.Value > 0) listBoxPedidos.Items.Add($"Morango (x{nudMorango.Value}) - R$ {(nudMorango.Value * 3.00m):F2}");
            if (nudLeiteCond.Value > 0) listBoxPedidos.Items.Add($"Leite Condensado (x{nudLeiteCond.Value}) - R$ {(nudLeiteCond.Value * 2.00m):F2}");
            if (NudLeiteNinho.Value > 0) listBoxPedidos.Items.Add($"Leite Ninho (x{NudLeiteNinho.Value}) - R$ {(NudLeiteNinho.Value * 2.00m):F2}");
            if (nudMm.Value > 0) listBoxPedidos.Items.Add($"MM (x{nudMm.Value}) - R$ {(nudMm.Value * 3.00m):F2}");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, insira seu nome!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (valorAcai == 0)
            {
                MessageBox.Show("Por favor, selecione o tamanho do açaí!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AtualizarListagem();

            string nomeCliente = txtNome.Text;
            long senha = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

            MessageBox.Show($"Pedido confirmado para {nomeCliente}!\nSua senha: {senha}",
                            "Pedido Confirmado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
