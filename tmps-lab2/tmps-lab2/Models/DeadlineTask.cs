namespace tmps_lab2.Models;

public class DeadlineTask(string description, DateTime deadline)
{
    public void Run()
    {
        Console.WriteLine($"Executing task: {description} (Deadline: {deadline})");
    }
}