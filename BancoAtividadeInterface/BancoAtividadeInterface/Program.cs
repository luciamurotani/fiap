using BancoAtividadeInterface.Models;

namespace BancoAtividadeInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            cc.depositar(1000);
            cc.sacar(500);
            // Console.WriteLine(cc.exibirSaldo());

            ContaPoupanca cp = new ContaPoupanca();
            cp.depositar(1000);
            cp.sacar(500);

            ControladorExtrato ce = new ControladorExtrato();
            ce.geradorExtrato(cc);
            ce.geradorExtrato(cp);

        }
    }
}