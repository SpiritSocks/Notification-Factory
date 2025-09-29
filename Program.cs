using NotificationFactory.Models;
using NotificationFactory.Registry;

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

                if (messageType == "exit") break;

                Console.WriteLine("Enter the message:");
                string? content = Console.ReadLine();

                if (string.IsNullOrEmpty(content))
                {
                    Console.WriteLine("Error, message cannot be empty. Please try again.");
                    continue;
                }

                try
                {
                    NotificationFactory.Factories.NotificationFactory factory = NotificationFactoryRegistry.GetInstance().GetFactory(messageType);
                    INotification notification = factory.CreateNotification();
                    Console.WriteLine($"\nNotification type: {notification.GetNotificationType()}");

                    MakeBorder(content);
                    notification.Send(content);
                    MakeBorder(content);

                    Console.WriteLine();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}. Please enter a valid type (email/sms/push).");
                }
            }
        }

        static void MakeBorder(string message)
        {
            for (int i = 0; i < message.Length + 5; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}