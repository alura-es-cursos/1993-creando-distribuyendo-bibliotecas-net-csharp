using ByteBank.Atendimiento.ByteBank.Exceptions;
using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Atendimiento.ByteBank.Atendimiento
{
    public class ByteBankAtendimiento
    {
        List<CuentaBancaria> lstCuentasBancarias = new List<CuentaBancaria>()
        {
            new CuentaBancaria("123232","21343411")
            {
                Cliente = new Cliente
                {
                    Dni= "13804050",
                    Nombre = "Leonardo"
                }
            },
            new CuentaBancaria("454532","34534411")  {
                Cliente = new Cliente
                {
                    Dni= "8001879",
                    Nombre = "Maria"
                }
            },
            new CuentaBancaria("343433","21343411")  {
                Cliente = new Cliente
                {
                    Dni= "21183783",
                    Nombre = "Pedro"
                }
            },
        };
        public void menuAtendimiento()
        {
            try
            {
                char opcion = '0';
                while (opcion != '6')
                {
                    Console.Clear();
                    Console.WriteLine("***************************");
                    Console.WriteLine("** 1 - Incluir cuenta   ***");
                    Console.WriteLine("** 2 - Mostrar cuentas  ***");
                    Console.WriteLine("** 3 - Eliminar cuenta  ***");
                    Console.WriteLine("** 4 - Ordenar cuentas  ***");
                    Console.WriteLine("** 5 - Consultar cuenta ***");
                    Console.WriteLine("** 6 - Salir            ***");
                    Console.WriteLine("***************************");
                    Console.Write("Seleccione una opción: ");
                    try
                    {
                        opcion = Console.ReadLine()[0];
                    }
                    catch (Exception e)
                    {
                        throw new ByteBankException(e.Message);
                    }

                    switch (opcion)
                    {
                        case '1':
                            IncluirCuenta();
                            break;
                        case '2':
                            MostrarCuentas();
                            break;
                        case '3':
                            EliminarCuentas();
                            break;
                        case '4':
                            OrdenarCuentas();
                            break;
                        case '5':
                            ConsultarCuentas();
                            break;
                        case '6':
                            Console.WriteLine("****** SALIENDO DE LA APLICACION ******");
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                }
            }
            catch (ByteBankException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        private void ConsultarCuentas()
        {
            try
            {
                char opcion = '0';
                while (opcion != '4')
                {
                    Console.Clear();
                    Console.WriteLine("***************************");
                    Console.WriteLine("***  CONSULTAR CUENTAS  ***");
                    Console.WriteLine("***************************");
                    Console.WriteLine("** 1 - Por DNI          ***");
                    Console.WriteLine("** 2 - Por No. de cuenta***");
                    Console.WriteLine("** 3 - Por No. agencia  ***");
                    Console.WriteLine("** 4 - Menu principal   ***");
                    Console.WriteLine("***************************");
                    Console.Write("Seleccione una opción: ");
                    try
                    {
                        opcion = Console.ReadLine()[0];
                    }
                    catch (Exception e)
                    {
                        throw new ByteBankException(e.Message);
                    }

                    CuentaBancaria cuentaBancaria = null;

                    switch (opcion)
                    {
                        case '1':
                            cuentaBancaria = ConsultarPorDNI();

                            if (cuentaBancaria != null)
                            {
                                Console.WriteLine(cuentaBancaria.ToString());
                            }
                            else
                            {
                                Console.WriteLine("No hay cuentas para este DNI");
                            }
                            break;
                        case '2':
                            cuentaBancaria = ConsultarPorNumeroCuenta();
                            if (cuentaBancaria != null)
                            {
                                Console.WriteLine(cuentaBancaria.ToString());
                            }
                            else
                            {
                                Console.WriteLine("No hay cuentas con este número");
                            }
                            break;
                        case '3':
                            Console.Write("Informe el No. de Agencia:");
                            string numeroAgencia = Console.ReadLine();
                            List<CuentaBancaria> lista = ConsultarCuentasPorAgencia(numeroAgencia);
                            MostrarResultaConsulta(lista);

                            break;
                        case '4':
                            return;

                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                    Console.ReadLine();
                }
            }
            catch (ByteBankException e)
            {
                Console.WriteLine($"{e.Message}");
            }
        }

        private void MostrarResultaConsulta(List<CuentaBancaria> lista)
        {
            if (lista == null || lista.Count() == 0)
            {
                Console.WriteLine("No se encontraron cuentas con ese criterio");
            }
            else
            {
                foreach (var item in lista)
                {
                    Console.WriteLine(item.ToString() + "\n");
                    Console.WriteLine("*************\n");
                }
            }
        }

        private List<CuentaBancaria> ConsultarCuentasPorAgencia(string numeroAgencia)
        {
            var consulta = (from cuenta in lstCuentasBancarias
                            where cuenta.NumeroAgencia == numeroAgencia
                            select cuenta).ToList();
            return consulta;
        }

        private CuentaBancaria ConsultarPorNumeroCuenta()
        {
            Console.Clear();
            Console.WriteLine("**************************************");
            Console.WriteLine("*** CONSULTAR POR NUMERO DE CUENTA ***");
            Console.WriteLine("**************************************");
            Console.Write("Número de cuenta:");

            string numeroCuenta = Console.ReadLine();
            
            return lstCuentasBancarias.Where(item => item.NumeroCuenta == numeroCuenta).FirstOrDefault();

        }

        private CuentaBancaria ConsultarPorDNI()
        {
            Console.Clear();
            Console.WriteLine("***************************");
            Console.WriteLine("***   CONSULTAR POR DNI ***");
            Console.WriteLine("***************************");
            Console.Write("DNI:");

            string dni = Console.ReadLine();
            return lstCuentasBancarias.Where(item => item.Cliente.Dni == dni).FirstOrDefault();

        }

        private void OrdenarCuentas()
        {
            lstCuentasBancarias.Sort();
            Console.WriteLine("------- LISTA DE CUENTAS ORDENADA ---");
            Console.ReadLine();

        }

        private void EliminarCuentas()
        {
            Console.Clear();
            Console.WriteLine("***************************");
            Console.WriteLine("***   ELIMINAR CUENTA   ***");
            Console.WriteLine("***************************");
            Console.Write("Numero de cuenta:");

            string numeroCuenta = Console.ReadLine();

            CuentaBancaria cuentaBancaria = null;

            foreach (var item in lstCuentasBancarias)
            {
                if (item.NumeroCuenta.Equals(numeroCuenta))
                {
                    cuentaBancaria = item;
                    break;
                }
            }

            if (cuentaBancaria != null)
            {
                lstCuentasBancarias.Remove(cuentaBancaria);
                Console.WriteLine($"Se eliminó la cuenta bancaria con número {numeroCuenta}");
            }
            else
            {
                Console.WriteLine($"No fue encontrada una cuenta con el número {numeroCuenta}");
            }
            Console.ReadLine();

        }

        private void IncluirCuenta()
        {
            Console.Clear();
            Console.WriteLine("***************************");
            Console.WriteLine("***   INCLUIR CUENTA    ***");
            Console.WriteLine("***************************");
            

            Console.Write("Numero de agencia:");
            string numeroAgencia = Console.ReadLine();

            CuentaBancaria obj = new CuentaBancaria(numeroAgencia);

            Console.WriteLine($"Número de cuenta asignado: {obj.NumeroCuenta}");

            Console.Write("Saldo inicial:");
            obj.Saldo = double.Parse(Console.ReadLine());

            Console.Write("Nombre cliente:");
            obj.Cliente.Nombre = Console.ReadLine();

            Console.Write("DNI:");
            obj.Cliente.Dni = Console.ReadLine();

            lstCuentasBancarias.Add(obj);
        }

        private void MostrarCuentas()
        {
            Console.Clear();
            Console.WriteLine("***************************");
            Console.WriteLine("***   MOSTRAR CUENTAS   ***");
            Console.WriteLine("***************************");

            if (lstCuentasBancarias.Count <= 0)
            {
                Console.WriteLine("No hay cuentas registradas");
            }
            else
            {
                foreach (CuentaBancaria obj in lstCuentasBancarias)
                {
                    Console.WriteLine("********************");
                    Console.Write("Numero de cuenta:");
                    Console.WriteLine(obj.NumeroCuenta);

                    Console.Write("Numero de agencia:");
                    Console.WriteLine(obj.NumeroAgencia);

                    Console.Write("Saldo inicial:");
                    Console.WriteLine(obj.Saldo);

                    Console.Write("Nombre cliente:");
                    Console.WriteLine(obj.Cliente.Nombre);

                    Console.Write("DNI:");
                    Console.WriteLine(obj.Cliente.Dni);

                    Console.WriteLine("********************");
                    Console.ReadLine();
                }
            }
        }

    }
}
