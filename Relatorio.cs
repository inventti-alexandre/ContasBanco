using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Relatorio
    {
        public decimal SaldoGeral { get; private set; }

        public void Somar(Conta conta)
        {
            this.SaldoGeral += conta.Saldo;
        }
    }
}
