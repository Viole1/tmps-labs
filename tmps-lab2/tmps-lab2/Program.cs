using tmps_lab2.Adapter;
using tmps_lab2.Composite;
using tmps_lab2.Decorator;
using tmps_lab2.Facade;
using tmps_lab2.Models;
using tmps_lab2.Proxy;

namespace tmps_lab2;

internal static class Program
{
    public static void Main(string[] args)
    {
        var manager = new TaskManager();

        // Simple task
        var simpleTask = new SimpleTask("Write report");
        manager.AddTask(simpleTask);

        // Adapter
        var deadlineTask = new DeadlineTaskAdapter(new DeadlineTask("Submit project", DateTime.Now.AddDays(3)));
        manager.AddTask(deadlineTask);

        // Decorator
        var decoratedTask = new PriorityTaskDecorator(new TagTaskDecorator(simpleTask, "Work"), 1);
        manager.AddTask(decoratedTask);

        // Composite
        var project = new CompositeTask();
        project.AddTask(new SimpleTask("Fix bug"));
        project.AddTask(new SimpleTask("Refactor code"));
        manager.AddTask(project);

        // Proxy
        var proxyTask = new TaskProxy("Load data");
        manager.AddTask(proxyTask);

        Console.WriteLine("\n=== Executing All Tasks ===");
        manager.ExecuteTasks();
    }
}