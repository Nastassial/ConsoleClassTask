namespace ConsoleClassTask2.Classes;

internal class CurePlan
{
    private string _description;

    public string Description { get => _description; }

    public CurePlan(string description)
    {
        _description = description;
    }
}
