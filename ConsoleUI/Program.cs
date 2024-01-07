// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.Inmemory;

Console.WriteLine("Hello, World!");
CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var item in carManager.GetAll())
{
    Console.WriteLine(item.Description);
}