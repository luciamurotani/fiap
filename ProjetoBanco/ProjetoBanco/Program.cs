using ProjetoBanco.Enums;
using ProjetoBanco.Model;
using ProjetoBanco.Constants;

namespace ProjetoBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ContaPessoaFisica contaF = new ContaPessoaFisica();
            contaF.Numero = 121212;
            contaF.Situacao = ESituacao.Aberta;
            // Console.WriteLine("Saldo: " + contaF.exibeSaldo());

            // ContaPessoaFisica contaF1 = new ContaPessoaFisica();
            // contaF1.Numero = 121213;
            // contaF1.Situacao = ESituacao.Fechada;
            // // Console.WriteLine("Saldo: " + contaF.exibeSaldo());


            // if (contaF.Situacao.Equals(ESituacao.Aberta))
            // {
            //     Console.WriteLine("Saldo: " + contaF.exibeSaldo());

            // }
            if(contaF.verificaRestricao())
            {
                Console.WriteLine(Mensagem.MS_001);
            }
           



        }
    }
}