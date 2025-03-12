namespace tmps_lab1.Abstractions;

// Abstract Factory
public interface IOrderFactory
{
    IOrder CreateOrder();
    IPayment CreatePayment();
}