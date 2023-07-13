using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAtividade.Models
{
    public  abstract class Conta
    {
        public double Saldo { get; set; }

        //métodos depositar recebendo um valor do tipo double retorno void
        public abstract void Depositar(double valor);

        //métodos sacar recebendo um valor do tipo double  retorno void
        public abstract void Sacar(double valor);

        //métodos exibeSaldo que retorna um valor do tipo double
        public  double exibirSaldo()
        {
            return Saldo;
        }
        

    }
}
