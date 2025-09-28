using Notification_Factory.Models;

namespace Notification_Factory.Factories
{
    internal sealed class EmailFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
