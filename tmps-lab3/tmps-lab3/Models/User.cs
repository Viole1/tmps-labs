using tmps_lab3.Abstractions;

namespace tmps_lab3.Models;

public class User(IMessageSender messageSender)
{
    private IMessageSender _messageSender = messageSender;

    public void SetMessageSender(IMessageSender messageSender)
    {
        _messageSender = messageSender;
    }

    public void SendMessage(string message)
    {
        _messageSender.Send(message);
    }
}