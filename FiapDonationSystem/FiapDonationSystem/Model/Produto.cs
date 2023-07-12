using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Model
{
    public class Produto
    {
        public string nome { get; set; }
        public string descricao { get; set; }
        public string genero { get; set; }
        public string foto { get; set; }

        public bool status;

        public virtual string exibirDados()
        {
            string valorRetorno;
            valorRetorno= $"Nome: {nome} \nDescrição:  {descricao} \nGênero: {genero} \nFoto: { foto} \nStatus: {status}";
            return valorRetorno;

        }

    }
}
