using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico.Core.CpaContexto.Dominio.Comum
{
    public class EntidadeBase
    {
        public string CriadoPor { get; set; }
        public DateTime CriadoEm { get; set; }
        public string ModificadoPor { get; set; }
        public DateTime? ModificadoEm { get; set; }
    }
}
