using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Esta clase define el modelo de las cuentas bancarias de ByteBank
    /// </summary>
    public class CuentaBancaria : IComparable<CuentaBancaria>
    {
        //Atributos de la clase
        public static int _cantidad_cuentas = 0;

        //Atributos de instancia
        public string _numero_cuenta;
        public string _numero_agencia;
        private double _saldo;

        /// <summary>
        /// Constructor de la clase CuentaBancaria de ByteBank
        /// </summary>
        /// <param name="_numero_cuenta">El parametro <see cref="_numero_cuenta"/> almacena el número de la cuenta bancaria. No puede ser vacío</param>
        /// <param name="_numero_agencia">El parametro <see cref="_numero_agencia"/> almacena el número de la agencia donde está la cuenta bancaria. No puede ser vacío</param>
        public CuentaBancaria(string _numero_cuenta, string _numero_agencia)
        {
            if (_numero_agencia == "")
            {
                throw new ArgumentException("Es necesario indicar el número de agencia",nameof(_numero_agencia));
            }
            if (_numero_cuenta == "")
            {
                throw new ArgumentException("Es necesario indicar el número de cuenta", nameof(_numero_cuenta));
            }
            NumeroCuenta = _numero_cuenta;
            NumeroAgencia = _numero_agencia;
            Cliente = new Cliente();
            _cantidad_cuentas++;
        }

        public CuentaBancaria(string _numero_agencia)
        {
            if (_numero_agencia == "")
            {
                throw new ArgumentException("Es necesario indicar el número de agencia", nameof(_numero_agencia));
            }
            _numero_cuenta = Guid.NewGuid().ToString().Substring(0, 8);
            NumeroCuenta = _numero_cuenta;
            NumeroAgencia = _numero_agencia;
            Cliente = new Cliente();
            _cantidad_cuentas++;
        }


        //Propiedades

        /// <summary>
        /// Esta propiedad hace referencia a la instancia de Cliente
        /// </summary>
        public Cliente Cliente
        {
            get;set;
        }

        public string NumeroCuenta
        {
            get { return _numero_cuenta; }
            set
            {
                if (value != null && value != "")
                    _numero_cuenta = value;
            }
        }

        public string NumeroAgencia
        {
            get { return _numero_agencia; }
            set
            {
                if (value != null && value != "")
                    _numero_agencia = value;
            }
        }
        public int cantidadRetirosSinSaldo { get; private set; }

        public int cantidadTransferenciasSinSaldo { get; private set; }


        public double Saldo
        {
            get { return _saldo; }
            set {
                if (value >= 0)
                {
                    _saldo = value;
                }
                else
                {
                    _saldo = 0;
                }
            }
        }

        public double TasaInteres
        {
            get;set;
        }

        public double LimiteSobregiro
        {
            get; set;
        }

        public bool CuentaActiva
        {
            get; set;
        }

        public double ValorComision { get; private set; }


        //Métodos

        /// <summary>
        /// Este método permite disminuir el saldo de la cuenta a partir de un retiro.
        /// </summary>
        /// <param name="valorARetirar">Es el valor a retirar de la cuenta.</param>
        /// <returns></returns>
        /// <exception cref="SaldoInsuficienteException">Esta excepción es generada cuando se intenta retirar un valor mayor al saldo disponible</exception>
        /// <exception cref="ArgumentException">Se dispara la excepción cuando se intenta hacer un retiro de un valor negativo</exception>
        public bool RetirarDinero(double valorARetirar)
        {

            if (Saldo < valorARetirar)
            {
                //Console.WriteLine("No hay saldo suficiente para el retiro");
                //return false;
                this.cantidadRetirosSinSaldo++;
                throw new SaldoInsuficienteException("No hay saldo suficiente para el retiro. Saldo Actual:"+Saldo+" - Monto a retirar:"+valorARetirar);
            } else if (valorARetirar <= 0)
            {
                throw new ArgumentException("No hay saldo suficiente para el retiro. Saldo Actual:"+Saldo+" - Monto a retirar:"+valorARetirar);
            }

            //saldo = saldo - valorARetirar;
            Saldo-= valorARetirar;

            return true;
        }

        //Método DepositarDinero
        public void DepositarDinero(double valorADepositar)
        {
            if (valorADepositar < 0)
            {
                Console.WriteLine("No es posible depositar valores negativos");
                return;
            }
            Saldo += valorADepositar;
            return;
        }

        //Método TransferirSaldo
        public double TransferirSaldo(double valorATransferir, CuentaBancaria cuentaReceptora)
        {
            //Retiramos el saldo de la cuenta origen
            try
            {
                RetirarDinero(valorATransferir);
            }
            catch (SaldoInsuficienteException ex)
            {
                this.cantidadTransferenciasSinSaldo++;
                throw new OperacionesFinancierasException("Transferencia no realizada", ex);
            }
            

            cuentaReceptora.DepositarDinero(valorATransferir);

            return Saldo;

        }

        /*
        public void DefinirSaldo(double saldoInicial)
        {
            if (saldoInicial >= 0)
            {
                saldo = saldoInicial;
            }
            else
            {
                Console.WriteLine("Saldo Inicial debe ser mayor o igual que 0");
            }
        }

        public double ObtenerSaldo()
        {
            return saldo;
        }
        */

        public override string ToString()
        {
            return $"Número de cuenta: {_numero_cuenta}. \n" +
                   $"Número de Agencia: {_numero_agencia}.\n" +
                   $"DNI: {Cliente.Dni}.\n" +
                   $"Nombre Cliente: {Cliente.Nombre}.\n" +
                   $"Saldo: {Saldo}";
        }

        public int CompareTo(CuentaBancaria? other)
        {
            if (other == null)
                return 1;
            return _numero_cuenta.CompareTo(other._numero_cuenta);
        }
    }
}
