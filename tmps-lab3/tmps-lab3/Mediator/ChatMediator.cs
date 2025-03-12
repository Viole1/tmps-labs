using tmps_lab3.Abstractions;
using tmps_lab3.Models;

namespace tmps_lab3.Mediator;

public class ChatMediator
{
    private readonly List<User> _users = new();
    private readonly List<IObserver> _observers = new();

    public void Register(User user)
    {
        _users.Add(user);
    }

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void SendMessage(string message, User sender)
    {
        foreach (var user in _users.Where(user => user != sender))
        {
            user.SendMessage(message);
        }

        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}