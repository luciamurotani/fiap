using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Model
{
    public  class TrocaProduto
    {
        public int IdTroca { get; set; }

        public List<Produto> Produtos { get; set; }

        public string exibirDados()
        {
            return "";
        }
    }
}
