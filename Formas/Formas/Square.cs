using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas
{
    internal class Square : Shape
    {
        public Square()
        { }
            public override void Draw() => Console.WriteLine("Formato de quadrado.");
    }
    }
}