using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Funcionários
{
    internal class Gerente : Funcionario
    {
        public double salario {  get; set; }
        public override double CalcularSalario()
        {
            return salario;
        }
        public override double CalcularBonus(double salario)
        {
            return salario * 0.5; // Bônus por equipe
        }
    }
}
