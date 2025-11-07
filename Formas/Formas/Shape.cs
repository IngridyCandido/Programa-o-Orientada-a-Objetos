using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    internal class Shape
    {
        public Shape()
        { }
            public string Nome { get; set; }

            public virtual void Draw()
            {
                Console.WriteLine("Formato generico.");
            }
        }
    }
}
