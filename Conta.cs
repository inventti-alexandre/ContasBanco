using System;

namespace POO
{
    class Conta
    {
        int agencia;

        public int Agencia
        {
            get { return agencia; }
            set
            {
                if (value > 0)
                    agencia = value;
            }
        }

        int numeroConta;

        public int NumeroConta
        {
            get { return numeroConta; }
            private set { numeroConta = value; }
        }

        decimal saldo;

        public decimal Saldo
        {
            get { return saldo; }
            private set { saldo = value; }
        }

        decimal limite;

        public decimal Limite
        {
            get { return limite; }
            private set { limite = value; }
        }

        public Conta()
        {
            this.limite = 1000;
        }

        public Conta(decimal limite)
        {
            this.limite = limite;
        }

        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
    }
}
