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
        BindingList<Filmes> filme = new BindingList<Filmes>
        {
            new Filmes {Id=1,Titulo="O Diario de uma paixão", Genero="Drama", Ano=2004, Diretor="Nick Cassavetes", Disponivel=true},
            new Filmes {Id=2,Titulo="Crepúsculo", Genero="Drama", Ano=2008, Diretor="Catherine Harwicke", Disponivel=true},
            new Filmes {Id=3,Titulo="Lua Nova", Genero="Drama", Ano=2009, Diretor="Chris Weitz", Disponivel=true},
            new Filmes {Id=4,Titulo="Eclipse", Genero="Drama", Ano=2010, Diretor="David Slade", Disponivel=true},
            new Filmes {Id=5,Titulo="Amanhecer parte I", Genero="Drama", Ano=2011, Diretor="Bill Condon", Disponivel=true},
            new Filmes {Id=6,Titulo="Amanhecer parte II", Genero="Drama", Ano=2012, Diretor="Bill Condon", Disponivel=true},
            new Filmes {Id=7,Titulo="O Lar das crianças Peculiares", Genero="Ficção Científica", Ano=2016, Diretor="Tim Burton", Disponivel=true},
            new Filmes {Id=8,Titulo="Donzela", Genero="Ação", Ano=2024, Diretor="Juan Carlos Fresnadillo", Disponivel=true},
            new Filmes {Id=9,Titulo="Como treinar o seu dragão 1", Genero="Filmes para a família", Ano=2010, Diretor="Dean DeBlois", Disponivel=true},
            new Filmes {Id=10,Titulo="Como treinar o seu dragão 2", Genero="Filmes para a família", Ano=2014, Diretor="Dean DeBlois", Disponivel=true},
            new Filmes {Id=11,Titulo="Como treinar o seu dragão 3", Genero="Filmes para a família", Ano=2019, Diretor="Dean DeBlois", Disponivel=true},
            new Filmes {Id=12,Titulo="Ela é demais", Genero="Comédia Romântica", Ano=1999, Diretor="Robert Iscove", Disponivel=true},
            new Filmes {Id=13,Titulo="A barraca do beijo", Genero="Comédia Romântica", Ano=2018, Diretor="Vince Marcello", Disponivel=true},
            new Filmes {Id=14,Titulo="Para todos os garotos que já amei", Genero="Comédia Romântica", Ano=2018, Diretor="Susan Johnson", Disponivel=true},
            new Filmes {Id=15,Titulo="Com carinho, Kitty", Genero="Drama", Ano=2025, Diretor="Jenny Han", Disponivel=true},

        };
        public ListadeFilmes()
        {
            InitializeComponent();
            dataGridView1.DataSource = filme;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
