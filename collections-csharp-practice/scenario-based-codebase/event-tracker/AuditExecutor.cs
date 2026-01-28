using System;
using System.Collections.Generic;
using System.Reflection;
using EventTracker.Models;
using EventTracker.Attributes;

namespace EventTracker.Core
{
    public class AuditExecutor
    {
        private Dictionary<MethodInfo, AuditTrailAttribute> registry;

        public AuditExecutor(Dictionary<MethodInfo, AuditTrailAttribute> registry)
        {
            this.registry = registry;
        }

        public void Execute(Action action, MethodInfo method, string userId)
        {
            action.Invoke();

            if (!registry.ContainsKey(method))
            {
                return;
            }

            AuditTrailAttribute attr = registry[method];

            AuditEvent auditEvent = new AuditEvent();
            auditEvent.EventName = attr.EventName;
            auditEvent.Severity = attr.Severity;
            auditEvent.ClassName = method.DeclaringType.Name;
            auditEvent.MethodName = method.Name;
            auditEvent.Timestamp = DateTime.UtcNow;
            auditEvent.UserId = userId;

            Console.WriteLine(auditEvent.ToJson());
        }
    }
}
