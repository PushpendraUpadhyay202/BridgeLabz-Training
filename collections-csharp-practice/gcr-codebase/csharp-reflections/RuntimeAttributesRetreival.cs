using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name;

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("Mark")]
class Book
{
}

class RuntimeAttributesRetreival
{
    static void Main()
    {
        Type type = typeof(Book);
        object[] attrs = type.GetCustomAttributes(typeof(AuthorAttribute), false);

        if (attrs.Length == 0)
            return;

        AuthorAttribute author = (AuthorAttribute)attrs[0];
        Console.WriteLine(author.Name);
    }
}
