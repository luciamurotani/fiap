using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5
{
    public class Residencia : Seguro, ITributavel
    {
        public double calculaImposto()
        {
            return 100;
        }
    }
}
