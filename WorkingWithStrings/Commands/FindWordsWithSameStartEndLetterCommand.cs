
using System.Text;

namespace WorkingWithStrings.Commands;

internal class FindWordsWithSameStartEndLetterCommand : ResultCommandBase
{
    private readonly StringAnalyzer _stringAnalyzer;

    public FindWordsWithSameStartEndLetterCommand(StringAnalyzer stringAnalyzer, IOutputProvider outputProvider) : base(outputProvider)
    {
        _stringAnalyzer = stringAnalyzer;
    }

    public override string Description => "Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.";

    public override string GetResult()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var i in _stringAnalyzer.FindWordsWithSameStartEndLetter())
            sb.Append(i);

        return sb.ToString();
    }
}
