using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class SaldoInsuficienteException : OperacionesFinancierasException
    {
        public SaldoInsuficienteException(string message) : base(message)
        {

        }
    }
}
