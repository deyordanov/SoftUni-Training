using _01.Stealer;

Spy spy = new Spy();
// The 'className' should be the 'FullName' property of the Hacker class!
string result = spy.StealFieldInfo("_01.Stealer.Hacker", new string[] { "username", "password" });
Console.WriteLine(result);