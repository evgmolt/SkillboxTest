using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.Models
{
    public class Change
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public string? ChangedData { get; set; }
        public string? Type { get; set; }
        public string? Changer { get; set; }
        public Client? Client { get; set; }
    }
}
