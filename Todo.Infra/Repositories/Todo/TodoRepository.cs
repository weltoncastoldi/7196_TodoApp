using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Todo.Aplicacao.TodoContext.Queries;
using Todo.Aplicacao.TodoContext.Repository;
using Todo.Dominio.Entidades;
using Todo.Infra.Data.Contexts;

namespace Todo.Infra.Data.Repositories.Todo
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DataContext _dataContext;

        public TodoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public void Create(TodoItem todo)
        {
            _dataContext.Todos.Add(todo);
            _dataContext.SaveChanges();
        }

        public void Update(TodoItem todo)
        {
            _dataContext.Entry(todo).State = EntityState.Modified;
            _dataContext.SaveChanges();
        }

        public TodoItem GetById(Guid id, string usuario)
        {
            return _dataContext.Todos
                .AsNoTracking()
                .Where(TodoQueries.GetAll(usuario))
                .OrderBy(x => x.Date);
        }

        public IEnumerable<TodoItem> GetAll(string usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllDone(string usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllUnDone(string usuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetByPeriod(string usuario, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }
    }
}
