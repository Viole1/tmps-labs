using tmps_lab1.Abstractions;

namespace tmps_lab1.Models;

public class CloneableOrder : IOrder, ICloneableOrder
{
    public string Product { get; set; }

    public IOrder Clone() =>
        new CloneableOrder { Product = this.Product };

    public void ProcessOrder() =>
        Console.WriteLine($"Processing cloned order for product: {Product}");
}