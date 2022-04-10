using BankClientManager;
using BankClientManager.CommandsManager;
using BankClientManager.CommandsManager.Commands;
using BankClientManager.Data;
using BankClientManager.Models;
using Microsoft.EntityFrameworkCore;
using Ninject;

//DataCreator.CreateData();

IKernel kernel = new StandardKernel();
kernel.Bind<IBCManagerCommand>().To<CmdGetAll>().InSingletonScope();
kernel.Bind<IBCManagerCommand>().To<CmdGetById>().InSingletonScope();
kernel.Bind<IBCManagerCommand>().To<CmdUpdate>().InSingletonScope();
kernel.Bind<IBCManagerCommand>().To<CmdAdd>().InSingletonScope();
CommandsRepository commands = new CommandsRepository(kernel.Get<List<IBCManagerCommand>>());

ConsoleKeyInfo ki;
do
{
    Console.Clear();
    Console.Write("Press 'C' to create Consultant or 'M' to create Manager: ");
    ki = Console.ReadKey();
}
while (ki.Key != ConsoleKey.M && ki.Key != ConsoleKey.C);
Console.WriteLine();
Console.WriteLine("ALL - view all clients");
Console.WriteLine("ID 2 - view client with ID 2");
Console.WriteLine("UPDATE 2 FirstName LastName Patronimyc Passport Phone - update client with ID 2");
Console.WriteLine("ADD FirstName LastName Patronimyc Passport Phone - add new client");

using (ClientDbContext db = new ClientDbContext())
{
    ClientRepository Repository = new ClientRepository(db);
    IEmployee CurrentEmployee;
    if (ki.Key == ConsoleKey.M)
    {
        CurrentEmployee = new Manager(Repository);
    }
    else 
    {
        CurrentEmployee = new Consultant(Repository);
    }

    do
    {
        string enterStr = Console.ReadLine();
        var enters = enterStr.Split(' ').Select(s => s.Trim()).Where(s => s != "").ToArray();
        if (enters == null || enters.Length == 0)
        {
            continue;
        }
        IBCManagerCommand cmd = commands.GetCommand(enters[0]);
        if (cmd != null)
        {
            cmd.Execute(CurrentEmployee, enters);
        }
    }
    while (true);
}