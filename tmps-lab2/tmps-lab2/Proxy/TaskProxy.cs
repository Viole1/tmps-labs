using tmps_lab2.Abstractions;
using tmps_lab2.Models;

namespace tmps_lab2.Proxy;

public class TaskProxy : ITask
{
    private SimpleTask _task;
    private readonly string _description;

    public TaskProxy(string description)
    {
        _description = description;
    }

    public void Execute()
    {
        if (_task == null)
        {
            Console.WriteLine("Loading task details...");
            _task = new SimpleTask(_description);
        }

        _task.Execute();
    }
}