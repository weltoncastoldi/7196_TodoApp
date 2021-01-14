using System;
using System.Collections;
using System.Collections.Generic;
using Todo.Dominio.Entidades;

namespace Todo.Aplicacao.TodoContext.Repository
{
    public interface ITodoRepository
    {
        void Create(TodoItem todo);
        void Update(TodoItem todo);
        TodoItem GetById(Guid id, string usuario);
        IEnumerable<TodoItem> GetAll(string usuario);
        IEnumerable<TodoItem> GetAllDone(string usuario);
        IEnumerable<TodoItem> GetAllUnDone(string usuario);
        IEnumerable<TodoItem> GetByPeriod(string usuario, DateTime date, bool done);

    }
}
