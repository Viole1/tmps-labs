using tmps_lab1.Abstractions;
using tmps_lab1.Builder;
using tmps_lab1.Singleton;

namespace tmps_lab1.Commands;

public class CreateCustomOrderCommand : ICommand
{
    public void Execute()
    {
        var builder = new OrderBuilder();
        var order = builder.SetProduct("laptop").SetQuantity(3).Build();
        
        OrderManager.Instance.AddOrder(order);
        Console.WriteLine("Custom order created.");
    }
}