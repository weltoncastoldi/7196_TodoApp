using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Aplicacao.TodoContext.Repository;
using Todo.Dominio.Entidades;

namespace Todo.Test.Context.Todo.Repository
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem todo)
        {
        }

        public void Update(TodoItem todo)
        {
        }
    }
}
