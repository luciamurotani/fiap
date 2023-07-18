using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoAtividadeInterface.Interface;

namespace BancoAtividadeInterface.Models
{
    public class ContaCorrente : IConta
    {
        public double Saldo { get; set; }
        private const double taxa = 0.30;

        public void depositar(double valor)
        {
            this.Saldo += valor;
        }
        public void sacar(double valor)
        {
            this.Saldo -= valor + taxa;
        }
        public double exibirSaldo()
        {
            return this.Saldo;
        }

       
    }
}
