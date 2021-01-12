using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Aplicacao
{
    //Toda handle exige que seja command
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
