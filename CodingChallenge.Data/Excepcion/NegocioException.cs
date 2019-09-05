using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Excepcion
{
    public class NegocioException : Exception
    {
        public NegocioException(string mensaje):base(mensaje)
        {

        }
        public NegocioException(string mensaje, Exception excepcion) : base(mensaje, excepcion)
        {

        }
    }
}
