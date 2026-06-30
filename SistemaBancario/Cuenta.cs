using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public abstract class Cuenta
    {
        public int Numero { get; }
        public string Titular { get; }
        public double Saldo { get; protected set; }

        public Cuenta(int numero, string titular, double saldoInicial)
        {
            Numero = numero;
            Titular = titular;
            if (saldoInicial >= 0)
            {
                Saldo = saldoInicial;
            }  
        }
        public void Depositar(double importe)
        {
            if (importe > 0)
            {
                Saldo += importe;
            } 
            
        }

        public abstract void Retirar(double importe);

        public abstract string Tipo { get; }
    }
}

