using tmps_lab3.Abstractions;

namespace tmps_lab3.Strategy;

public class FileMessageSender : IMessageSender
{
    public void Send(string message) =>
        Console.WriteLine($"Sending file: {message}");
}