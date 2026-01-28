using System;
using System.Reflection;
using System.Collections.Generic;

class User
{
    public string Name;
    public int Age;
}

class Mapper
{
    public static T ToObject<T>(Type clazz, Dictionary<string, object> properties)
    {
        object obj = Activator.CreateInstance(clazz);
        FieldInfo[] fields = clazz.GetFields(
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance
        );

        for (int i = 0; i < fields.Length; i++)
        {
            if (properties.ContainsKey(fields[i].Name))
            {
                fields[i].SetValue(obj, properties[fields[i].Name]);
            }
        }

        return (T)obj;
    }
}

class ObjectMapper
{
    static void Main()
    {
        Dictionary<string, object> data = new Dictionary<string, object>();
        data["Name"] = "Gaurav";
        data["Age"] = 22;

        User user = Mapper.ToObject<User>(typeof(User), data);
        Console.WriteLine(user.Name);
        Console.WriteLine(user.Age);
    }
}
