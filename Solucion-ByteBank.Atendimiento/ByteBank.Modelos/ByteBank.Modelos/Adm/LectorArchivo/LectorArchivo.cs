using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    internal class LectorArchivo
    {
        public string Archivo { get; set; }

        public LectorArchivo(string archivo)
        {
            Archivo = archivo;
            Console.WriteLine("Archivo abierto...");
        }

        public string LeeLineaArchivo()
        {
            Console.WriteLine("Línea leida");
            //throw new IOException();
            throw new FileLoadException();
            return "Línea de Archivo";
        }

        public void CerrarArchivo()
        {
            Console.WriteLine("Archivo Cerrado");
        }
    }
}
