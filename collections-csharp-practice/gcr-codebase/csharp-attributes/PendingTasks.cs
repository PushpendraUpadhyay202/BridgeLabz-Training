using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task;
    public string AssignedTo;
    public string Priority;

    public TodoAttribute(string task, string assignedTo)
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = "MEDIUM";
    }

    public TodoAttribute(string task, string assignedTo, string priority)
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Add validation", "Alice")]
    [Todo("Improve performance", "Bob", "HIGH")]
    public void FeatureA()
    {
    }

    [Todo("Write tests", "Charlie")]
    public void FeatureB()
    {
    }
}

class PendingTasks
{
    static void Main()
    {
        Type type = typeof(Project);
        MethodInfo[] methods = type.GetMethods();

        int i = 0;
        while (i < methods.Length)
        {
            MethodInfo method = methods[i];
            object[] attributes = method.GetCustomAttributes(typeof(TodoAttribute), false);

            int j = 0;
            while (j < attributes.Length)
            {
                TodoAttribute todo = (TodoAttribute)attributes[j];
                Console.WriteLine(method.Name);
                Console.WriteLine(todo.Task);
                Console.WriteLine(todo.AssignedTo);
                Console.WriteLine(todo.Priority);
                j++;
            }

            i++;
        }
    }
}
