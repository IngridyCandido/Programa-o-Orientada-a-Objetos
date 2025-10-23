using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Funcionários
{
    internal abstract class Funcionario
    {
        protected int Id { get; set; }
        protected string Nome { get; set; }
        protected string DatadeAdmissao { get; set; }

        public Endereço EnderecoFuncionario { get; set; }

        public Departamento DepartamentoFuncionario { get; set; }

        public abstract double CalcularSalario();

        public virtual double CalcularBonus(double salario)
        {
            return salario * 0.1; // Bônus de 10%
        }

        protected void ExibirDados (int id) 
        { 
            Console.WriteLine(this.Id + " " + this.Nome + " " + this.DatadeAdmissao);
        }
        
    }
}
