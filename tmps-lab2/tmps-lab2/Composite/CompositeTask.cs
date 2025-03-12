using tmps_lab2.Abstractions;

namespace tmps_lab2.Composite;

public class CompositeTask : ITask
{
    private readonly List<ITask> _tasks = [];

    public void AddTask(ITask task)
    {
        _tasks.Add(task);
    }

    public void Execute()
    {
        Console.WriteLine("Executing composite task:");
        foreach (var task in _tasks)
        {
            task.Execute();
        }
    }
}