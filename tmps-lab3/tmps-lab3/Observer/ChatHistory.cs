using tmps_lab3.Abstractions;
using tmps_lab3.Iterator;

namespace tmps_lab3.Observer;

public class ChatHistory : IObserver
{
    private readonly List<string> _messages = [];

    public void Update(string message)
    {
        _messages.Add(message);
        Console.WriteLine($"New message in history: {message}");
    }

    public IMessageIterator GetIterator()
    {
        return new MessageIterator(_messages);
    }
    
    public void ShowHistory()
    {
        foreach (var message in _messages)
        {
            Console.WriteLine(message);
        }
    }
}