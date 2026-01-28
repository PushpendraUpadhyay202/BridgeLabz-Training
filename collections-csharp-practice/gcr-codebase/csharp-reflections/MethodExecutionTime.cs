using System;
using System.Reflection;
using System.Diagnostics;

class Worker
{
    public void TaskA()
    {
        for (int i = 0; i < 1000000; i++) { }
    }

    public void TaskB()
    {
        for (int i = 0; i < 2000000; i++) { }
    }
}

class MethodExecutionTime
{
    static void Main()
    {
        Worker worker = new Worker();
        Type type = typeof(Worker);

        MethodInfo[] methods = type.GetMethods(
            BindingFlags.Public |
            BindingFlags.Instance |
            BindingFlags.DeclaredOnly
        );

        for (int i = 0; i < methods.Length; i++)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            methods[i].Invoke(worker, null);

            sw.Stop();
            Console.WriteLine(methods[i].Name + " " + sw.ElapsedMilliseconds);
        }
    }
}
