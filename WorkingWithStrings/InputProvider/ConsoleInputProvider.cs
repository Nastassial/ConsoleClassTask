namespace WorkingWithStrings.InputProvider;

internal class ConsoleInputProvider : IInputProvider
{
    public string Read() 
    {
        return Console.ReadLine() ?? "";
    }
}
