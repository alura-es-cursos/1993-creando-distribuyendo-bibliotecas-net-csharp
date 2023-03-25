using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class AutenticableHelper
    {
        public bool compararClave(String _clave, string clave)
        {
            return _clave == clave;
        }
    }
}
