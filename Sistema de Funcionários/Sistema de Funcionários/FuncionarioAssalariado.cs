using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Funcionários
{
    internal class FuncionarioAssalariado : Funcionario, IBeneficiavel, IPromovivel
    {
        public double ValorMensal {  get; set; }
        public override double CalcularSalario()
        {
            return ValorMensal;
        }
        public override double CalcularBonus(double salario)
        {
            return salario * 0.1; // Bônus de 10%
        }

        public double CalcularValeRefeicao(double salario)
        {
            return salario * 0.2;
        }

        public double CalcularPlanoSaude(double salario)
        {
            return salario * 0.3;
        }

        public void AvaliarPerformance(double notaAvaliacao)
        {
            if (notaAvaliacao>8)
                Console.WriteLine("Precisa melhorar.");
            else
            {
                Console.WriteLine("Ele é Ótimo!");
            }
        }

        public void AvaliarPromocao(double notaValor)
        {
            if (notaValor>8)
                Console.WriteLine("Ele pode ser promovido.");
            else
            {
                Console.WriteLine("Precisa melhorar.");
            }
        }
    }
}
