using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    public class Cliente
    {
        //public string nombre;
        //public string dni;
        //public string profesion;

        public Cliente (string _nombre = "")
        {
            Nombre = _nombre;
        }

        public string Nombre
        {
            get;set;
        }
        public string Dni
        {
            get; set;
        }
        public string Profesion
        {
            get; set;
        }

        public override bool Equals(object? obj)
        {
            //Cliente objCliente = (Cliente)obj;
            Cliente objCliente = obj as Cliente;

            if (objCliente == null)
                return false;

            return this.Dni == objCliente.Dni &&
                this.Nombre == objCliente.Nombre &&
                this.Profesion == objCliente.Profesion;
        }
    }
}
