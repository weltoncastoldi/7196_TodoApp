using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Aplicacao;
using Todo.Aplicacao.TodoContext.Commands;
using Todo.Aplicacao.TodoContext.Handlers;
using Todo.Test.Contexto.Todo.Repository;

namespace Todo.Test.Contexto.Todo.Handlers
{
    [TestClass]
    public class CreateTodoHandlerTest
    {

        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("","",DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titulo", "Usuario", DateTime.Now);
        private readonly TodoHandle _handle = new TodoHandle(new FakeTodoRepository());

        public CreateTodoHandlerTest() { }

        [TestMethod]
        public void Dado_um_comando_invalido_deve_interromper_execucao()
        {
            var result = (GenericCommandResult)_handle.Handle(_invalidCommand);
            Assert.AreEqual(result.Success, false);
        }
        
        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            var result = (GenericCommandResult)_handle.Handle(_validCommand);
            Assert.AreEqual(result.Success, true);
        }
    }
}
