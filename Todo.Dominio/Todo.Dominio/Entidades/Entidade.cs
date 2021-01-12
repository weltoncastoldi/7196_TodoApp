using System;

namespace Todo.Dominio.Entidades
{
    public abstract class Entidade: IEquatable<Entidade>
    {
        // Quando uma classe a abstrada ninguém consegue instanciar ela.
        public Entidade(Guid? id)
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
