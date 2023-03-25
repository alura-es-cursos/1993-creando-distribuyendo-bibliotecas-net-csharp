using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Atendimiento
{
        public class ListaCuentasBancarias
        {
            private int posicionActual = 0;
            private CuentaBancaria[] _listaCuentasBancarias = null;

            public ListaCuentasBancarias(int tamano = 5)
            {
                _listaCuentasBancarias = new CuentaBancaria[tamano];
            }

            public void agregar(CuentaBancaria obj)
            {
                validaEspacioObjeto(posicionActual);
                _listaCuentasBancarias[posicionActual] = obj;
                //Console.WriteLine($"Agregando elemento en la posicion {posicionActual}");
                posicionActual++;

            }

            void validaEspacioObjeto(int posicion)
            {
                if (_listaCuentasBancarias.Length > posicion)
                {
                    return;
                }
                CuentaBancaria[] nuevoArreglo = new CuentaBancaria[posicion + 1];
                for (int i = 0; i < _listaCuentasBancarias.Length; i++)
                {
                    nuevoArreglo[i] = _listaCuentasBancarias[i];
                }
                _listaCuentasBancarias = nuevoArreglo;
            }

            public void remover(CuentaBancaria obj)
            {
                int indice = -1;

                for (int i = 0; i < posicionActual; i++)
                {
                    CuentaBancaria cuentaActual = _listaCuentasBancarias[i];

                    if (cuentaActual == obj)
                    {
                        indice = i;
                        break;
                    }
                }

                for (int i = indice; i < posicionActual - 1; i++)
                {
                    _listaCuentasBancarias[i] = _listaCuentasBancarias[i + 1];
                }
                posicionActual--;
                _listaCuentasBancarias[posicionActual] = null;
            }

            public void mostrarLista()
            {
                for (int i = 0; i < _listaCuentasBancarias.Length; i++)
                {
                    if (_listaCuentasBancarias[i] != null)
                    {
                        Console.WriteLine($"Cuenta {i} - Nro. {_listaCuentasBancarias[i].NumeroCuenta} - Agencia {_listaCuentasBancarias[i].NumeroAgencia}");
                    }
                }
            
            }

            public CuentaBancaria obtenerElementoPorPosicion(int posicion)
            {
                if (posicion < 0 || posicion > posicionActual)
                {
                    throw new ArgumentOutOfRangeException(nameof(posicion));
                }
                return _listaCuentasBancarias[posicion];
            }

            public int Tamano { 
                get
                {
                    return posicionActual;
                }
            }

            public CuentaBancaria this[int posicion]
            {
                get
                {
                    return obtenerElementoPorPosicion(posicion);
                }
            }
        }

   
}
