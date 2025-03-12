using tmps_lab3.Abstractions;

namespace tmps_lab3.ChainOfResponsibility;

public class SpamFilter : MessageFilter
{
    public override void Handle(string message)
    {
        if (message.Contains("spam"))
            Console.WriteLine("Message blocked: Spam detected");
        else
            base.Handle(message);
    }
}