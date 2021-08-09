using System;

namespace CSharpIntermediate
{
    public class SMSNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}