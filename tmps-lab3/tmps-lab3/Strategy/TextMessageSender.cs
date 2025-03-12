using tmps_lab3.Abstractions;

namespace tmps_lab3.Strategy;

public class TextMessageSender : IMessageSender
{
    public void Send(string message) =>
        Console.WriteLine($"Text message: {message}");
}