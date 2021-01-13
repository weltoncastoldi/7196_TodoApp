using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Dominio.Entidades;

namespace Todo.Test.Contexto.Todo.Entities
{
    [TestClass]
    public class TodoItemTest
    {
        private readonly TodoItem _todoItem = new TodoItem("NomeCliente", DateTime.Now, "Usario", Guid.NewGuid());

        [TestMethod]
        public void Dado_um_novo_todo_o_mesmo_nao_pode_iniciar_como_concluido()
        {
            Assert.AreEqual(_todoItem.Done, false);
        }
    }
}
