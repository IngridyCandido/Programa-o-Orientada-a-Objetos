using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veiculos
{
    internal class Carro:Veiculo
    {
        public override double CalcularConsumo (double distancia)
        {
            double Consumo = distancia/12;
            return Consumo;
        }
        public override void ExibirInfo()
        {
            Console.WriteLine("Esse carro é da marca " + this.Marca + " , do modelo " + this.Modelo + " do ano " + this.Ano + "e utiliza combustível " + this.Combustível + ".");
        }
    }
}
