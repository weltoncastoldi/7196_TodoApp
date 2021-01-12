using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Aplicacao.TodoContext.Commands;

namespace Todo.Test.Context.Todo.Commands
{
    [TestClass]
    public class CreateTodoCommandTest
    {
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Tituo","Usuario",DateTime.Now);

        public CreateTodoCommandTest()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }

        [TestMethod]
        public void Dado_um_comando_invalido()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void Dado_um_comando_valido()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}
