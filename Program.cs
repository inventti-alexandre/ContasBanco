using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            cc.Depositar(1000);
            cp.Depositar(1000);

            cc.Sacar(200);
            cp.Sacar(200);

            Relatorio relatorio = new Relatorio();
            relatorio.Somar(cc);
            relatorio.Somar(cp);

            Console.WriteLine(
                "Conta Corrente: {0} \n" +
                "Conta Poupança: {1}",
                cc.Saldo, cp.Saldo
            );

            Console.WriteLine(
                "Relatório \n" +
                "Saldo geral: {0}",
                relatorio.SaldoGeral
            );

            Console.ReadKey();
        }
    }
}
