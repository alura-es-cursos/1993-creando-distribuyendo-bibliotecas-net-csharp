using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public abstract class Empleado
    {
        public Empleado(string _Dni, double _Salario)
        {
            Console.WriteLine("Constructor Empleado");
            totalEmpleados++;
            this.Dni = _Dni;
            this.Salario = _Salario;
        }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Dni { get; private set; }
        public double Salario { get; protected set; }

        //private int Tipo { get; set; }

        public static int totalEmpleados { get; set; }

        

        internal protected abstract double obtenerBonificacion();

        public virtual void aumentarSalario()
        {
            this.Salario *= 1.10;
        }

        

    }
}
