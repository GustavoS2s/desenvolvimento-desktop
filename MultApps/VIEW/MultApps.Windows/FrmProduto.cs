using MultApps.Models.repositories;
using MultApps.Models.Entitites.Abstract;
using System;
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
            CarregarProdutos();
            CarregarCategorias();
        }

        private void CarregarProdutos()
        {
            try
            {
                var produtos = _produtoRepository.ListarTodosProdutos();
                dgvProdutos.DataSource = produtos; // Exibe os produtos no DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar produtos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCategorias()
        {
            try
            {
                // Aqui você pode carregar as categorias de um repositório ou definir manualmente
                cmbCadastrarCategoria.Items.Clear();
                cmbCadastrarCategoria.Items.Add("Categoria 1");
                cmbCadastrarCategoria.Items.Add("Categoria 2");
                cmbCadastrarCategoria.Items.Add("Categoria 3");
                cmbCadastrarCategoria.SelectedIndex = 0; // Seleciona a primeira categoria por padrão
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar categorias: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var produto = new Produto
                {
                    Nome = txtNome.Text,
                    Descricao = txtDescricao.Text,
                    Categoria = cmbCadastrarCategoria.SelectedItem.ToString(), // Obtém a categoria selecionada
                    Preco = decimal.Parse(txtPreco.Text),
                    Estoque = int.Parse(txtEstoque.Text),
                    Status = rbAtivo.Checked ? "Ativo" : "Inativo" // Define o status com base no RadioButton selecionado
                };

                var sucesso = _produtoRepository.CadastrarProduto(produto);
                if (sucesso)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarProdutos();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.SelectedRows.Count > 0)
                {
                    var row = dgvProdutos.SelectedRows[0];
                    var produto = new Produto
                    {
                        Id = Convert.ToInt32(row.Cells["Id"].Value), // Obtém o ID da linha selecionada
                        Nome = txtNome.Text,
                        Descricao = txtDescricao.Text,
                        Categoria = cmbCadastrarCategoria.SelectedItem.ToString(), // Obtém a categoria selecionada
                        Preco = decimal.Parse(txtPreco.Text),
                        Estoque = int.Parse(txtEstoque.Text),
                        Status = rbAtivo.Checked ? "Ativo" : "Inativo" // Define o status com base no RadioButton selecionado
                    };

                    var sucesso = _produtoRepository.AtualizarProduto(produto);
                    if (sucesso)
                    {
                        MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto para atualizar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.SelectedRows.Count > 0)
                {
                    var row = dgvProdutos.SelectedRows[0];
                    var id = Convert.ToInt32(row.Cells["Id"].Value); // Obtém o ID da linha selecionada

                    var sucesso = _produtoRepository.DeletarProduto(id);
                    if (sucesso)
                    {
                        MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CarregarProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir o produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir produto: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvProdutos.Rows[e.RowIndex];
                txtNome.Text = row.Cells["Nome"].Value.ToString();
                txtDescricao.Text = row.Cells["Descricao"].Value.ToString();
                cmbCadastrarCategoria.SelectedItem = row.Cells["Categoria"].Value.ToString(); // Seleciona a categoria no ComboBox
                txtPreco.Text = row.Cells["Preco"].Value.ToString();
                txtEstoque.Text = row.Cells["Estoque"].Value.ToString();
                var status = row.Cells["Status"].Value.ToString();
                rbAtivo.Checked = status == "Ativo";
                rbInativo.Checked = status == "Inativo";
            }
        }
    }
}