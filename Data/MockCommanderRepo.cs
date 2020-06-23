using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void createCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
           return new List<Command> {
               new Command { Id = 0, HowTo = "Howto1", Line = "Line1", Platform = "Platform1"},
               new Command { Id = 1, HowTo = "Howto2", Line = "Line2", Platform = "Platform2"},
               new Command { Id = 2, HowTo = "Howto3", Line = "Line2", Platform = "Platform3"}
           };
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id = 0, HowTo = "Howto1", Line = "Line1", Platform = "Platform1"};
        }

        public bool SaveChange()
        {
            throw new System.NotImplementedException();
        }
    }
}