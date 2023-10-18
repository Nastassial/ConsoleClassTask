
using System.Text;

namespace WorkingWithStrings.Commands;

internal class GetSentencesCommand : ResultCommandBase
{
    private readonly StringAnalyzer _stringAnalyzer;   

    public GetSentencesCommand(StringAnalyzer stringAnalyzer, IOutputProvider outputProvider) : base(outputProvider)
    {
        _stringAnalyzer = stringAnalyzer;
    }

    public override string Description => "Вывести на экран сначала вопросительные, а затем восклицательные предложения.";

    public override string GetResult()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("\nВопросительные:");
        
        foreach (var i in _stringAnalyzer.GetSentences('?'))
            sb.AppendLine(i);

        sb.AppendLine("\nВосклицательные:");

        foreach (var i in _stringAnalyzer.GetSentences('!'))
            sb.AppendLine(i);

        return sb.ToString();
    }
}
