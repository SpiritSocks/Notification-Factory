using Notification_Factory.Models;

namespace Notification_Factory.Factories
{
    internal sealed class SMSFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}
