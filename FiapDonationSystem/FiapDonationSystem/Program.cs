
using FiapDonationSystem.Enum;
using FiapDonationSystem.Model;
using FiapDonationSystem.Data;
namespace FiapDonationSystem
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Roupa roupa = new Roupa();
            //roupa.nome = "Camiseta";
            //roupa.Categoria = ECategoria.Camisetas;
            //roupa.Tamanho = ETamanhoRoupa._4;
            //roupa.TipoComprimento = EComprimentoRoupa.AcimaDoJoelho;
            //Console.WriteLine(roupa.exibirDados());

            //Calcado calcado = new Calcado();
            //calcado.Tamanho = ETamanhoCalcado.Dois;
            //calcado.TipoAjuste = ETipoAjuste.Botao;




//            Usuario usuario = new Usuario();
//            usuario.nome = "Admin";
//            usuario.email = "";
//;           Console.WriteLine("E-mail: "+ usuario.exibirDados());


             Usuario usuario = new Usuario();
             usuario.nome = "Lucia";

                if(usuario.Autenticar("lucia", "1123"))
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Usuário ou senha inválida");
                }

            Calcado calcado = new Calcado();
            calcado.nome = "sapato";
            calcado.descricao = "sapato rosa novo";
            calcado.genero = "feminino";
            calcado.foto = "sem foto";
            calcado.status = true;

            Roupa roupa = new Roupa();
            roupa.nome = "blusa";
            roupa.Tamanho = ETamanhoRoupa.P;


            Transacao transacao = new Transacao();
            transacao.IdTransacao = 1;
            transacao.DataTroca = DateTime.Now;
            transacao.Produto = calcado;

            transacao.Usuario = usuario;


            List<Produto> listaProdutos = new List<Produto>();
            listaProdutos.Add(roupa);
            listaProdutos.Add(calcado);

            TrocaProduto trocaProduto = new TrocaProduto();
            trocaProduto.IdTroca= 1;
            trocaProduto.Produtos = listaProdutos;


            transacao.AdicionaProdutos(roupa);
            transacao.AdicionaUsuarios(usuario);


         }
    }
}