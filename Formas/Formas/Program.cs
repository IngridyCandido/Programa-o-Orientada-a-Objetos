using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    internal class Program
    {
        public static void DesenharForma(Shape shapes) => shapes.Draw();
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Circle {Nome = "Círculo"},
                new Square {Nome = "Quadrado"},
                new Triangle {Nome = "Triângulo"}
            };

            foreach (Shape shape in shapes)
            {
                DesenharForma (shape);
                Console.WriteLine("Fim");
            }
        }
    }
}
