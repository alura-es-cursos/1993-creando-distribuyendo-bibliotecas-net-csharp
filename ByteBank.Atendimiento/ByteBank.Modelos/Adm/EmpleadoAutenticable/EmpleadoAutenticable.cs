using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class EmpleadoAutenticable:Empleado
    {
        internal AutenticableHelper _helper = new AutenticableHelper();
        public EmpleadoAutenticable(string _Dni, double _Salario) : base(_Dni, _Salario)
        {
        }

        public string Clave { get; set; }
        public bool autenticarUsuario(string clave)
        {
            return _helper.compararClave(Clave, clave);
        }

        internal protected override double obtenerBonificacion()
        {
            return 0;
        }
    }
}
