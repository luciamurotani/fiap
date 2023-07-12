using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria
{
    public class LivroFisico : Livro
    {
        public String Capa { get; set; }

        public LivroFisico(string nome, string resumo, string autor, double valor, int paginas, Editora editora , String capa) : base ( nome,  resumo,  autor,  valor,  paginas, editora)
        {
            this.Capa = capa;
        }

        public override void exibirDados()
        {
            base.exibirDados();
            Console.WriteLine("Capa: " + Capa);

        }
    }
}
