using System;
using System.Reflection;

class Sample
{
    public int x;
    private string y;

    public static int z;

    public Sample() { }

    private Sample(int a)
    {
        x = a;
    }

    public void Method1() { }

    private void Method2() { }
}

class ClassInformationExtraction
{
    static void Main()
    {
        string className = Console.ReadLine();
        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found");
            return;
        }

        BindingFlags flags =
            BindingFlags.Public |
            BindingFlags.NonPublic |
            BindingFlags.Instance |
            BindingFlags.Static;

        MethodInfo[] methods = type.GetMethods(flags);
        FieldInfo[] fields = type.GetFields(flags);
        ConstructorInfo[] constructors = type.GetConstructors(flags);

        for (int i = 0; i < methods.Length; i++)
            Console.WriteLine(methods[i].Name);

        for (int i = 0; i < fields.Length; i++)
            Console.WriteLine(fields[i].Name);

        for (int i = 0; i < constructors.Length; i++)
            Console.WriteLine(constructors[i].ToString());
    }
}
