using tmps_lab1.Abstractions;
using tmps_lab1.Models;
using tmps_lab1.Models.Payments;

namespace tmps_lab1.AbstractFactory;

public class StoreOrderFactoryWithPayment : IOrderFactory
{
    public IOrder CreateOrder() => new StoreOrder();
    public IPayment CreatePayment() => new CreditCardPayment();
}