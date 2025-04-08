using MultApps.Models.Entitites.Abstract;
using MultApps.Models.Enums;
using MultApps.Models.repositories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
            CarregarTodasCategorias();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var categoriaRepositories = new CategoriaRepositories();
            var categoria = new Categoria();

            if (int.TryParse(txtId.Text, out int categoriaId))
            {
                categoria.Id = categoriaId;
            }
            else
            {
                categoria.Id = 0; 
            }

            categoria.Nome = txtNome.Text;
            categoria.Status = (StatusEnum)cmbStatus.SelectedIndex;

            if (categoria.Id == 0)
            {
                var resultado = categoriaRepositories.CadastrarCategoria(categoria);
                if (resultado)
                {
                    MessageBox.Show("Categoria cadastrada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar categoria");
                }
            }
            else
            {
                var resultado = categoriaRepositories.AtualizarCategoria(categoria);
                if (resultado)
                {
                    MessageBox.Show("Categoria atualizada com sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar categoria");
                }
            }

            // Recarregar as categorias no DataGridView
            CarregarTodasCategorias();

            // Limpar os campos após salvar
            txtId.Clear();
            txtNome.Clear();
            txtDataCriacao.Clear();
            txtDataAlteracao.Clear();
            cmbStatus.SelectedIndex = -1; // Deixa o ComboBox desmarcado
        }




        private void CarregarTodasCategorias()
        {
            var categoriaRepositories = new CategoriaRepositories();
            var ListaDeCategorias = categoriaRepositories.ListarTodasCategorias();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome da Categoria"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCriacao",
                HeaderText = "Data de Cadastro",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracao",
                HeaderText = "Data de Alteração",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:MM" },
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
            });

            dataGridView1.DataSource = ListaDeCategorias;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show($"Houve um erro ao clicar duas vezes sobre o Grid");
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var categoriaId = (int)row.Cells[0].Value;

            var categoriaRepositories = new CategoriaRepositories();
            var categoria = categoriaRepositories.ObterCategoriaPorId(categoriaId);

            if (categoria == null)
            {
                MessageBox.Show($"Categoria: #{categoriaId} não encontrada");
                return;
            }

            txtId.Text = categoria.Id.ToString();
            txtNome.Text = categoria.Nome;
            cmbStatus.SelectedIndex = (int)categoria.Status;
            txtDataCriacao.Text = categoria.DataCriacao.ToString("dd/MM/yyyy HH:mm");
            txtDataAlteracao.Text = categoria.DataAlteracao.ToString("dd/MM/yyyy HH:mm");
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNome.Clear();
            txtDataCriacao.Clear();
            txtDataAlteracao.Clear();
            cmbStatus.SelectedIndex = -1;
        }

    }
}
