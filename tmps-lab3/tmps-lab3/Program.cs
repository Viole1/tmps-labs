using tmps_lab3.ChainOfResponsibility;
using tmps_lab3.Mediator;
using tmps_lab3.Models;
using tmps_lab3.Observer;
using tmps_lab3.Strategy;

namespace tmps_lab3;

internal static class Program
{
    public static void Main(string[] args)
    {
        var textSender = new TextMessageSender();
        var fileSender = new FileMessageSender();

        var user1 = new User(textSender);
        var user2 = new User(fileSender);

        var mediator = new ChatMediator();
        mediator.Register(user1);
        mediator.Register(user2);

        var history = new ChatHistory();
        mediator.AddObserver(history);

        var spamFilter = new SpamFilter();
        var lengthFilter = new LengthFilter();
        spamFilter.SetNext(lengthFilter);

        string[] messages =
        [
            "Hello!",
            "This is a spam message",
            "This message is extremely long and should be blocked by the length filter.",
            "Short msg",
        ];

        var flag = false;
        foreach (var msg in messages)
        {
            spamFilter.Handle(msg);
            mediator.SendMessage(msg, flag ? user1 : user2);

            flag = !flag;
        }

        Console.WriteLine("\n=== Message History ===");
        var iterator = history.GetIterator();

        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }
    }
}