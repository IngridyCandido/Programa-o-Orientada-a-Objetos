using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    internal abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public string Combustível { get; set; }
        public int Velocidade { get; set; }

        public abstract double CalcularConsumo (double distancia); //abstract

        public virtual void ExibirInfo() //virtual
        {
            Console.WriteLine("Esse veiculo é da marca " + this.Marca + " , do modelo " + this.Modelo + " do ano " + this.Ano + "e utiliza combustível " + this.Combustível + ".");
        }

        public void Acelerar() //concreto
        {
            Console.WriteLine("Acelerando");
            Velocidade += 10;
        }

    }
}
