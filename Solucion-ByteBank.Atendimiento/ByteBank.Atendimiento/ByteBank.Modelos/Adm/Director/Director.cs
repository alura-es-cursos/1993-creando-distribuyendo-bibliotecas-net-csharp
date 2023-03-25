
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Director: EmpleadoAutenticable, IAutenticable
    {
        
        public Director(string _Dni):base(_Dni, 50000)
        {
            Console.WriteLine("Constructor Director");
        }
        
        public string Departamento { get; set; }

        internal protected override double obtenerBonificacion()
        {
            return this.Salario * 0.50;

        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.05;
        }

        
    }
}
