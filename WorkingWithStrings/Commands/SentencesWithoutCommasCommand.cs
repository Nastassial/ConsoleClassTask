using System.Text;

namespace WorkingWithStrings.Commands;

internal class SentencesWithoutCommasCommand : ResultCommandBase
{
    private readonly StringAnalyzer _stringAnalyzer;

    public SentencesWithoutCommasCommand(StringAnalyzer stringAnalyzer, IOutputProvider outputProvider) : base(outputProvider)
    {
        _stringAnalyzer = stringAnalyzer;
    }

    public override string Description => "Вывести на экран только предложения, не содержащие запятых.";

    public override string GetResult()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var i in _stringAnalyzer.SentencesWithoutCommas())
            sb.Append(i);

        return sb.ToString();
    }
}
