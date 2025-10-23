using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Funcionários
{
    internal class Departamento
    {
        public string Nome { get; set;}
        public string Codigo { get; set;}

        public Departamento(string nome, string codigo) {
            Nome = nome;
            Codigo = codigo;
        }

    }
}
