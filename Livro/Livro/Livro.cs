using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livro
{
	internal class Livro
	{
		//atributos
		public string titulo;
		public string autor;
		public int paginas;
		public int paginaAtual;

		//construtor
		public Livro(string titulo, string autor, int paginas)
		{
			this.titulo = titulo;
			this.autor = autor;
			this.paginas = paginas;
			this.paginaAtual = 1;
		}

		//métodos
		public void LerPagina()
		{
			paginaAtual ++;
		}

		public double ObterProgresso(double porcentagemlida)
		{
			return (paginas / paginaAtual) * 100;
		}

		public void Reiniciar()
		{
			paginaAtual = 1;
		}
	}
}