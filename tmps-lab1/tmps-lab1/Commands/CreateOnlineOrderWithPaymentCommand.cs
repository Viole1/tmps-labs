using tmps_lab1.AbstractFactory;
using tmps_lab1.Abstractions;
using tmps_lab1.Singleton;

namespace tmps_lab1.Commands;

public class CreateOnlineOrderWithPaymentCommand : ICommand
{
    public void Execute()
    {
        var factory = new OnlineOrderFactoryWithPayment();
        var order = factory.CreateOrder();
        var payment = factory.CreatePayment();
        
        OrderManager.Instance.AddOrder(order);
        OrderManager.Instance.AddPayment(payment);
        Console.WriteLine("Online order with payment created.");
    }
}