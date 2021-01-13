using System;
using Todo.Dominio.Entidades;

namespace Todo.Aplicacao.TodoContext.Repository
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);
        void Update(TodoItem todo);
        TodoItem GetById(Guid id, string usuario);
    }
}
