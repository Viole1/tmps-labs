using tmps_lab1.Abstractions;
using tmps_lab1.Models;

namespace tmps_lab1.FactoryMethod;

public class StoreOrderFactory : OrderFactory
{
    public override IOrder CreateOrder() => new StoreOrder();
}