using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaPOOMultiJanelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void novaJanelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovaJanela frm = new FrmNovaJanela();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?", "Fechar aplicativo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }            
        }
    }
}
