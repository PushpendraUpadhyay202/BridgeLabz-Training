using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Value;

    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

class User
{
    [MaxLength(5)]
    public string Username;

    public User(string username)
    {
        FieldInfo field = typeof(User).GetField("Username");
        MaxLengthAttribute attribute =
            (MaxLengthAttribute)field.GetCustomAttribute(typeof(MaxLengthAttribute));

        if (attribute != null && username.Length > attribute.Value)
        {
            throw new ArgumentException();
        }

        Username = username;
    }
}

class FieldLengthValidation
{
    static void Main()
    {
        User user = new User("Gaurav");
    }
}
