using BankClientManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.CommandsManager
{
    internal interface IBCManagerCommand
    {
        string CommandName { get; }
        void Execute(IEmployee employee, params string[] args);
        void Show(IEnumerable<Client> clients);
    }
}

