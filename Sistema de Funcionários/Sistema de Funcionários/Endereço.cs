using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Funcionários
{
    internal class Endereço
    {
        private string rua;
        public string cidade {  get; set; }
        private string CEP;

        public Endereço(string _rua, string _cidade, string _CEP)
        {
            this.rua = _rua;
            this.cidade = _cidade;
            this.CEP = _CEP;
        }


    }
}
