using FiapDonationSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiapDonationSystem.Data;
namespace FiapDonationSystem.Model
{
    public class Transacao
    {
       

        public int IdTransacao { get; set; }
        public DateTime DataReserva { get; set; }

        public DateTime DataTroca { get; set; }

        public DateTime DataCancelamento { get; set; }  
        public string MotivoCancelamento { get; set; }

        public DateTime DisponivelAte { get; set; }

        public Produto Produto { get; set; }    

        public Usuario Usuario { get; set; }

        public string exibirDados()
        {
            return "";

        }

        private Repository<Produto> repository_produtos;

        private Repository<Usuario> repository_usuarios;

        public void AdicionaProdutos(Produto produto)
        {
            repository_produtos.Add(produto);
        }

        public void AdicionaUsuarios(Usuario usuario)
        {
            repository_usuarios.Add(usuario);
        }


    }
}
