
namespace WorkingWithStrings.Commands;

internal class ReplaceNumbersCommand : ResultCommandBase
{
    private readonly StringAnalyzer _stringAnalyzer;

    public ReplaceNumbersCommand(StringAnalyzer stringAnalyzer, IOutputProvider outputProvider) : base(outputProvider)
    {
        _stringAnalyzer = stringAnalyzer;
    }

    public override string Description => "Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».";

    public override string GetResult()
    {
        return _stringAnalyzer.ReplaceNumbers();
    }
}
