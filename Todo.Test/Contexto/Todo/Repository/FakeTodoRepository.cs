using System;
using Todo.Aplicacao.TodoContext.Repository;
using Todo.Dominio.Entidades;

namespace Todo.Test.Contexto.Todo.Repository
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {
        }

        public void Update(TodoItem todo)
        {
        }

        public TodoItem GetById(Guid id, string usuario)
        {
            return new TodoItem("Titulo",DateTime.Now, "Usuario", Guid.Empty);
        }
    }
}
