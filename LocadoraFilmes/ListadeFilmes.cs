using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora
{
    public partial class ListadeFilmes : Form
    {
        
        public ListadeFilmes()
        {
            InitializeComponent();
            List<Filmes> filme = BDFilmes.LerLista();
            dataGridView1.DataSource = filme;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
