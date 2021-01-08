using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academico.Core.CpaContexto.Dominio.Comum;
using Academico.Core.CpaContexto.Dominio.Enumeradores;

namespace Academico.Core.CpaContexto.Dominio.Entidades
{
    public class Pergunta : EntidadeBase
    {
        public Guid Id { get; set; }
        public string Enunciado { get; set; }
        public TiposRespostas TipoResposta { get; set; }
    }
}
