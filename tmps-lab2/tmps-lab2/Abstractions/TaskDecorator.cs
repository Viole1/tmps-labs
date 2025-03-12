namespace tmps_lab2.Abstractions;

public abstract class TaskDecorator(ITask task) : ITask
{
    protected ITask _task = task;

    public virtual void Execute()
    {
        _task.Execute();
    }
}