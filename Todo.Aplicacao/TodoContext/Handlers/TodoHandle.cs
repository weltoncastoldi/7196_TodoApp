using Flunt.Notifications;
using System;
using Todo.Aplicacao.TodoContext.Commands;
using Todo.Aplicacao.TodoContext.Repository;
using Todo.Dominio.Entidades;

namespace Todo.Aplicacao.TodoContext.Handlers
{
    public class TodoHandle: 
        Notifiable,
        IHandler<CreateTodoCommand>,
        IHandler<UpdateTodoCommand>,
        IHandler<MarkTodoAsDoneCommand>,
        IHandler<MarkTodoUnDoneCommand>
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
        public ICommandResult Handle(UpdateTodoCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "ops, algo deu errado", command.Notifications);

            var todo = _todoRepository.GetById(command.Id, command.User);

            todo.UpdateTitle(command.Title);

            _todoRepository.Update(todo);

            return new GenericCommandResult(true,"Tarefa Salva", todo);
        }
        public ICommandResult Handle(MarkTodoAsDoneCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "ops, algo deu errado", command.Notifications);

            var todo = _todoRepository.GetById(command.Id, command.User);

            todo.MarkAsDone();

            _todoRepository.Update(todo);

            return new GenericCommandResult(true,"Tarefa Salva", todo);
        }
        public ICommandResult Handle(MarkTodoUnDoneCommand command)
        {
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "ops, algo deu errado", command.Notifications);
            var todo = _todoRepository.GetById(command.Id, command.User);

            todo.MarkAsUnDone();

            _todoRepository.Update(todo);

            return new GenericCommandResult(true, "Tarefa Salva", todo);
        }
    }
}
