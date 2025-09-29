using NotificationFactory.Models;

namespace NotificationFactory.Factories
{
    internal sealed class PushFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }
    }
}
