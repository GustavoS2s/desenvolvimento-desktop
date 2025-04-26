using AcaiApp;
using MultApps.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class Principal: Form
    {
        public Usuario UsuarioLogado { get; set; }
        public Principal()
        {
            InitializeComponent();
        }
        public Principal(Usuario usuario)
        {
            InitializeComponent();
            UsuarioLogado = usuario;
        }

        private void menuCalculadoraImc_Click(object sender, EventArgs e)
        {
            var form = new FrmCalculadoraIMC();
            form.MdiParent = this;
            form.Show();

        }

        private void carteirinhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new FrmappCarteirinha();
            form.MdiParent = this;
            form.Show();
        }


        private void aposentadoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new FrmAposentadoria();
            form.MdiParent = this;
            form.Show();
        }


        private void açaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmAçai();
            form.MdiParent = this;
            form.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            statusLabelUsuario.Text = UsuarioLogado.NomeCompleto;
        }
    }
}
