using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializaçãoBinaria
{
    [Serializable]
    public class MyObject
    {
        public int n1 {  get; set; }
        public int n2 { get; set; }
        public String str { get; set; }
    }
}
