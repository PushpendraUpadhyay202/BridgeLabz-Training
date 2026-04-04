using System;
using System.Collections.Generic;
using System.Reflection;
using EventTracker.Attributes;

namespace EventTracker.Core
{
    public class AuditScanner
    {
        public Dictionary<MethodInfo, AuditTrailAttribute> Scan(Assembly assembly)
        {
            Dictionary<MethodInfo, AuditTrailAttribute> result = new Dictionary<MethodInfo, AuditTrailAttribute>();

            Type[] types = assembly.GetTypes();
            for (int i = 0; i < types.Length; i++)
            {
                MethodInfo[] methods = types[i].GetMethods();
                for (int j = 0; j < methods.Length; j++)
                {
                    object[] attrs = methods[j].GetCustomAttributes(typeof(AuditTrailAttribute), false);
                    if (attrs.Length > 0)
                    {
                        result.Add(methods[j], (AuditTrailAttribute)attrs[0]);
                    }
                }
            }

            return result;
        }
    }
}
