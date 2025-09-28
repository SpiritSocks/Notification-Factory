namespace Notification_Factory.Models
{
    internal sealed class PushNotification : INotification
    {
        private const string Type = "PUSH";

        public PushNotification() { }
        public string GetNotificationType()
        {
            return Type;
        }

        public void Send(string message)
        {
            Console.WriteLine($"The {Type.ToLower()} notification:\n\n" +
                $"{message}\n\n" +
                $"has been sent!");
        }
    }
}
