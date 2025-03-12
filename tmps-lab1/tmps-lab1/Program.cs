using tmps_lab1.Commands;

namespace tmps_lab1;

internal static class Program
{
    public static void Main(string[] args)
    {
        var menu = new CommandMenu();

        menu.RegisterCommand("1", new CreateOnlineOrderCommand());
        menu.RegisterCommand("2", new CreateOnlineOrderWithPaymentCommand());
        menu.RegisterCommand("3", new CreateStoreOrderCommand());
        menu.RegisterCommand("4", new CreateStoreOrderWithPaymentCommand());
        menu.RegisterCommand("5", new CreateCustomOrderCommand());
        menu.RegisterCommand("6", new CloneCustomOrderCommand());
        menu.RegisterCommand("7", new ShowOrdersCommand());
        menu.RegisterCommand("8", new ShowPaymentsCommand());
        menu.RegisterCommand("9", new ExitCommand());

        menu.ShowMenu();
    }
}