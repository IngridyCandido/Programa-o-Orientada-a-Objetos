using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Funcionários
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func;
            Console.WriteLine("Digite o tipo de Funcionário (1-Funcionário Assalariado, 2-Funcionário Horista, 3-Gerente)");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    func = new FuncionarioAssalariado();
                    break;
                case 2:
                    func = new FuncionarioHorista();
                    break;
                case 3:
                    func = new Gerente();
                    break;
            }

        }
    }
}
