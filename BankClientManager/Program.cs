using BankClientManager;
using BankClientManager.Data;
using BankClientManager.Models;
using Microsoft.EntityFrameworkCore;

//DataCreator.CreateData();
using (ClientDbContext db = new ClientDbContext())
{
    var changes = db.Changes.Include(c => c.Client);
    foreach (Change c in changes)
    {
        Console.WriteLine($"{c.Id} {c.Client.FirstName} ");
    }
    var clients = db.Clients.Include(c => c.Changes);
    foreach (var c in clients)
    {
        Console.WriteLine(c.FirstName);
        foreach (var change in c.Changes)
        {
            Console.WriteLine($"{change.Moment} ");
        }
    }
}