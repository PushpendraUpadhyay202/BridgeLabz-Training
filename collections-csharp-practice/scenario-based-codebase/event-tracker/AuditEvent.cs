using System;
using System.Text.Json;

namespace EventTracker.Models
{
    public class AuditEvent
    {
        public string EventName { get; set; }
        public string Severity { get; set; }
        public string ClassName { get; set; }
        public string MethodName { get; set; }
        public DateTime Timestamp { get; set; }
        public string UserId { get; set; }  

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
