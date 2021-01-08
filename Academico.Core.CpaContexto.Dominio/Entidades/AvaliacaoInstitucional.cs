﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Academico.Core.CpaContexto.Dominio.Comum;

namespace Academico.Core.CpaContexto.Dominio.Entidades
{
    public class AvaliacaoInstitucional : EntidadeBase
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string InstrucaoEntrevistado { get; set; }

    }
}
