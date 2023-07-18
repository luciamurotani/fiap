using BancoAtividadeInterface.Models;

namespace BancoAtividadeInterface
{
    internal class Program
    {

       

        static void Main(string[] args)
        {
            //ContaCorrente cc = new ContaCorrente();
            //cc.depositar(1000);
            //cc.sacar(500);
            //// Console.WriteLine(cc.exibirSaldo());

            //ContaPoupanca cp = new ContaPoupanca();
            //cp.depositar(1000);
            //cp.sacar(500);

            //ControladorExtrato ce = new ControladorExtrato();
            //ce.geradorExtrato(cc);
            //ce.geradorExtrato(cp);

            //Emprestimo e = new Emprestimo();
            //e.valorEmprestimo = null;
            //e.quantidadeParcela = 10;
            // e.calculaValorPacela();


            Emprestimo emprestimo = new Emprestimo();
            var pagar = new Pagamento.pagar(emprestimo.PagarEmprestimo);
            pagar(500.00);

            var pagar1 = new Pagamento.pagar(efetuarPagamento);
            pagar(1000.00);
        }

        public static void efetuarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento no valor {valor} realizado com sucesso!!!!!!!");
        }
    }
}