using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level;

    public ImportantMethodAttribute()
    {
        Level = "HIGH";
    }

    public ImportantMethodAttribute(string level)
    {
        Level = level;
    }
}

class Sample
{
    [ImportantMethod]
    public void MethodA()
    {
    }

    [ImportantMethod("LOW")]
    public void MethodB()
    {
    }

    public void MethodC()
    {
    }
}

class ImportantMethod
{
    static void Main()
    {
        Type type = typeof(Sample);
        MethodInfo[] methods = type.GetMethods();

        int i = 0;
        while (i < methods.Length)
        {
            MethodInfo method = methods[i];
            ImportantMethodAttribute attribute =
                (ImportantMethodAttribute)method.GetCustomAttribute(typeof(ImportantMethodAttribute));

            if (attribute != null)
            {
                Console.WriteLine(method.Name);
                Console.WriteLine(attribute.Level);
            }

            i++;
        }
    }
}
