using System;
using System.Reflection;

class Calculator
{
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

class PrivateMethodInvocation
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        Type type = typeof(Calculator);

        MethodInfo method = type.GetMethod(
            "Multiply",
            BindingFlags.NonPublic | BindingFlags.Instance
        );

        object[] args = new object[2];
        args[0] = 6;
        args[1] = 7;

        object result = method.Invoke(calculator, args);
        Console.WriteLine(result);
    }
}
