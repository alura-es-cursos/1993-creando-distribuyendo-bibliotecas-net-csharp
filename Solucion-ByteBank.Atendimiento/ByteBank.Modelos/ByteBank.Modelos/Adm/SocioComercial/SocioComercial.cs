using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.Modelos
{
    public class SocioComercial : IAutenticable
    {
        public string Clave { get; set; }
        internal AutenticableHelper _helper = new AutenticableHelper();
        public bool autenticarUsuario(string clave)
        {
            return _helper.compararClave(Clave, clave);
        }
    }
}
