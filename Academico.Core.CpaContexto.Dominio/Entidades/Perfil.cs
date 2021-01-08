using Academico.Core.CpaContexto.Dominio.Comum;
using System;

namespace Academico.Core.CpaContexto.Dominio.Entidades
{
    public class Perfil : EntidadeBase
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
    }
}
