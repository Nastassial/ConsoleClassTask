using WorkingWithStrings.Commands;
using WorkingWithStrings.OutputProviders;

namespace WorkingWithStrings;

internal class Menu
{
    public void Start(ref StringAnalyzer sa)
    {
        //var provider = new FileOutputProvider("d:/1.txt");
        var provider = new ConsoleOutputProvider();

        var commands = new List<ICommand>
        {
            new ExitCommand(),
            new MaxDigitWordsCommand(sa, provider),
            new LongestWordCount(sa, provider),
            new ReplaceNumbersCommand(sa, provider),
            new GetSentencesCommand(sa, provider),
            new SentencesWithoutCommasCommand(sa, provider),
            new FindWordsWithSameStartEndLetterCommand(sa, provider)
        };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Введите операцию");

            for (var i = 0; i < commands.Count; i++)
            {
                Console.WriteLine($"{i} => {commands[i].Description}");
            }

            var isParsed = int.TryParse(Console.ReadLine(), out var commandNumber);

            if (isParsed && commandNumber < commands.Count)
            {
                var command = commands[commandNumber];

                command.Execute();
            }
            else
            {
                Console.WriteLine($"Доступны только циферки от 0 до {commands.Count - 1}, ещё раз такую дич напишешь, я тебе винду снесу! ");
                Console.ReadLine();
            }
        }
    }
}
