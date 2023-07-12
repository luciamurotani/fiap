using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    public struct Banco 
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public override string ToString()
        {
            return $"Banco  {this.Nome}" +

                   $" Telefone  {this.Telefone}";

        }

    }
}
