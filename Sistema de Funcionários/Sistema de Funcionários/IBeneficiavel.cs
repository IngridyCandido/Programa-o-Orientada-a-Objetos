using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Funcionários
{
    internal interface IBeneficiavel
    {
        double CalcularValeRefeicao(double salario);
        double CalcularPlanoSaude (double salario);
    }
}
