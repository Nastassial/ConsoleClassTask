using System.Text;

namespace WorkingWithStrings.InputProvider;

internal class FileInputProvider : IInputProvider
{
    private readonly string _inputFileName;

    public FileInputProvider(string inputFileName)
    {
        _inputFileName = inputFileName;
    }

    public string Read()
    {
        using (var sr = new StreamReader(_inputFileName, Encoding.UTF8))
        {
            return sr.ReadToEnd();
        }
    }
}
