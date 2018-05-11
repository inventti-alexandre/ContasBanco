using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            Console.WriteLine(cc.TaxaMovimento);
            Console.WriteLine(cc.Limite);

            ContaPoupanca cp = new ContaPoupanca();
            Console.WriteLine(cp.Limite);

            Console.ReadKey();
        }
    }
}
