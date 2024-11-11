using _03.MissionPrivateImpossible;

Type type = typeof(Hacker);

Spy spy = new Spy();

string result = spy.RevealPrivateMethods("_03.MissionPrivateImpossible.Hacker");

Console.WriteLine(result);