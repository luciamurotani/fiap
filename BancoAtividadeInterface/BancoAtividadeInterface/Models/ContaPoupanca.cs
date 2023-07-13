using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoAtividadeInterface.Interface;

namespace BancoAtividadeInterface.Models
{
    public class ContaPoupanca : IConta
    {
        public double Saldo { get; set; }
        public void depositar(double valor)
        {
            this.Saldo += valor;
        }
        public void sacar(double valor)
        {
            this.Saldo -= valor;
        }
        public double exibirSaldo()
        {
            return this.Saldo;
        }
    }
}
