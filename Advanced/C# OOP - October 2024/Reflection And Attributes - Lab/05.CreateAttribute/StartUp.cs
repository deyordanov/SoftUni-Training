namespace _05.CreateAttribute;

[Author("Ventsi")]
public class StartUp
{
    [Author("Gosho")]
    public static void Main(string[] args)
    {
        // This project is the solution for both problems 05. and 06.
        var tracker = new Tracker();
        tracker.PrintMethodsByAuthor();
    }
}
