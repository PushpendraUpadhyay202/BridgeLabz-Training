using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role;

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class SecureService
{
    [RoleAllowed("ADMIN")]
    public void AdminTask()
    {
        Console.WriteLine("Admin task executed");
    }
}

class RoleBasedAccess
{
    static void Main()
    {
        string currentRole = "USER";

        SecureService service = new SecureService();
        Type type = typeof(SecureService);
        MethodInfo method = type.GetMethod("AdminTask");

        RoleAllowedAttribute attribute =
            (RoleAllowedAttribute)method.GetCustomAttribute(typeof(RoleAllowedAttribute));

        if (attribute != null && attribute.Role != currentRole)
        {
            Console.WriteLine("Access Denied!");
            return;
        }

        method.Invoke(service, null);
    }
}
