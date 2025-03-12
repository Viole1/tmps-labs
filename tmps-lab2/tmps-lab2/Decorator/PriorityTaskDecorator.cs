using tmps_lab2.Abstractions;

namespace tmps_lab2.Decorator;

public class PriorityTaskDecorator(ITask task, int priority) : TaskDecorator(task)
{
    public override void Execute()
    {
        Console.WriteLine($"Priority: {priority}");
        base.Execute();
    }
}