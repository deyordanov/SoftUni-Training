using _02.High_QualityMistakes;

Spy spy = new Spy();

Type type = typeof(Hacker);

string result = spy.AnalyzeAccessModifiers("_02.High_QualityMistakes.Hacker");

Console.WriteLine(result);