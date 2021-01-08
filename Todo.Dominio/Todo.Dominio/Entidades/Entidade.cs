using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Dominio.Entidades
{
    public abstract class Entidade: IEquatable<Entidade>
    {
        // Quando uma classe a abstrada ninguém consegue instanciar ela.
        protected Entidade(Guid id)
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public bool Equals(Entidade? other)
        {
            return Id == other.Id;
        }
    }
}
