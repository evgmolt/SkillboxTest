using BankClientManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.Models
{
    public class Consultant : Employee
    {
        private const string _passportMask = "**********";

        public Consultant(IRepository<Client> repository) : base(repository)
        {
        }

        public override IEnumerable<Client> GetAll()
        {
            var clients = _repository.GetAll();
            foreach (var client in clients)
            {
                client.Passport = _passportMask;
            }
            return clients;
        }

        public override Client GetById(int id)
        {
            Client client = _repository.GetById(id);
            client.Passport = _passportMask;
            return client;
        }

        public override Client Update(Client newClient)
        {
            Client client = _repository.GetById(newClient.Id);
            client.Phone = newClient.Phone;
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
    }
}
