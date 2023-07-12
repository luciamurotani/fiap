using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapDonationSystem.Enum
{
    public enum EComprimentoRoupa
    {
        [Description ("Acima do Joelho")]
        AcimaDoJoelho = 1,
        [Description("Abaixo do Joelho")]
        AbaixoDoJoelho =2,
        NaAlturaDoJoelho =3,
        Mini =4,
        Maxi = 5,
        Midi = 6,
        ComprimentoMedioCoxa=7,
        ComprimentoMedioDaPanturrilha=8
    }
}
