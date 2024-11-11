namespace _05.CreateAttribute;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
public class AuthorAttribute : Attribute
{
    public AuthorAttribute(string name)
        => this.Name = name;

    public string Name { get; set; }
}
