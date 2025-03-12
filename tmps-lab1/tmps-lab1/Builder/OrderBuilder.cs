using tmps_lab1.Abstractions;
using tmps_lab1.Models;

namespace tmps_lab1.Builder;

public class OrderBuilder
{
    private string _product = string.Empty;
    private int _quantity = 1;

    public OrderBuilder SetProduct(string product)
    {
        _product = product;
        return this;
    }

    public OrderBuilder SetQuantity(int quantity)
    {
        _quantity = quantity;
        return this;
    }

    public ICloneableOrder Build() => new CustomOrder(_product, _quantity);
}