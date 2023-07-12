using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1_Exemplo1
{
    internal class Usuario
    {
        //atributos
        public string nome;
        public string telefone;
        public string email;
        public string senha;
        public string apelido;

        //métodos
        public string exibirDados()
        {
             return "Nome: " + nome + "\nTelefone: " + telefone + "\nE-mail: " + email + "\nApelido: " + apelido;
        }

      

    }
}
