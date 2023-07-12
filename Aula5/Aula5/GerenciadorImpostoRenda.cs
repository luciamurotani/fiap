using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    public class GerenciadorImpostoRenda
    {
        public double Total { get; set; }

        public void adicionar(ITributavel trib)
        {
            this.Total += trib.calculaImposto();
        }
    }
}
