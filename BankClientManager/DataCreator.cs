using BankClientManager.Data;
using BankClientManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager
{
    internal static class DataCreator
    {
        internal static void CreateData()
        {
            using (ClientDbContext db = new ClientDbContext())
            {
                Client client1 = new Client
                {
                    FirstName = "Иван",
                    LastName = "Иванов",
                    Patronimyc = "Иванович",
                    Passport = "3333222222",
                    Phone = "89275544222"
                };
                Change change1 = new Change
                {
                    Moment = DateTime.Now,
                    Changer = "Creator",
                    ChangedData = "All",
                    Type = "",
                    Client = client1
                };
                client1.Changes.Add(change1);
                Client client2 = new Client
                {
                    FirstName = "Григорий",
                    LastName = "Григорьев",
                    Patronimyc = "Григорьевич",
                    Passport = "1111777777",
                    Phone = "89271122333",
                };
                Change change2 = new Change
                {
                    Moment = DateTime.Now,
                    Changer = "Creator",
                    ChangedData = "All",
                    Type = "",
                    Client = client2
                };
                client2.Changes.Add(change2);
                db.Clients.Add(client1);
                db.Clients.Add(client2);
                db.Changes.Add(change1);
                db.Changes.Add(change2);
                db.SaveChanges();
            }
        }
    }
}
