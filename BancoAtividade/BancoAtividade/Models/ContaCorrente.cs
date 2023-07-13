using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAtividade.Models
{
    public class ContaCorrente : Conta
    {
        public override void Depositar(double valor)
        {
            //base.Saldo = base.Saldo + valor;
            base.Saldo +=  valor;
        }

        public override void Sacar(double valor)
        {
            //base.Saldo = base.Saldo - valor;
            base.Saldo -= valor;
        }
    }
}
