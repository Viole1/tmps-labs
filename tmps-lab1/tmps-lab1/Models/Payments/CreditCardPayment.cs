using tmps_lab1.Abstractions;

namespace tmps_lab1.Models.Payments;

public class CreditCardPayment : IPayment
{
    public void ProcessPayment() =>
        Console.WriteLine("Processing credit card payment...");
 }