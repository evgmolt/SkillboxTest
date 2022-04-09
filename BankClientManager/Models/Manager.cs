using BankClientManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.Models
{
    public class Manager : Employee
    {
        public Manager(IRepository<Client> repository) : base(repository)
        {
        }

        public override IEnumerable<Client> GetAll()
        {
            return _repository.GetAll();
        }

        public override Client GetById(int id)
        {
            return _repository.GetById(id);
        }

        public override Client Update(Client newClient)
        {
            Client client = _repository.GetById(newClient.Id);
            client.FirstName = newClient.FirstName;
            client.LastName = newClient.LastName;
            client.Patronimyc = newClient.Patronimyc;
            client.Phone = newClient.Phone;
            client.Passport = newClient.Passport;
            client.Changes.Add(new Change
            {
                Moment = DateTime.Now,
                ChangedData = "Phone",
                Type = "",
                Changer = this.GetType().ToString(),
                Client = client
            });
            _repository.Update(client);
            return client;
        }

        public Client Add(Client client)
        {
            return _repository.Add(client);
        }
    }
}
