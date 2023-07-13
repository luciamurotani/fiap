namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? valorEmprestimo = 1000;
            int parcelas = 0;
            try
            {
                if(valorEmprestimo == null)
                {
                    throw new Exception("Informar um valor do empréstimo válido");
                 
                }
                int valorParcela = (int)valorEmprestimo / parcelas;
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
    }
}