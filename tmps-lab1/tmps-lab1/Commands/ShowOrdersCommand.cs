using tmps_lab1.Abstractions;
using tmps_lab1.Singleton;

namespace tmps_lab1.Commands;

public class ShowOrdersCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("=== Orders ===");
        OrderManager.Instance.ProcessOrders();
    }
}