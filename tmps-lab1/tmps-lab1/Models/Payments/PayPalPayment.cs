using tmps_lab1.Abstractions;

namespace tmps_lab1.Models.Payments;

public class PayPalPayment : IPayment
{
    public void ProcessPayment() =>
        Console.WriteLine("Processing PayPal payment...");
}