using System;
using System.Reflection;
using System.Text;

class Person
{
    public string Name;
    public int Age;
}

class JsonGenerator
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance
        );

        StringBuilder sb = new StringBuilder();
        sb.Append("{");

        for (int i = 0; i < fields.Length; i++)
        {
            sb.Append("\"");
            sb.Append(fields[i].Name);
            sb.Append("\":");

            object value = fields[i].GetValue(obj);

            if (value is string)
            {
                sb.Append("\"");
                sb.Append(value);
                sb.Append("\"");
            }
            else
            {
                sb.Append(value);
            }

            if (i < fields.Length - 1)
                sb.Append(",");
        }

        sb.Append("}");
        return sb.ToString();
    }
}

class JSONRepresentation
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Gaurav";
        p.Age = 22;

        string json = JsonGenerator.ToJson(p);
        Console.WriteLine(json);
    }
}
