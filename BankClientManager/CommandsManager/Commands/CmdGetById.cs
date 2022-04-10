using BankClientManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.CommandsManager.Commands
{
    internal class CmdGetById : BCManagerCommand
    {
        public CmdGetById()
        {
            _commandName = "ID";
        }
        public override void Execute(IEmployee employee, params string[] args)
        {
            int ID;
            if (Int32.TryParse(args[1], out ID))
            {
                var client = employee.GetById(ID);
                List<Client> clients = new();
                clients.Add(client);
                Show(clients);
            }
        }
    }
}
