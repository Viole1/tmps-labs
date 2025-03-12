namespace tmps_lab3.Abstractions;

public abstract class MessageFilter
{
    protected MessageFilter? _next;

    public void SetNext(MessageFilter next)
    {
        _next = next;
    }

    public virtual void Handle(string message)
    {
        _next?.Handle(message);
    }
}