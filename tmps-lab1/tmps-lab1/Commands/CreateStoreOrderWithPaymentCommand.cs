using tmps_lab1.AbstractFactory;
using tmps_lab1.Abstractions;
using tmps_lab1.Singleton;

namespace tmps_lab1.Commands;

public class CreateStoreOrderWithPaymentCommand : ICommand
{
    public void Execute()
    {
        var factory = new StoreOrderFactoryWithPayment();
        var order = factory.CreateOrder();
        var payment = factory.CreatePayment();
        
        OrderManager.Instance.AddOrder(order);
        OrderManager.Instance.AddPayment(payment);
        Console.WriteLine("Store order with payment created.");
    }
}