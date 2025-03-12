using tmps_lab1.Abstractions;
using tmps_lab1.Singleton;

namespace tmps_lab1.Commands;

public class ShowPaymentsCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("=== Payments ===");
        OrderManager.Instance.ProcessPayments();
    }
}