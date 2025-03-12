using tmps_lab1.Abstractions;

namespace tmps_lab1.Models;

public class StoreOrder : IOrder
{
    public void ProcessOrder() =>
        Console.WriteLine("Processing store order...");
}