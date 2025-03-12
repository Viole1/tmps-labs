using tmps_lab1.Abstractions;

namespace tmps_lab1.Models;

public class CustomOrder(string product, int quantity) : IOrder, ICloneableOrder
{
    public void ProcessOrder() =>
        Console.WriteLine($"Processing custom order: {product}, Quantity: {quantity}");

    public IOrder Clone() =>
        new CustomOrder(product, quantity);
}