using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    public class Vida :  Seguro , ITributavel, IMensagem
    {
        public string TipoPlano { get; set; }

        public double calculaImposto()
        {
            return 42;
        }

        public void enviarMensagem(string mensagem)
        {
            Banco banco = new Banco();
            banco.Nome = "Aula";
            banco.Telefone = "9999-9999";
            Console.WriteLine(mensagem +  banco.ToString());
        }
    }
}
