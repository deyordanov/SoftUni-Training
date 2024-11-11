using System.Reflection;
using System.Xml.Linq;

namespace _05.CreateAttribute;

public class Tracker
{
    public void PrintMethodsByAuthor()
    {
        Type type = typeof(StartUp);

        var allMethods = type.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.Static);

        foreach (var method in allMethods)
        {
            var authorAttributes = method.GetCustomAttributes(typeof(AuthorAttribute), false)
                                         .Cast<AuthorAttribute>();

            foreach (var attr in authorAttributes)
            {
                Console.WriteLine($"{method.Name} is written by {attr.Name}");
            }
        }
    }
}
