using System;
using System.Reflection;

public class ApiScanner
{
    public void Scan()
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        Type[] allTypes = assembly.GetTypes();

        foreach(Type type in allTypes)
        {
            object controllerAttr = type.GetCustomAttribute(typeof(ControllerAttribute));

            if(controllerAttr == null)
            {
                continue;
            }

            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);

            Console.WriteLine($"\nController: {type.Name}");
            Console.WriteLine("------------------------");
            foreach(MethodInfo method in methods)
            {
                object publicApiAttr = method.GetCustomAttribute(typeof(PublicAPIAttribute));
                object requiresAuthAttr = method.GetCustomAttribute(typeof(RequiresAuthAttribute));

                bool isPublic = publicApiAttr != null;
                bool isAuthRequired = requiresAuthAttr != null;

                string accessType;
                if (isPublic)
                {
                    accessType = "Public";
                }
                else if (isAuthRequired)
                {
                    accessType = "RequiresAuth";
                }
                else
                {
                    accessType = "INVALID";
                }
                string returnType = method.ReturnType.Name;

                Console.WriteLine($"{method.Name,-20} | {accessType,-13} | {returnType}");

                if(isPublic && isAuthRequired)
                {
                    Console.WriteLine($"\nError: {type.Name}.{method.Name}");
                    Console.WriteLine("REASON: API method must declare exactly one of [PublicAPI] or [RequiresAuth]");
                }
                else if(!isPublic && !isAuthRequired)
                {
                    Console.WriteLine($"\nError: {type.Name}.{method.Name}");
                    Console.WriteLine("REASON: API method must declare one of [PublicAPI] or [RequiresAuth]");
                }
            }
        }
    }
}