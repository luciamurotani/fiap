
using FiapDonationSystem.Enum;
using FiapDonationSystem.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Model
{
    public class Roupa : Produto
    {
        public ECategoria Categoria { get; set; }
        public ETamanhoRoupa Tamanho { get; set; }
        public string Material { get; set; }
        public EComprimentoRoupa TipoComprimento { get; set; }

        public override string exibirDados()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.exibirDados());
            sb.Append($"\nCategoria: {Categoria} \nTamanho: {Tamanho.GetDescription()}\nComprimento Roupa: {TipoComprimento.GetDescription()}");

            return sb.ToString();
           

        }
    }
}
