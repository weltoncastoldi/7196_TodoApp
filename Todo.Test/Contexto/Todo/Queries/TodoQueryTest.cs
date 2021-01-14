using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Aplicacao.TodoContext.Queries;
using Todo.Dominio.Entidades;

namespace Todo.Test.Contexto.Todo.Queries
{
    [TestClass]
    public class TodoQueryTest
    {
        private List<TodoItem> _itens;

        public TodoQueryTest()
        {
            _itens = new List<TodoItem>();
            _itens.Add(new TodoItem("Tarefa 1", DateTime.Now, "Usuario1", Guid.NewGuid()));
            _itens.Add(new TodoItem("Tarefa 2", DateTime.Now, "Usuario1", Guid.NewGuid()));
            _itens.Add(new TodoItem("Tarefa 3", DateTime.Now, "Usuario2", Guid.NewGuid()));
            _itens.Add(new TodoItem("Tarefa 4", DateTime.Now, "Usuario2", Guid.NewGuid()));
            _itens.Add(new TodoItem("Tarefa 5", DateTime.Now, "Usuario1", Guid.NewGuid()));
        }


        [TestMethod]
        public void Data_a_consulta_deve_retornar_tarefas_apenas_do_usuario_Usuario1()
        {
            var result = _itens.AsQueryable().Where(TodoQueries.GetAll("Usuario1"));
            Assert.AreEqual(3, result.Count());

        }
    }
}
