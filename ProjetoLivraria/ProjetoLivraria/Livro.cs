using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria
{
    public abstract class Livro
    {
        //Definir atributos

        protected string Nome;
        protected string Resumo;
        protected double Valor;
        protected int Paginas;
        protected string Autor;
        protected Editora Editora;
    
        //construtor

        public Livro()
        {

        }

        public Livro(string nome, string resumo, string autor, double valor, int paginas, Editora editora )
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Valor = valor;
            this.Resumo = resumo;
            this.Paginas = paginas;
            this.Editora = editora;
        }


        //Definir métodos


        public virtual void exibirDados() // asinatura de um método
        {
            //definição de váriavel
            String titulo = "DETALHES DO LIVRO";
            Console.WriteLine(titulo);

            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Resumo: " + Resumo);
            Console.WriteLine("Valor: " + Valor);
            Console.WriteLine("Paginas: " + Paginas);
        }
      
        public void exibirDadosDoLivroSemEditora() // asinatura de um método
        {
            this.exibirDados();
        }


        public void exibirDadosComEditora(Boolean temEditora) 
        {
            this.exibirDados();

            if (temEditora)
            {
                Editora.exibirDados();
            }
        
        }

        public void exibirDadosComEditora()
        {
            this.exibirDados();

            if (temEditora())
            {
                Editora.exibirDados();
            }

        }


        public Boolean temEditora()
        {
            return true;
        }


     }
}
