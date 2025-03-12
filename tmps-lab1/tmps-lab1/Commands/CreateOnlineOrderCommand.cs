using tmps_lab1.Abstractions;
using tmps_lab1.FactoryMethod;
using tmps_lab1.Singleton;

namespace tmps_lab1.Commands;

public class CreateOnlineOrderCommand : ICommand
{
    public void Execute()
    {
        var factory = new OnlineOrderFactory();
        var order = factory.CreateOrder();
        
        OrderManager.Instance.AddOrder(order);
        Console.WriteLine("Online order created.");
    }
}