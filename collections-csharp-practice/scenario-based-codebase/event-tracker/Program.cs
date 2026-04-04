using System;
using System.Reflection;
using System.Collections.Generic;
using EventTracker.Core;
using EventTracker.Attributes;
using EventTracker.Services;

class Program
{
    static void Main(string[] args)
    {
        Assembly assembly = Assembly.GetExecutingAssembly();

        AuditScanner scanner = new AuditScanner();
        Dictionary<MethodInfo, AuditTrailAttribute> registry = scanner.Scan(assembly);

        AuditExecutor executor = new AuditExecutor(registry);

        UserService service = new UserService();

        MethodInfo loginMethod = typeof(UserService).GetMethod("Login");
        MethodInfo deleteMethod = typeof(UserService).GetMethod("DeleteUser");

        executor.Execute(service.Login, loginMethod, "user-123");
        executor.Execute(service.DeleteUser, deleteMethod, "admin-999");
    }
}
