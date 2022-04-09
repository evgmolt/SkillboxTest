using BankClientManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.Models
{
    public abstract class Employee : IEmployee
    {
        protected readonly IRepository<Client> _repository;
        public Employee(IRepository<Client> repository)
        {
            _repository = repository;
        }
        public abstract IEnumerable<Client> GetAll();
        public abstract Client GetById(int id);
        public abstract Client Update(Client client);
    }
}
