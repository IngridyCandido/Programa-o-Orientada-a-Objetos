using System;
using System.Collections;
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
    public partial class ListarUsuarios : Form
    {
        
        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            List<usuario> lista = BDusuarios.listarUsuarios();

            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dvgusuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }
    }
}
