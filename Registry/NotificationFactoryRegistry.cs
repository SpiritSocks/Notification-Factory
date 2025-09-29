using NotificationFactory.Factories;
using NotificationFactory.Models;

namespace NotificationFactory.Registry
{
    internal class NotificationFactoryRegistry
    {
        private static NotificationFactoryRegistry instance;
        private readonly Dictionary<string, NotificationFactory.Factories.NotificationFactory> _notificationFactories;

        private NotificationFactoryRegistry()
        {
            _notificationFactories = new Dictionary<string, NotificationFactory.Factories.NotificationFactory>
            {
                { "email", new EmailFactory() },
                { "sms", new SMSFactory() },
                { "push", new PushFactory() }
            };
        }

        public static NotificationFactoryRegistry GetInstance()
        {
            if (instance == null)
            {
                instance = new NotificationFactoryRegistry();
            }

            return instance;
        }

        public NotificationFactory.Factories.NotificationFactory GetFactory(string? type)
        {
            if (string.IsNullOrEmpty(type))
                throw new ArgumentException("Notification type cannot be null or empty.");

            type = type.ToLower();
            if (_notificationFactories.TryGetValue(type, out NotificationFactory.Factories.NotificationFactory? factory))
                return factory;

            throw new ArgumentException($"Unknown notification type: {type}");
        }

    }
}
