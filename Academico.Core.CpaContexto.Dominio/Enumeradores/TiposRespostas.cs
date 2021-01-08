using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico.Core.CpaContexto.Dominio.Enumeradores
{
    public enum TiposRespostas
    {
        [Display(Name = "NOTA")]
        Nota,

        [Display(Name = "MULTIPLA_ESCOLHA")]
        MultiplaEscolha,

        [Display(Name = "SIM_NAO")]
        SimNao,

        [Display(Name = "TEXTO")]
        Texto,
    }
}
