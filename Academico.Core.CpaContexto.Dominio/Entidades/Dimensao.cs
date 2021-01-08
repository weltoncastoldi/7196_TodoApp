using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Academico.Core.CpaContexto.Dominio.Comum;

namespace Academico.Core.CpaContexto.Dominio.Entidades
{
    public class Dimensao: EntidadeBase
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
