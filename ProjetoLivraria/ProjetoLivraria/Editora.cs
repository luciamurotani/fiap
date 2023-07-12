using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivraria { 

    public class Editora
    {
        public string Nome { get; set; }
        public string Site { get; set; }
        public string Telefone { get; set; }

        public Editora()
        {
         
        }

        public Editora(string nome, string site, string telefone)
        {
            this.Nome = nome;
            this.Site = site;
            this.Telefone = telefone;
        }

        public void exibirDados()
        {
            Console.WriteLine("Editora: " + Nome);
      
        }

    }
}
