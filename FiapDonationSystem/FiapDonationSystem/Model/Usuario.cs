using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Model
{
    public class Usuario
    {
        //atributos
        public string nome;
        public string telefone;
        public string email { get; set; }
        public string senha;
        public string apelido;

        //métodos
        public string exibirDados()
        {
            return $"Nome:  {nome}\nTelefone: {telefone}\nE-mail: {Email}\nApelido: {apelido}";
        }



        public string Email
        {
            get { return email; }
            set
            {
                if (!email.Equals(""))
                {
                    email = value;
                }

            }
        }
    }
}
