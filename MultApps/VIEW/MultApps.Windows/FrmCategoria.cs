using MultApps.Models.Entitites.Abstract;
using MultApps.Models.Enums;
using MultApps.Models.repositories;
using System;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows.Forms;
using MultApps.Models.Entitites;
using MultApps.Models.Entities.Abstract;

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
            var categoriarepositores = new CategoriaRepositories();

            var categoria = new Categoria();
            categoria.Nome = txtNome.Text;
            categoria.Status = (StatusEnum)cmbStatus.SelectedIndex;

            var categoriaRepositories = new CategoriaRepositories();
            var resultado = categoriaRepositories.CadastrarCategoria(categoria);
            if (resultado)
            {
                MessageBox.Show("Categoria cadastra com sucesso");
            }
            else
            {
                MessageBox.Show("Error ao ao cadastrar categoria");
            }
            CarregarTodasCategorias();
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
                DataPropertyName = "DataCadastro",
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
    }
}
