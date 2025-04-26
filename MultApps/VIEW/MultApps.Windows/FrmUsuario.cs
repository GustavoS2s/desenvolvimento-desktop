using MultApps.Models.Entities.Abstract;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using MultApps.Models.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmUsuario : Form
    {
        private readonly UsuarioRepositories _usuarioRepo;

        public FrmUsuario()
        {
            InitializeComponent();
            var status = new[] { "inativo", "ativo" };
            var filtros = new[] { "Todos", "Ativo", "Inativo" };
            _usuarioRepo = new UsuarioRepositories();
            CarregarFiltroStatus();
            CarregarTodosUsuarios();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string senhaDigitada = txtSenha.Text;

            if (!TemCampoEmBranco(sender, e))
                return;

            var usuario = new Usuario
            {

                Id = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                NomeCompleto = txtNome.Text,
                CPF = txtCpf.Text,
                Email = txtEmail.Text,
                Senha = CriptografiaService.Criptografar(txtSenha.Text),
                DataCriacao = string.IsNullOrEmpty(txtDataCriacao.Text) ? DateTime.Now : Convert.ToDateTime(txtDataCriacao.Text),
                DataAlteracao = DateTime.Now,
                Status = (StatusEnum)cmbStatus.SelectedIndex
            };

            bool resultado;

            if (usuario.Id == 0)
                resultado = _usuarioRepo.CadastrarUsuario(usuario);
            else
                resultado = _usuarioRepo.AtualizarUsuario(usuario);

            if (resultado)
            {
                MessageBox.Show("Usuário salvo com sucesso!");
                LimparCampos();
                CarregarTodosUsuarios();
            }
            else
            {
                MessageBox.Show("Erro ao salvar usuário.");
            }
        }

        public bool TemCampoEmBranco(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome é obrigatório.");
                txtNome.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("O campo CPF é obrigatório.");
                txtCpf.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("O campo Email é obrigatório.");
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("O campo Senha é obrigatório.");
                txtSenha.Focus();
                return false;
            }
            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("O campo Status é obrigatório.");
                cmbStatus.Focus();
                return false;
            }
            if (txtDataCriacao.Text == string.Empty)
            {
                MessageBox.Show("O campo Data de Criação é obrigatório.");
                txtDataCriacao.Focus();
                return false;
            }
            if (txtDataAlteracao.Text == string.Empty)
            {
                MessageBox.Show("O campo Data de Alteração é obrigatório.");
                txtDataAlteracao.Focus();
                return false;
            }
            return true;
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
            txtSenha.Text = "";
            _senhaOriginalHash = usuario.Senha;
            txtDataCriacao.Text = usuario.DataCriacao.ToString("dd/MM/yyyy HH:mm");
            txtDataAlteracao.Text = usuario.DataAlteracao?.ToString("dd/MM/yyyy HH:mm");
            cmbStatus.SelectedIndex = (int)usuario.Status;

            btnSalvar.Text = "Salvar Alterações";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            // Verifica se há uma linha selecionada ou ativa
            if (dataGridViewUsuarios.CurrentRow != null)
            {
                // Obtém o ID do usuário da primeira célula da linha ativa
                var idUsuario = Convert.ToInt32(dataGridViewUsuarios.CurrentRow.Cells[0].Value);

                // Confirmação de exclusão
                var confirmResult = MessageBox.Show("Tem certeza que deseja deletar este usuário?",
                                                    "Confirmação",
                                                    MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // Chama o método de exclusão no repositório
                    _usuarioRepo.DeletarUsuario(idUsuario);

                    // Atualiza o DataGridView
                    CarregarUsuarios();

                    MessageBox.Show("Usuário deletado com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um usuário para deletar.");
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
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        private string _senhaOriginalHash;

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();

            if (IsNovoRegistro()) 
            {
                txtDataCriacao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); 
                txtDataAlteracao.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm"); 
            }
        }

        private bool IsNovoRegistro()
        {
            return string.IsNullOrEmpty(txtId.Text) || txtId.Text == "0";
        }

        private void CarregarUsuarios()
        {
            var usuarios = _usuarioRepo.ListarTodosUsuarios();
            dataGridViewUsuarios.DataSource = usuarios;

            if (dataGridViewUsuarios.Columns["Senha"] != null)
            {
                dataGridViewUsuarios.Columns["Senha"].Visible = false;
            }
        }

        private void LimparLugares()
        {
            txtNome.Clear();
            txtCpf.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtDataCriacao.Clear();
            txtDataAlteracao.Clear();
            cmbStatus.SelectedIndex = -1;
        }

    }
}
