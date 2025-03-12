using tmps_lab2.Abstractions;

namespace tmps_lab2.Decorator;

public class TagTaskDecorator(ITask task, string tag) : TaskDecorator(task)
{
    public override void Execute()
    {
        Console.WriteLine($"Tag: {tag}");
        base.Execute();
    }
}