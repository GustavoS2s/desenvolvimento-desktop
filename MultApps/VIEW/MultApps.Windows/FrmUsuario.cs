using MultApps.Models.Entities;
using MultApps.Models.Entities.Abstract;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmUsuario : Form
    {
        private readonly UsuarioRepositories _usuarioRepo;

        public FrmUsuario()
        {
            InitializeComponent();
            _usuarioRepo = new UsuarioRepositories();
            CarregarFiltroStatus();
            CarregarTodosUsuarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                NomeCompleto = txtNome.Text,
                CPF = txtCpf.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                DataCriacao = DateTime.Now,
                DataAlteracao = DateTime.Now,
                Status = (StatusEnum)cmbStatus.SelectedIndex
            };

            bool resultado = _usuarioRepo.CadastrarUsuario(usuario);

            if (resultado)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                LimparCampos();
                CarregarTodosUsuarios();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar usuário.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtDataCriacao.Clear();
            txtDataAlteracao.Clear();
            cmbStatus.SelectedIndex = -1;
            btnSalvar.Text = "Salvar";
        }

        private void CarregarFiltroStatus()
        {
            cmbFiltroStatus.Items.Clear();
            cmbFiltroStatus.Items.Add("Todos");
            cmbFiltroStatus.Items.Add("Ativo");
            cmbFiltroStatus.Items.Add("Inativo");
            cmbFiltroStatus.Items.Add("Excluido");
            cmbFiltroStatus.SelectedIndex = 0;

            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Inativo");
            cmbStatus.Items.Add("Ativo");
            cmbStatus.Items.Add("Excluido");
        }

        

        private void cmbFiltroStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarTodosUsuarios();
        }

        private void CarregarTodosUsuarios()
        {
            List<Usuario> usuarios;
            var filtro = cmbFiltroStatus.SelectedItem.ToString();

            switch (filtro)
            {
                case "Ativo":
                    usuarios = _usuarioRepo.FiltrarUsuariosPorStatus(StatusEnum.Ativo);
                    break;
                case "Inativo":
                    usuarios = _usuarioRepo.FiltrarUsuariosPorStatus(StatusEnum.Inativo);
                    break;
                case "Excluido":
                    usuarios = _usuarioRepo.FiltrarUsuariosPorStatus(StatusEnum.Excluido);
                    break;
                default:
                    usuarios = _usuarioRepo.ListarTodosUsuarios();
                    break;
            }

            dataGridViewUsuarios.AutoGenerateColumns = false;
            dataGridViewUsuarios.Columns.Clear();

            dataGridViewUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id"
            });

            dataGridViewUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NomeCompleto",
                HeaderText = "Nome"
            });

            dataGridViewUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "CPF",
                HeaderText = "CPF"
            });

            dataGridViewUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });

            dataGridViewUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCriacao",
                HeaderText = "Data de Criação",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });

            dataGridViewUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataAlteracao",
                HeaderText = "Última Alteração",
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" }
            });

            dataGridViewUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status"
            });

            dataGridViewUsuarios.DataSource = usuarios;
        }

        private void dataGridViewUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dataGridViewUsuarios.Rows[e.RowIndex];
            int id = (int)row.Cells[0].Value;

            var usuario = _usuarioRepo.ObterUsuarioPorId(id);

            if (usuario == null)
            {
                MessageBox.Show($"Usuário com ID {id} não encontrado.");
                return;
            }

            txtId.Text = usuario.Id.ToString();
            txtNome.Text = usuario.NomeCompleto;
            txtCpf.Text = usuario.CPF;
            txtEmail.Text = usuario.Email;
            txtSenha.Text = usuario.Senha;
            txtDataCriacao.Text = usuario.DataCriacao.ToString("dd/MM/yyyy HH:mm");
            txtDataAlteracao.Text = usuario.DataAlteracao?.ToString("dd/MM/yyyy HH:mm");
            cmbStatus.SelectedIndex = (int)usuario.Status;

            btnSalvar.Text = "Salvar Alterações";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
               
                int usuarioId = Convert.ToInt32(txtId.Text);

                
                var usuarioRepo = new UsuarioRepositories();
                bool sucesso = usuarioRepo.DeletarUsuario(usuarioId);

                if (sucesso)
                {
                    MessageBox.Show("Usuário deletado com sucesso!");
                    AtualizarListaUsuarios(); 
                }
                else
                {
                    MessageBox.Show("Erro ao deletar o usuário. Tente novamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void AtualizarListaUsuarios()
        {
            var usuarioRepo = new UsuarioRepositories();
            var usuarios = usuarioRepo.ObterUsuarios();
            dataGridViewUsuarios.DataSource = usuarios; 
        }

        private void dataGridViewUsuarios_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dataGridViewUsuarios.Rows[e.RowIndex];
            var id = (int)row.Cells[0].Value;

            var usuario = _usuarioRepo.ObterUsuarioPorId(id);

            if (usuario == null)
            {
                MessageBox.Show($"Usuário com ID {id} não encontrado.");
                return;
            }

            txtId.Text = usuario.Id.ToString();
            txtNome.Text = usuario.NomeCompleto;
            txtCpf.Text = usuario.CPF;
            txtEmail.Text = usuario.Email;
            txtSenha.Text = usuario.Senha;
            txtDataCriacao.Text = usuario.DataCriacao.ToString("dd/MM/yyyy HH:mm");
            txtDataAlteracao.Text = usuario.DataAlteracao?.ToString("dd/MM/yyyy HH:mm");
            cmbStatus.SelectedIndex = (int)usuario.Status;

            btnSalvar.Text = "Salvar Alterações";
            btnDeletar.Enabled = true;
        }
    }
}
