namespace NotificationFactory.Models
{
    internal sealed class EmailNotification : INotification
    {
        private const string Type = "EMAIL";

        public EmailNotification() { }

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
