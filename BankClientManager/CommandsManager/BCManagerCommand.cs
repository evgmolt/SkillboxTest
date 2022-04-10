using BankClientManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.CommandsManager
{
    internal abstract class BCManagerCommand : IBCManagerCommand
    {
        protected string _commandName;

        public string CommandName { get => _commandName; }

        public abstract void Execute(IEmployee employee, params string[] args);

        public void Show(IEnumerable<Client> clients)
        {
            if (clients.ToArray()[0] is null)
            {
                Console.WriteLine("You do not have premission for this operation");
                return;
            }
            foreach (var c in clients)
            {
                Console.WriteLine($"{c.FirstName} {c.LastName} {c.Patronimyc} {c.Passport} {c.Phone}");
            }
        }
    }
}
