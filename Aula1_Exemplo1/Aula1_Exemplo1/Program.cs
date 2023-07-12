namespace Aula1_Exemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1 = new Usuario();
            usuario1.nome = "Admin";
            usuario1.email = "admin@fiap.com.br";
         
            Console.WriteLine(usuario1.exibirDados());
        }
    }
}