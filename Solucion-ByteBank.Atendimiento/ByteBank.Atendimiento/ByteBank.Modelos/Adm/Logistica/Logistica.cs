using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Logistica : Empleado
    {
        public Logistica(string _Dni) : base(_Dni, 15000)
        {
            Console.WriteLine("Constructor Logistica");
        }

        internal protected override double obtenerBonificacion()
        {
            return this.Salario * 0.30;
        }
    }
}
