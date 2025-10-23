using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Funcionários
{
    internal class FuncionarioHorista : Funcionario
    {
        public double HorasTrabalhadas { get; set; }
        public override double CalcularSalario()
        {
            return HorasTrabalhadas * 30;
        }
        public override double CalcularBonus(double salario)
        {
            return base.CalcularBonus(salario) + 150;
        }
    }
}
