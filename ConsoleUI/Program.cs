
using Business.Concrete;
using DataAccess.Concrete.InMemory;

Console.WriteLine("Hello, World!");

CarManager carManager = new CarManager(new InMemoryCarDal());

foreach (var item in carManager.GetAll())
{
    Console.WriteLine(item.ModelYear);
}