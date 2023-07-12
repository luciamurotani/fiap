using FiapDonationSystem.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Model
{
    public class Calcado : Produto
    {
        public String Material { get; set; }
        public ETamanhoCalcado Tamanho { get; set; }

        public ECategoriaCalcado Categoria { get; set; }

        public ETipoAjuste TipoAjuste { get; set; }

        public void exibeDados()
        {
        
        }
    }
}
