using tmps_lab1.Abstractions;

namespace tmps_lab1.Commands;

public class ExitCommand : ICommand
{
    public void Execute()
    {
        Console.WriteLine("Exiting...");
        Environment.Exit(0);
    }
}