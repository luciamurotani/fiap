
using FiapDonationSystem.Enum;
using FiapDonationSystem.Model;

namespace FiapDonationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {

            Roupa roupa = new Roupa();
            roupa.nome = "Camiseta";
            roupa.Categoria = ECategoria.Camisetas;
            roupa.Tamanho = ETamanhoRoupa._4;
            roupa.TipoComprimento = EComprimentoRoupa.AcimaDoJoelho;
            Console.WriteLine(roupa.exibirDados());

            Calcado calcado = new Calcado();
            calcado.Tamanho = ETamanhoCalcado.Dois;
            calcado.TipoAjuste = ETipoAjuste.Botao;



            //Produto p = new Produto();


//            p.nome = "sapato";
//            p.descricao = "sapato rosa novo";
//            p.genero = "feminino";
//            p.foto = "sem foto";
//            p.status = true;


           

//            Usuario usuario = new Usuario();
//            usuario.nome = "Admin";
//            usuario.email = "";
//;            Console.WriteLine("E-mail: "+ usuario.exibirDados());
        }
    }
}