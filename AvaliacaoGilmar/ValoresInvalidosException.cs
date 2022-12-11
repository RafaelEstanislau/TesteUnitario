using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoGilmar
{
    public class ValoresInvalidosException : Exception
    {
        public ValoresInvalidosException()
        {
            throw new Exception("Valores Inválidos");
        }
    }
}
