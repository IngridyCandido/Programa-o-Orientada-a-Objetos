using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Pessoa
    {
        public string Nome;
        public string CPF;

        public void Imprimir()
        {
            Console.WriteLine(Nome + " " + CPF);
        }
    }
}
