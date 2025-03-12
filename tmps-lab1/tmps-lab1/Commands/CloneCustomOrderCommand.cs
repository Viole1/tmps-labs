using tmps_lab1.Abstractions;
using tmps_lab1.Builder;
using tmps_lab1.Singleton;

namespace tmps_lab1.Commands;

public class CloneCustomOrderCommand : ICommand
{
    public void Execute()
    {
        var build = new OrderBuilder();
        var order = build.SetProduct("laptop").SetQuantity(3).Build();
        var clone = order.Clone();
        
        OrderManager.Instance.AddOrder(clone);
        Console.WriteLine("Cloned Custom Order");
    }
}