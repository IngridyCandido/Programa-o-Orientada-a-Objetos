using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisãoNumerosExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1;
                int num2;
                int resultado;

                Console.WriteLine("Digite um numero para o dividendo:");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite um numero para o divisor:");
                num2 = Convert.ToInt32(Console.ReadLine());

                resultado = num1 / num2;

                Console.WriteLine("O resultado da divisão de " + num1 + " por " + num2 + " é " + resultado + ".");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Infelizmente é impossível dividir por 0 (zero).");
            }
            catch (FormatException)
            {
                Console.WriteLine("Não é possível fazer divisão com o caracter anexado.");
            }
            finally 
            {
                Console.WriteLine("Encerrando o programa...");
            }
        }
    }
}
