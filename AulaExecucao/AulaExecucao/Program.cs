using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaExecucao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            int[] numeros = { 1, 2, 3 };
            int i = 5;
            if (i < 0 || i >= numeros.Length) {
                Console.WriteLine("Elemento não encontrado na lista");
            }
            else {
                Console.WriteLine(numeros[i]);
            }
            // }
            // catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Elemento não encontrado na lista.");
            //}

            try
            {
                int a = int.Parse("abc");
            }
            catch (FormatException) 
            {
                Console.WriteLine("Erro de formato");
            }
            catch (Exception)
            {
                Console.WriteLine("Erro genérico");
            }
        }
    }
}
