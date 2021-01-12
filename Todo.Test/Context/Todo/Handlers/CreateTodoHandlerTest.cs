using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Aplicacao;
using Todo.Aplicacao.TodoContext.Commands;
using Todo.Aplicacao.TodoContext.Handlers;
using Todo.Test.Context.Todo.Repository;

namespace Todo.Test.Context.Todo.Handlers
{
    [TestClass]
    public class CreateTodoHandlerTest
    {
        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_execucao()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            var handler = new TodoHandle( new FakeTodoRepository());
            var result = (GenericCommandResult)handler.Handle(command);
            Assert.AreEqual(result.Success, false);
        }

        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            var handler = new TodoHandle(new FakeTodoRepository());
            var result = (GenericCommandResult)handler.Handle(command);
            Assert.AreEqual(result.Success, true);
        }
    }
}
