using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    internal class CuentaBancaria
    {
        public int ValorDeposito { get; set;  }

        public int ValorRetiro { get; set; }




        private int saldo;

        public CuentaBancaria(int montoInicial)
        {
            if (montoInicial < 0)
            {
               Console.WriteLine("El monto inicial no puede ser negativo.");
            }

            saldo = montoInicial;



        }
        public int Depositar()


        {
            //Console.WriteLine("Monto inicial con el que se crea la cuenta");

            //SaldoDisponible = Convert.ToInt32(Console.ReadLine());
            int ValorDeposito = Convert.ToInt32(Console.ReadLine());
            if (ValorDeposito <= 0)
                Console.WriteLine("Introduzca un valor diferente");

            saldo += ValorDeposito;

            Console.WriteLine("Nuevo saldo: " + saldo);


            return saldo;

        }
        public int Retirar()
        {
            //Console.WriteLine("Monto inicial con el que se crea la cuenta");
            //SaldoDisponible = Convert.ToInt32(Console.ReadLine());
            int ValorRetiro = Convert.ToInt32(Console.ReadLine());

            if (ValorRetiro >  saldo)
                Console.WriteLine("Saldo insuficiente");

            saldo -= ValorRetiro;

            Console.WriteLine("Nuevo saldo: "+saldo);

            return saldo;
        }
        public int Consultar()
        {

            Console.WriteLine("El saldo actual de la cuenta es: " +     saldo);
            return saldo;
        }

    }
}
