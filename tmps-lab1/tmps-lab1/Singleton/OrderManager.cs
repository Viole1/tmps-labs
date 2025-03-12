using tmps_lab1.Abstractions;

namespace tmps_lab1.Singleton;

public class OrderManager
{
    public static OrderManager Instance { get; } = new();
    private readonly List<IOrder> _orders = [];
    private readonly List<IPayment> _payments = [];

    private OrderManager() { }
    
    public void AddOrder(IOrder order) => _orders.Add(order);
    public void AddOrder(ICloneableOrder order) => _orders.Add((IOrder)order);
    public void AddPayment(IPayment payment) => _payments.Add(payment);
    public List<IOrder> Orders() => _orders;

    public void ProcessOrders()
    {
        foreach (var order in _orders)
        {
            order.ProcessOrder();
        }
    }

    public void ProcessPayments()
    {
        foreach (var payment in _payments)
        {
            payment.ProcessPayment();
        }
    }
}