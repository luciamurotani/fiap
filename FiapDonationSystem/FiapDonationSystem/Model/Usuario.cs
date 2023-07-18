using FiapDonationSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Model
{
    public class Usuario : IAutenticavel
    {
        //atributos
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string apelido { get; set; }

        //métodos
        public string exibirDados()
        {
            return $"Nome:  {nome}\nTelefone: {telefone}\nE-mail: {Email}\nApelido: {apelido}";
        }

        public bool Autenticar(string username, string password)
        {
            try
            {
               if(username == null)
                {
                    throw new ArgumentNullException("Favor infomar o usuário");
                    
                }
                else
                {
                    //verificar se o usuario existe
                    return true;
                }
            }
            catch (Exception e){
                  return false;
            }
            
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
