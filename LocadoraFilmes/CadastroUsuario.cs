using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraFilme
{
    public partial class CadastroUsuario : Form
    {
        public CadastroUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<usuario> lista = BDusuarios.listarUsuarios();
            string busca = txtcpf.Text;

            if (string.IsNullOrEmpty(busca))
            {
                MessageBox.Show("Por favor, digite o CPF para excluir.");
                return;
            }

            lista.RemoveAll(x => x.cpf == busca);

            BDusuarios.adicionarUsuario(lista);

            MessageBox.Show("Usuário removido com sucesso.");

            txtcpf.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtcpf.Text) || string.IsNullOrWhiteSpace(txtnome.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }

            List<usuario> lista = BDusuarios.listarUsuarios();

            usuario novo = new usuario();
            novo.cpf = (txtcpf.Text);
            novo.nome = txtnome.Text;
            novo.endereco = txtendereco.Text;
  


            lista.Add(novo);
            BDusuarios.adicionarUsuario(lista);

            MessageBox.Show("Salvo com sucesso!");
            txtnome.Clear();
            txtcpf.Clear();
            txtendereco.Clear();
        }
    }
}
