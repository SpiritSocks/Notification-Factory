using NotificationFactory.Models;

namespace NotificationFactory.Factories
{
    internal sealed class SMSFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SMSNotification();
        }
    }
}
