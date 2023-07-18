using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAtividadeInterface.Interface
{
    public delegate void pagar(double valor);
    public interface IConta
    {
        public void sacar(double valor);
        public void depositar (double valor);
        public double exibirSaldo();

    }
}
