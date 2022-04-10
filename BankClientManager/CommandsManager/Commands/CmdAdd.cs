using BankClientManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.CommandsManager.Commands
{
    internal class CmdAdd : BCManagerCommand
    {
        public CmdAdd()
        {
            _commandName = "ADD";
        }
        public override void Execute(IEmployee employee, params string[] args)
        {
            Client newClient = new Client()
            {
                FirstName = args[1],
                LastName = args[2],
                Patronimyc = args[3],
                Passport = args[4],
                Phone = args[5],
            };

            var client = employee.Add(newClient);
            List<Client> clients = new();
            clients.Add(client);
            Show(clients);
        }
    }

}
