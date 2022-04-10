using BankClientManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.CommandsManager.Commands
{
    internal class CmdGetAll : BCManagerCommand
    {
        public CmdGetAll()
        {
            _commandName = "ALL";
        }
        public override void Execute(IEmployee employee, params string[] args)
        {
            var clients = employee.GetAll();
            Show(clients);
        }
    }
}
