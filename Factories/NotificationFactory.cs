using Notification_Factory.Models;

namespace Notification_Factory.Factories
{
    internal abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();
    }
}
