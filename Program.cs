using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Saldo = 1000;
            cp.Saldo = 1000;

            cc.Sacar(200);
            cp.Sacar(200);

            Console.WriteLine(
                "Conta Corrente: {0} \n" +
                "Conta Poupança: {1}",
                cc.Saldo, cp.Saldo
            );

            Console.ReadKey();
        }
    }
}
