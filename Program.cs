using Notification_Factory.Factories;
using Notification_Factory.Models;

namespace Notification_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            { 
                Console.Write("Enter the type of message you want to send (email/sms/push) or exit: ");
                string? messageType = Console.ReadLine()?.ToLower();

                if (messageType == "exit") Environment.Exit(0);

                Console.WriteLine("Enter the messsage:");
                string? content = Console.ReadLine();

                if (string.IsNullOrEmpty(content))
                {
                    throw new ArgumentException("Error, message cannot be empty");
                }

                NotificationFactory factory = messageType switch
                {
                    "email" => new EmailFactory(),
                    "sms" => new SMSFactory(),
                    "push" => new PushFactory(),
                    _ => throw new ArgumentException("Invalid message type")
                };

                INotification notification = factory.CreateNotification();
                Console.WriteLine($"\nNotification type: {notification.GetNotificationType()}");

                MakeBroder(content);
                notification.Send(content);
                MakeBroder(content);

                Console.WriteLine();
            }
        }

        static void MakeBroder(string message)
        {
            for (int i = 0; i < message.Length + 5; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
