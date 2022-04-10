using System.Collections.Generic;
using System.Linq;

namespace BankClientManager.CommandsManager
{
    class CommandsRepository
    {
        private readonly IReadOnlyDictionary<string, IBCManagerCommand> _commands;

        public CommandsRepository(IReadOnlyCollection<IBCManagerCommand> commands)
        {
            _commands = commands.ToDictionary(x => x.CommandName, x => x);
        }

        public IBCManagerCommand GetCommand(string key)
        {
            if (_commands.TryGetValue(key.ToUpper(), out IBCManagerCommand command))
            {
                return command;
            }
            return null;
        }
    }
}
