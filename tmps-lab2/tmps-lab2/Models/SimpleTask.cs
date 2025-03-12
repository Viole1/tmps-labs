using tmps_lab2.Abstractions;

namespace tmps_lab2.Models;

public class SimpleTask(string description) : ITask
{
    public void Execute()
    {
        Console.WriteLine($"Executing task: {description}");
    }
}