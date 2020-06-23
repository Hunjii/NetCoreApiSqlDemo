using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChange();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void createCommand(Command cmd); 
    }
    
}