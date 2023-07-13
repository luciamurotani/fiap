using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBanco.Constants;

namespace ProjetoBanco.Model
{
    public class ContaPessoaFisica : Conta
    {
        public override void depositar()
        {
            throw new NotImplementedException();
        }

        public bool verificaRestricao()
        {
            var restricao = "SIGLA_RESTRICAO";
            if (restricao.Equals(Constantes.SIGLA_RESTRICAO))
                return true;
            else
                return false;
        }
    }
}
