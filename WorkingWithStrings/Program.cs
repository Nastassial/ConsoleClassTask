
using WorkingWithStrings;
using WorkingWithStrings.InputProvider;

//StringAnalyzer stringAnalyzer = new (@"..\..\..\test.txt", Mode.mPath);
//StringAnalyzer stringAnalyzer = new (new ConsoleInputProvider());
StringAnalyzer stringAnalyzer = new(new FileInputProvider("../../../test.txt"));

Menu menu = new Menu();
menu.Start(ref stringAnalyzer);
