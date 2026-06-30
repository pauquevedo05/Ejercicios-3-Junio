using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{ 
    public class CuentaPlus : Cuenta
    {
        public CuentaPlus(int n, string t, double s) : base(n, t, s) { }

        public override void Retirar(double importe)
        {
            double comision = importe * 0.025;
            double total = importe + comision;

            if (importe > 0 && total <= Saldo)
            {
                Saldo -= total;
            }
        }
        public override string Tipo => "Cuenta Plus";
    }
}
