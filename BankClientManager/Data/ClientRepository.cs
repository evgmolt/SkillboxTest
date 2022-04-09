using BankClientManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.Data
{
    internal class ClientRepository : IRepository<Client>
    {
        private readonly ClientDbContext _clientDbContext;
        public ClientRepository(ClientDbContext clientDbContext)
        {
            _clientDbContext = clientDbContext;
        }
        public Client Add(Client item)
        {
            _clientDbContext.Add(item);
            _clientDbContext.SaveChanges();
            return item;
        }

        public bool DeleteById(int id)
        {
            Client? client = _clientDbContext.Clients.FirstOrDefault(i => i.Id == id);
            if (client is null) return false;
            _clientDbContext.Clients.Remove(client);
            return true;
        }

        public IEnumerable<Client> GetAll()
        {
            return _clientDbContext.Clients.ToList();
        }

        public Client GetById(int id)
        {
            return _clientDbContext.Clients.Find(id);
        }

        public Client Update(Client item)
        {
            _clientDbContext.Clients.Update(item);
            return item;
        }
    }
}
