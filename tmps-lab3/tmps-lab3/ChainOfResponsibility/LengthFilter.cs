using tmps_lab3.Abstractions;

namespace tmps_lab3.ChainOfResponsibility;

public class LengthFilter : MessageFilter
{
    public override void Handle(string message)
    {
        if (message.Length > 30)
            Console.WriteLine("Message blocked: Too long");
        else
            base.Handle(message);
    }
}