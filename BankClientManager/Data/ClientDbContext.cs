using BankClientManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankClientManager.Data
{
    public class ClientDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Change> Changes { get; set; }
        public ClientDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ClientManagerDb.db");
        }
    }
}
