using tmps_lab3.Abstractions;

namespace tmps_lab3.Iterator;

public class MessageIterator(List<string> messages) : IMessageIterator
{
    private int _position = 0;

    public bool HasNext() => _position < messages.Count;

    public string Next()
    {
        if (!HasNext()) throw new InvalidOperationException();
        return messages[_position++];
    }
}