namespace Notification_Factory.Models
{
    internal interface INotification
    {
        string GetNotificationType(); // Return the type of notification
        void Send(string message); // Output message, indicating the method
    }
}
