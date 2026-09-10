using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPráctico3
{
    internal class CuentaBancaria
    {
        private long _saldo = 5_000_000;
        public long Saldo
        {
            get
            { return _saldo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El SALDO es menor al monto a retirar.");
                }

                _saldo = value;
            }
        }

        public void Depositar(long monto)
        {
            Saldo += monto;
        }

        public void Retirar(long monto)
        {
            Saldo -= monto;
        }
    }
}
