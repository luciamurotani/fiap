namespace Aula5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vida vida = new Vida();
            vida.DataContratacao = DateTime.Today;
            vida.TipoPlano = "básico";
            vida.Valor = 2000;
            Console.WriteLine(vida.getValidade());
            Console.WriteLine(vida.calculaImposto());
            vida.enviarMensagem("Seguro de vida Contratado com sucesso! Qualquer dúvida entre em contato com: ");


            Veiculo veiculo = new Veiculo();

            GerenciadorImpostoRenda gir = new GerenciadorImpostoRenda();
            gir.Total = 1000;
            gir.adicionar(vida);

            Console.WriteLine("Valor total do IR: " + gir.Total);

        }
    }
}