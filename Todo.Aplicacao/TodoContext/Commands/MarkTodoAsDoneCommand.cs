using Flunt.Notifications;
using Flunt.Validations;
using System;

namespace Todo.Aplicacao.TodoContext.Commands
{
    public class MarkTodoAsDoneCommand: Notifiable, ICommand
    {
        public MarkTodoAsDoneCommand(){ }
        public MarkTodoAsDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }
        public Guid Id { get; set; }
        public string User { get; set; }
        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(User, 3, "Title", "Por favor descreva melhor está tarefa")
            );
        }
    }
}
