using BankClientManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.CommandsManager.Commands
{
    internal class CmdUpdate : BCManagerCommand
    {
        public CmdUpdate()
        {
            _commandName = "UPDATE";
        }
        public override void Execute(IEmployee employee, params string[] args)
        {
            int ID;
            if (Int32.TryParse(args[1], out ID))
            {
                Client newClient = new Client()
                {
                    Id = ID,
                    FirstName = args[2],
                    LastName = args[3],
                    Patronimyc = args[4],
                    Passport = args[5],
                    Phone = args[6],
                };
                var client = employee.Update(newClient);
                List<Client> clients = new();
                clients.Add(client);
                Show(clients);
            }
        }
    }
}
