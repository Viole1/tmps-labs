using tmps_lab1.Abstractions;

namespace tmps_lab1.Commands;

public class CommandMenu
{
    private readonly Dictionary<string, ICommand> _commands = new();

    public void RegisterCommand(string key, ICommand command)
    {
        _commands[key] = command;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Create Online Order");
            Console.WriteLine("2. Create Online Order With Payment");
            Console.WriteLine("3. Create Store Order");
            Console.WriteLine("4. Create Store Order With Payment");
            Console.WriteLine("5. Create Custom Order");
            Console.WriteLine("6. Clone Custom Order");
            Console.WriteLine("7. Show Orders");
            Console.WriteLine("8. Show Payments");
            Console.WriteLine("9. Exit");
            Console.Write("Enter choice: ");

            var input = Console.ReadLine();
            if (_commands.TryGetValue(input ?? "", out var command))
            {
                command.Execute();
            }
            else
            {
                Console.WriteLine("Invalid command. Try again.");
            }
        }
    }
}