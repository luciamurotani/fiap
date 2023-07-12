using System.Collections;

namespace ProjetoLivraria
{
    public class Program
    {
        
        public static void ExibeLista(ArrayList array)
        {
            foreach (string i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n-----------------------------\n");
        }

        public static void ExibeListaTiposDiferentes(ArrayList array)
        {
            for(int i =0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("\n-----------------------------\n");
        }


        static void Main(string[] args)
        {

            //ArrayList teste = new ArrayList();
            //teste.Add("Ana");
            //teste.Add("eliane");
            //teste.Add("Maria");
            //teste.Add("Eliane");
            //teste.Remove("Ana");
            //Console.WriteLine(teste.Count);
            //ExibeLista(teste);

            //ArrayList teste1 = new ArrayList();
            //teste1.Add("Ana");
            //teste1.Add("eliane");
            //teste1.Add("Maria");
            //teste1.Add("Eliane");
            //teste1.Add(1);
            //teste1.Add(true);
            //teste1.Clear();

            //ExibeListaTiposDiferentes(teste1);


            List<Editora> lista = new List<Editora>();
            lista.Add(new Editora("Editora A", "site da Editora A", "telefone Editora A"));


            Editora editora = new Editora();
            editora.Nome = "Editora B";
            editora.Site = "Site da Editora B";
            editora.Telefone = "Telefone Editora B";
            lista.Add(editora);


            Editora editora1 = new Editora("Editora C", "site da Editora C", "telefone Editora C");
            lista.Add(editora1);

            lista.Remove(editora1);

            Console.WriteLine(lista.Where(x => x.Nome.Equals("Editora B")).First().Nome);
            Console.WriteLine(lista.Count);

            Dictionary<int, string> usuariosPermissao = new Dictionary<int, string>();
            usuariosPermissao.Add(1, "Acessa Banco");
            usuariosPermissao.Add(1, "Acessa xyz");

            Dictionary<string, string> paramRelatorio = new Dictionary<string, string>();
            paramRelatorio.Add("nome", "Lucia");

            HashSet<Editora> editoras = new HashSet<Editora>();
 

            //Autor autor = new Autor();
            //autor.Id = 1;
            //autor.Nome = "Nora Zuckerman";

            //List<Autor> listaAutor = new List<Autor>();
            //listaAutor.Add(autor);

            //LivroFisico livroFisico = new LivroFisico("As Crônicas de Nárnia - Coleção de Luxo", "Viagen ao fim do mundo, criaturas fantásticas e " +
            //   "batalhas épicas entre o bem e o mal - o que mais um leitor poderia querer de um livro?", "C. S. Lewis", 100, 752, editora, "capa");

            ////não aceita objetos do tipo Livro Fisico
            ////lista.Add(livroFisico);

            //List<LivroFisico> listaLivroFisico = new List<LivroFisico>();
            //listaLivroFisico.Add(livroFisico);

            // Agora é uma classe abstrata, não pode ser instânciada
            // Livro livro = new Livro(); 

            //Editora editora = new Editora();
            //editora.Nome = "HarperrCollins";

            //LivroFisico livroFisico = new LivroFisico("As Crônicas de Nárnia - Coleção de Luxo", "Viagen ao fim do mundo, criaturas fantásticas e " +
            //   "batalhas épicas entre o bem e o mal - o que mais um leitor poderia querer de um livro?", "C. S. Lewis", 100, 752, editora, "capa");

            //livroFisico.exibirDados();


            ////Instanciando um objeto do tipo Livro utilizando o contrutor sem parâmetros, cria os objetos em memória com valores default
            //Console.WriteLine("Livro com construtor sem parâmetros: ");
            //Livro livro1 = new Livro();
            //livro1.Nome = ("As Crônicas de Nárnia - Coleção de Luxo");
            //livro1.Valor = (100);
            //livro1.Resumo = ("Viagen ao fim do mundo, criaturas fantásticas e " +
            //    "batalhas épicas entre o bem e o mal -" +
            //    "o que mais um leitor poderia querer de um livro?");
            //livro1.Paginas = (752);
            //livro1.Autor = ("C. S. Lewis");

            ////Instanciando um objeto do tipo Editora
            //Editora editora = new Editora();
            //editora.Nome = "xxxxx";
            //editora.Telefone = "19 88888-88888";

            //Editora editora1 = new Editora();
            //editora1.Nome = "HarperrCollins";
            //editora1.Telefone = "19 88888-88888";
            //livro1.Editora = editora1;
            //livro1.exibirDados();

            //Console.WriteLine("---------------------------------------------------------");


            //Livro livro2 = new Livro("As Crônicas de Nárnia - Coleção de Luxo");
            //Console.Write("Livro com construtor de 1 parâmetro: \n");
            //livro2.exibirDados();
            //Console.WriteLine("---------------------------------------------------------");

            //Livro livro3 = new Livro("As Crônicas de Nárnia - Coleção de Luxo",
            //    "Viagen ao fim do mundo, criaturas fantásticas e " +
            //   "batalhas épicas entre o bem e o mal -" +
            //  "o que mais um leitor poderia querer de um livro?", "C.S.Lewis", 100, 752);
            //Console.Write("\nLivro com construtor com todos parâmetros: \n");
            //livro3.exibirDados();
            //Console.WriteLine("---------------------------------------------------------");
        }
    }
}