using BankClientManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.Models
{
    public interface IEmployee
    {
        public Client GetById(int id);
        public IEnumerable<Client> GetAll();
        public Client Update(Client client);
    }
}
