using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaPOOGridView
{
    public partial class Form1 : Form
    {
        BindingList<Produto> produtos = new BindingList<Produto>
        {
            new Produto {Id=1,Nome="Camisa", Preco=30.0},
            new Produto {Id=2,Nome="Tenis", Preco=200.0},
            new Produto {Id=3,Nome="Chapéu", Preco=80.0},
            new Produto {Id=4,Nome="Calça", Preco = 150.0},
            new Produto {Id=5,Nome="Bolsa", Preco = 100.0},
            new Produto {Id=6,Nome="Colar", Preco = 20.0}
        };
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = produtos;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
