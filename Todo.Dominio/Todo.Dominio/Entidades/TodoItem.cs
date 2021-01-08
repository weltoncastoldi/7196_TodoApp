using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Dominio.Entidades
{
    public class TodoItem: Entidade
    {
        public TodoItem(Guid id, string title, bool done, DateTime date, string user) : base(id)
        {
            Title = title;
            Done = done;
            Date = date;
            User = user;
        }

        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }

        public void MarkAsDone()
        {
            Done = true;
        }

        public void MarkAsUnDone()
        {
            Done = true;
        }

        public void UpdateTitle(string title)
        {
            Title = title;
        }

    }
}
