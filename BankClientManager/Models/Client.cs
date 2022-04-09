using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.Models
{
    public class Client
    {
        public int Id { get; set; } 
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronimyc { get; set; }
        public string? Phone { get; set; }
        public string? Passport { get; set; }
        public List<Change> Changes { get; set; }
        public Client()
        {
            Changes = new List<Change>();
        }
    }
}
