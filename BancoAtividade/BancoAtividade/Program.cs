using BancoAtividade.Models;

namespace BancoAtividade
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente  contaCC = new ContaCorrente();
            contaCC.Depositar(100);
            contaCC.Sacar(50);
            Console.WriteLine("Saldo Conta Corrente: " + contaCC.exibirSaldo());
            
        }
    }
}