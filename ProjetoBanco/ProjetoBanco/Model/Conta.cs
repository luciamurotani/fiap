using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjetoBanco.Constants;
using ProjetoBanco.Enums;

namespace ProjetoBanco.Model
{
    public abstract class Conta
    {
        //Atributos
        public int Numero { get; set; }
        public double Saldo { get; set; }
        public Agencia Agencia { get; set; }

        public ESituacao Situacao { get; set; }


        //Métodos
        public abstract void depositar();

        public double exibeSaldo()
        {
            return 1000000.00;
        }

     

    }
}
