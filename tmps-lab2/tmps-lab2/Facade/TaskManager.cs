using tmps_lab2.Abstractions;

namespace tmps_lab2.Facade;

public class TaskManager
{
    private readonly List<ITask> _tasks = [];

    public void AddTask(ITask task)
    {
        _tasks.Add(task);
        Console.WriteLine("Task added.");
    }

    public void ExecuteTasks()
    {
        foreach (var task in _tasks)
        {
            task.Execute();
        }
    }
}