using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    public class CuentaEstandar : Cuenta
    {
        public CuentaEstandar(int numero, string titular, double saldo) : base(numero, titular, saldo) { }

        public override void Retirar(double importe)
        {
            double comision = importe * 0.05;
            double total = importe + comision;

            if (importe > 0 && importe <= 50000 && total <= Saldo)
            {
                Saldo -= total;

            }
        }

        public override string Tipo => "Cuenta Estándar";
    }
}
