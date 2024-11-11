using System.Reflection;
using System.Text;

namespace _02.High_QualityMistakes;

public class Spy
{
    public string StealFieldInfo(string className, string[] fieldNames)
    {
        StringBuilder sb = new StringBuilder();

        Type? type = Type.GetType(className);

        if (type == null)
        {
            throw new Exception($"The provided class name {className} does not exist.");
        }

        FieldInfo[] fields = type.GetFields(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Static |
            BindingFlags.Instance);

        object? instance = Activator.CreateInstance(type);

        if (instance == null)
        {
            throw new Exception($"An instance of the provided class {className} could not be created.");
        }

        sb.AppendLine($"Class under investigation: {className}");

        // Using a HashSet<string> for faster lookup.
        HashSet<string> fieldsToFind = new HashSet<string>(fieldNames);
        List<string> result = new List<string>(fieldsToFind);
        foreach (FieldInfo field in fields)
        {
            if (fieldsToFind.Contains(field.Name))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(instance)}");
            }
        }

        return sb.ToString().TrimEnd();
    }

    public string AnalyzeAccessModifiers(string className)
    {
        Type? type = Type.GetType(className);

        if (type == null)
        {
            throw new Exception($"The provided class name {className} does not exist.");
        }

        StringBuilder sb = new StringBuilder();

        FieldInfo[] fields = type.GetFields(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.Static);

        foreach (FieldInfo field in fields)
        {
            sb.AppendLine($"{field.Name} should be private!");
        }

        MethodInfo[] publicMethods = type.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance)
            .Where(mi => mi.Name.Contains("set"))
            .ToArray();

        MethodInfo[] privateMethods = type.GetMethods(
            BindingFlags.NonPublic |
            BindingFlags.Instance)
            .Where(mi => mi.Name.Contains("get"))
            .ToArray();

        foreach (MethodInfo method in privateMethods)
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        foreach (MethodInfo method in publicMethods)
        {
            sb.AppendLine($"{method.Name} have to be private!");
        }

        return sb.ToString().TrimEnd();
    }
}
