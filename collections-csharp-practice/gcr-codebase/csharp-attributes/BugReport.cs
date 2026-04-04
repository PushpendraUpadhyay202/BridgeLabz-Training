using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description;

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class TestClass
{
    [BugReport("Null reference issue")]
    [BugReport("Performance problem")]
    public void TestMethod()
    {
    }
}

class BugReport
{
    static void Main()
    {
        Type type = typeof(TestClass);
        MethodInfo method = type.GetMethod("TestMethod");
        object[] attributes = method.GetCustomAttributes(typeof(BugReportAttribute), false);

        int i = 0;
        while (i < attributes.Length)
        {
            BugReportAttribute bug = (BugReportAttribute)attributes[i];
            Console.WriteLine(bug.Description);
            i++;
        }
    }
}
