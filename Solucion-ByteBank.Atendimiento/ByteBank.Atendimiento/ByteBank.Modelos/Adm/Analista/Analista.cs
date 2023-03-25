using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Analista: EmpleadoAutenticable, IAutenticable
    {
        public Analista(string _Dni) : base(_Dni, 30000)
        {
            Console.WriteLine("Constructor Analista");
        }

        internal protected override double obtenerBonificacion()
        {
            return this.Salario * 0.20;
        }

    }
}
