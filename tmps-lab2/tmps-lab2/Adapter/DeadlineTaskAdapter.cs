using tmps_lab2.Abstractions;
using tmps_lab2.Models;

namespace tmps_lab2.Adapter;

public class DeadlineTaskAdapter(DeadlineTask deadlineTask) : ITask
{
    public void Execute()
    {
        deadlineTask.Run();
    }
}