using Locadora;
using LocadoraFilme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraFilmes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void cadastrarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuario nova = new CadastroUsuario();
            nova.MdiParent = this;
            nova.Show();
        }

        private void listarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarUsuarios nova = new ListarUsuarios();
            nova.MdiParent = this;
            nova.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Fechar aplicativo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void cadastrarFilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrodeFilmes frm1 = new CadastrodeFilmes();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadeFilmes frm = new ListadeFilmes();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
