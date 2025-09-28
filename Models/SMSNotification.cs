namespace Notification_Factory.Models
{
    internal sealed class SMSNotification : INotification
    {
        private const string Type = "SMS";

        public SMSNotification() { }

        public string GetNotificationType()
        {
            return Type;
        }

        public void Send(string message)
        {
            Console.WriteLine($"The {Type.ToLower()}:\n\n" +
                $"{message}\n\n" +
                $"has been sent!");
        }
    }
}
