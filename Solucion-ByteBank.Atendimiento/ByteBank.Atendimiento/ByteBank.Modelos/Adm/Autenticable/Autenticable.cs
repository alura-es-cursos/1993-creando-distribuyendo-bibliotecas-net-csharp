
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public interface IAutenticable
    {

        public bool autenticarUsuario(string clave);

    }
}
