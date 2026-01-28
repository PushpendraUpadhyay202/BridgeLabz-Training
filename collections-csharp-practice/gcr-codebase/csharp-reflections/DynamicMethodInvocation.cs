using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class DynamicMethodInvocation
{
    static void Main()
    {
        MathOperations obj = new MathOperations();
        Type type = typeof(MathOperations);

        string methodName = Console.ReadLine();
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine("Method not found");
            return;
        }

        object[] args = new object[2];
        args[0] = a;
        args[1] = b;

        object result = method.Invoke(obj, args);
        Console.WriteLine(result);
    }
}
