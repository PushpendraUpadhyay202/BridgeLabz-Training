using System;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute
{
}

class Worker
{
    [LogExecutionTime]
    public void TaskA()
    {
        int i = 0;
        while (i < 1000000)
        {
            i++;
        }
    }

    [LogExecutionTime]
    public void TaskB()
    {
        int i = 0;
        while (i < 5000000)
        {
            i++;
        }
    }
}

class MethodExecutionTimeLogger
{
    static void Main()
    {
        Worker worker = new Worker();
        Type type = typeof(Worker);
        MethodInfo[] methods = type.GetMethods();

        int i = 0;
        while (i < methods.Length)
        {
            MethodInfo method = methods[i];
            LogExecutionTimeAttribute attribute =
                (LogExecutionTimeAttribute)method.GetCustomAttribute(typeof(LogExecutionTimeAttribute));

            if (attribute != null)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                method.Invoke(worker, null);
                stopwatch.Stop();
                Console.WriteLine(method.Name);
                Console.WriteLine(stopwatch.ElapsedMilliseconds);
            }

            i++;
        }
    }
}
