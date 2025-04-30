using MultApps.Models.Entitites.Abstract;
using MultApps.Models.repositories;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace MultApps.Views
{
    public partial class FrmProduto : Form
    {
        private ProdutoRepositories _produtoRepository;

        public FrmProduto()
        {
            InitializeComponent();
            _produtoRepository = new ProdutoRepositories();
            ConfigurarDataGridView();
            ConfigurarFiltros();
            CarregarProdutos();
            CarregarCategorias();
            ConfigurarBotoes();
        }

        private void ConfigurarDataGridView()
        {
            dgvProdutos.Columns.Clear();

            // Configura a coluna de imagem
            var colunaImagem = new DataGridViewImageColumn
            {
                Name = "Imagem",
                HeaderText = "Imagem",
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgvProdutos.Columns.Add(colunaImagem);

            // Configura as demais colunas
            dgvProdutos.Columns.Add("Id", "ID");
            dgvProdutos.Columns.Add("Nome", "Nome");
            dgvProdutos.Columns.Add("Descricao", "Descrição");
            dgvProdutos.Columns.Add("Categoria", "Categoria");
            dgvProdutos.Columns.Add("Preco", "Preço");
            dgvProdutos.Columns.Add("Estoque", "Estoque");
            dgvProdutos.Columns.Add("Status", "Status");
        }

        private void ConfigurarFiltros()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Todos");
            cmbCategoria.Items.Add("Eletrônicos");
            cmbCategoria.Items.Add("Roupas e acessórios");
            cmbCategoria.Items.Add("Alimentos e Bebidas");
            cmbCategoria.Items.Add("Beleza e Saúde");
            cmbCategoria.Items.Add("Eletrodomésticos");
            cmbCategoria.Items.Add("Outros");
            cmbCategoria.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Todos");
            cmbStatus.Items.Add("Ativo");
            cmbStatus.Items.Add("Inativo");
            cmbStatus.SelectedIndex = 0;

            cmbCategoria.SelectedIndexChanged += (s, e) => CarregarProdutos();
            cmbStatus.SelectedIndexChanged += (s, e) => CarregarProdutos();
        }

        private void ConfigurarBotoes()
        {
            btnSalvar.Click += btnSalvar_Click;
            btnLimpar.Click += btnLimpar_Click;
            btnDeletar.Click += btnDeletar_Click;
            btnProduto.Click += btnProduto_Click;
            btnAtualizarGrid.Click += btnAtualizarGrid_Click;
        }

        private void CarregarProdutos()
        {
            try
            {
                var produtos = _produtoRepository.ListarTodosProdutos();

                var categoriaSelecionada = cmbCategoria.SelectedItem?.ToString();
                var statusSelecionado = cmbStatus.SelectedItem?.ToString();

                if (!string.IsNullOrEmpty(categoriaSelecionada) && categoriaSelecionada != "Todos")
                {
                    produtos = produtos.Where(p => p.Categoria == categoriaSelecionada).ToList();
                }

                if (!string.IsNullOrEmpty(statusSelecionado) && statusSelecionado != "Todos")
                {
                    produtos = produtos.Where(p => p.Status == statusSelecionado).ToList();
                }

                dgvProdutos.Rows.Clear();

                foreach (var produto in produtos)
                {
                    var imagem = CarregarImagem(produto.UrlImagem);

                    dgvProdutos.Rows.Add(imagem, produto.Id, produto.Nome, produto.Descricao, produto.Categoria, produto.Preco, produto.Estoque, produto.Status);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCategorias()
        {
            cmbCadastrarCategoria.Items.Clear();
            cmbCadastrarCategoria.Items.Add("Eletrônicos");
            cmbCadastrarCategoria.Items.Add("Roupas e acessórios");
            cmbCadastrarCategoria.Items.Add("Alimentos e Bebidas");
            cmbCadastrarCategoria.Items.Add("Beleza e Saúde");
            cmbCadastrarCategoria.Items.Add("Eletrodomésticos");
            cmbCadastrarCategoria.Items.Add("Outros");
            cmbCadastrarCategoria.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Código do botão Salvar (já implementado no código original)
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            txtURL.Clear();
            cmbCadastrarCategoria.SelectedIndex = 0;
            rbAtivo.Checked = true;
            rbInativo.Checked = false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow != null && dgvProdutos.CurrentRow.Cells["Id"].Value != null)
            {
                int idProduto = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["Id"].Value);

                var confirmacao = MessageBox.Show("Tem certeza que deseja deletar este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    bool sucesso = _produtoRepository.DeletarProduto(idProduto);

                    if (sucesso)
                    {
                        dgvProdutos.Rows.Remove(dgvProdutos.CurrentRow);
                        MessageBox.Show("Produto deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao deletar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto para deletar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.CurrentRow != null && dgvProdutos.CurrentRow.Cells["Id"].Value != null)
            {
                txtNome.Text = dgvProdutos.CurrentRow.Cells["Nome"].Value.ToString();
                txtDescricao.Text = dgvProdutos.CurrentRow.Cells["Descricao"].Value.ToString();
                cmbCadastrarCategoria.SelectedItem = dgvProdutos.CurrentRow.Cells["Categoria"].Value.ToString();
                txtPreco.Text = dgvProdutos.CurrentRow.Cells["Preco"].Value.ToString();
                txtEstoque.Text = dgvProdutos.CurrentRow.Cells["Estoque"].Value.ToString();
                txtURL.Text = dgvProdutos.CurrentRow.Cells["Imagem"].Value != null ? dgvProdutos.CurrentRow.Cells["Imagem"].Value.ToString() : string.Empty;

                string status = dgvProdutos.CurrentRow.Cells["Status"].Value.ToString();
                rbAtivo.Checked = status == "Ativo";
                rbInativo.Checked = status == "Inativo";
            }
            else
            {
                MessageBox.Show("Selecione um produto para visualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtualizarGrid_Click(object sender, EventArgs e)
        {
            CarregarProdutos();
            MessageBox.Show("Lista de produtos atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Image CarregarImagem(string url)
        {
            try
            {
                using (var webClient = new WebClient())
                {
                    byte[] imageBytes = webClient.DownloadData(url);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        return Image.FromStream(ms);
                    }
                }
            }
            catch
            {
                return null;
            }
        }
    }
}