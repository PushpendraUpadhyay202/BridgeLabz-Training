using System;

namespace EventTracker.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AuditTrailAttribute : Attribute
    {
        public string EventName;
        public string Severity;

        public AuditTrailAttribute(string eventName, string severity)
        {
            EventName = eventName;
            Severity = severity;
        }
    }
}
