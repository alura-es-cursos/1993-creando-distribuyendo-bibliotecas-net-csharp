using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class AdminBonificacion
    {
        private double totalBonificaciones = 0.0;

        public void Registrar(Empleado empleado)
        {
            this.totalBonificaciones += empleado.obtenerBonificacion();
        }

        public double obtenerTotalBonificaciones()
        {
            return this.totalBonificaciones;
        }
    }
}
