using EventTracker.Attributes;

namespace EventTracker.Services
{
    public class UserService
    {
        [AuditTrail("UserLogin", "Info")]
        public void Login()
        {
        }

        [AuditTrail("UserDelete", "Critical")]
        public void DeleteUser()
        {
        }
    }
}
