using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OLD_KEY";
}

class StaticFieldsModification
{
    static void Main()
    {
        Type type = typeof(Configuration);

        FieldInfo field = type.GetField(
            "API_KEY",
            BindingFlags.NonPublic | BindingFlags.Static
        );

        field.SetValue(null, "NEW_KEY");

        object value = field.GetValue(null);
        Console.WriteLine(value);
    }
}
