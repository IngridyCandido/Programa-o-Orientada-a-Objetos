using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAula11._12._2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() != String.Empty)
            {
                MessageBox.Show($"Bem vindo, {txtUsuario.Text}!");
            }
            else 
            {
                MessageBox.Show("Digite o nome do usuário, por favor.");
            }
        }
    }
}
