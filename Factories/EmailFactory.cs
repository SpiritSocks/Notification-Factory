using NotificationFactory.Models;

namespace NotificationFactory.Factories
{
    internal sealed class EmailFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
