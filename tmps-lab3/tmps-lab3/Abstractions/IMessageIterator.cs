namespace tmps_lab3.Abstractions;

public interface IMessageIterator
{
    public bool HasNext();
    public string Next();
}