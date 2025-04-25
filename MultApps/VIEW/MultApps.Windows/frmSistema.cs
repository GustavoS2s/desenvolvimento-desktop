using MultApps.Models.Entities.Abstract;
using MultApps.Models.Enums;
using MultApps.Models.Repositories;
using MultApps.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{


    public partial class frmSistema : Form
    {
        public frmSistema()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Usuário é obrigatório.");
                return;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Senha é obrigatória.");
                return;
            }

            var usuarioRepositories = new UsuarioRepositories();
            var usuario = usuarioRepositories.ObterUsuarioPorEmail(txtUsuario.Text);

            if (usuario == null || usuario.Email != txtUsuario.Text)
            {
                MessageBox.Show("Usuário não encontrado.");
                txtUsuario.Focus();
                return;
            }

            if (usuario.Status == StatusEnum.Inativo)
            {
                MessageBox.Show(" O usuário está inativo.");
                txtUsuario.Focus();
                return;
            }

            var senhaConfere = CriptografiaService.Verificar(txtSenha.Text, usuario.Senha);

            if(senhaConfere)
            {
                var formPrincipal = new Principal(usuario);
                formPrincipal.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Usuário ou senha invalida");
            }
        }

        private void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("Informe o email do seu usuário");
                txtUsuario.Focus();
                return;
            }

            var usuariorepositories = new UsuarioRepositories();
            var novaSenha = CriptografiaService.Criptografar("123456");

            var senhaAtualizou = usuariorepositories.AtualizarSenha(novaSenha, txtUsuario.Text);
            if (senhaAtualizou)
            {
                MessageBox.Show("Senha atualizada com sucesso. A nova senha é : 123456");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar a senha");
            }
        }
    }
}