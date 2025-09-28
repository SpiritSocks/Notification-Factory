using Notification_Factory.Models;

namespace Notification_Factory.Factories
{
    internal sealed class PushFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
}
