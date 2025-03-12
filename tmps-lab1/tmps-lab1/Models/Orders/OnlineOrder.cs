using tmps_lab1.Abstractions;

namespace tmps_lab1.Models;

public class OnlineOrder : IOrder
{
    public void ProcessOrder() =>
        Console.WriteLine("Processing online order...");
}