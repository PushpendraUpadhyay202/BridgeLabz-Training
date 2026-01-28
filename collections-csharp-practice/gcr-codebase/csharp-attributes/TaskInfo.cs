using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class TaskInfoAttribute : Attribute
{
    public int Priority;
    public string AssignedTo;

    public TaskInfoAttribute(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo(1, "Alice")]
    public void DoTask()
    {
    }
}

class TaskInfo
{
    static void Main()
    {
        Type type = typeof(TaskManager);
        MethodInfo method = type.GetMethod("DoTask");
        TaskInfoAttribute attribute = (TaskInfoAttribute)method.GetCustomAttribute(typeof(TaskInfoAttribute));
        Console.WriteLine(attribute.Priority);
        Console.WriteLine(attribute.AssignedTo);
    }
}
