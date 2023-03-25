using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class OperacionesFinancierasException : Exception
    {
        public OperacionesFinancierasException()
        {

        }

        public OperacionesFinancierasException(string message) : base(message)
        {

        }

        public OperacionesFinancierasException(string message, Exception innerException) : base(message, innerException)
        {

        }

    }
}
