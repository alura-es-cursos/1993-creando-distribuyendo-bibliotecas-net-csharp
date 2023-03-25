using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.GeneradorLlaves
{
    /// <summary>
    /// Clase estática que construye llaves únicas para cuentas bancarias
    /// </summary>
    public static class GeneradorLlaves
    {
        /// <summary>
        /// Método estático que genera una llave única, usando la clase Guid.
        /// </summary>
        /// <returns>La llave única en una cadena de caracteres.</returns>
        public static string GeneraLlaveUnica()
        {
            return Guid.NewGuid().ToString();
        }
        
        /// <summary>
        /// Método estático que permite generar múltiples llaves únicas, usando la clase Guid
        /// </summary>
        /// <param name="cantidad">Cantidad de llaves a generar : tipo entero</param>
        /// <returns>Una lista de cadenas de caracteres que contiene en cada elemento una llave única</returns>
        public static List<string> GeneraLlavesUnicas(int cantidad)
        {
            var llaves = new List<string>();

            for(int i = 0; i < cantidad;i++)
            {
                llaves.Add(GeneraLlaveUnica());
            }

            return llaves;
        }
    }
}
