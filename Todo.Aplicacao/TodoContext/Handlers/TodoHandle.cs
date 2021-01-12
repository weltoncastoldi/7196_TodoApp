using Flunt.Notifications;
using System;
using Todo.Aplicacao.TodoContext.Commands;
using Todo.Aplicacao.TodoContext.Repository;
using Todo.Dominio.Entidades;

namespace Todo.Aplicacao.TodoContext.Handlers
{
    public class TodoHandle: 
        Notifiable,
        IHandler<CreateTodoCommand>
    {
        private readonly ITodoRepository _todoRepository;
        public TodoHandle(ITodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public ICommandResult Handle(CreateTodoCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "ops, algo deu errado", command.Notifications);

            var todo = new TodoItem(command.Title, command.Date, command.User, Guid.NewGuid());

            _todoRepository.Create(todo);

            return new GenericCommandResult(true, "Tarefa salva", todo);
        }
    }
}
