using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arquivos
{
    internal class ArquivoInvalidoException : Exception
    {
        public ArquivoInvalidoException(string mensagem) : base(mensagem)
        {
            
        }
    }
}
