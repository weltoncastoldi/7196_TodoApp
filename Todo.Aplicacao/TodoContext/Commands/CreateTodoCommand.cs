using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace Todo.Aplicacao.TodoContext.Commands
{
    public class CreateTodoCommand : Notifiable, ICommand
    {
        public CreateTodoCommand() { }
        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }
        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(Title, 3,"Title","Por favor descreva melhor está tarefa")
            );
        }
    }
}
