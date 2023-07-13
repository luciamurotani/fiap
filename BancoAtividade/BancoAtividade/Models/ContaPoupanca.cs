using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAtividade.Models
{
    public class ContaPoupanca : Conta
    {
        public override void Depositar(double valor)
        {
            base.Saldo = +valor;
        }

        public override void Sacar(double valor)
        {
            base.Saldo = -valor;
        }
    }
}
