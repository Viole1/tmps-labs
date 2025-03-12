using tmps_lab1.Abstractions;
using tmps_lab1.FactoryMethod;
using tmps_lab1.Singleton;

namespace tmps_lab1.Commands;

public class CreateStoreOrderCommand : ICommand
{
    public void Execute()
    {
        var factory = new StoreOrderFactory();
        var order = factory.CreateOrder();
        
        OrderManager.Instance.AddOrder(order);
        Console.WriteLine("Store order created.");
    }
}