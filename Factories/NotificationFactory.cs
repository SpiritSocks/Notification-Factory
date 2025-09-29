using NotificationFactory.Models;

namespace NotificationFactory.Factories
{
    internal abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();
    }
}
