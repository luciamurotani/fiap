using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAtividadeInterface.Models
{
    public class Emprestimo
    {
        public int? valorEmprestimo { get; set; }

        public int? quantidadeParcela { get; set; }


        public void calculaValorPacela()
        {
            try
            {
                if (valorEmprestimo == null)
                {
                    throw new Exception("Informar um valor do empréstimo válido");

                }
                int valorParcela = (int)valorEmprestimo / (int)quantidadeParcela;
                Console.WriteLine("Valor Parcela: " + valorParcela);
                Console.WriteLine("Empréstimo realizado com sucesso!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Informe a quantidade de parcelas");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Fim!");
            }
        }

        public  void PagarEmprestimo(double valor)
        {
            Console.WriteLine($"Pagamento no valor de {valor} realizado com sucesso!");
        }

    }
}


