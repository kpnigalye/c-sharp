using System;

namespace c_sharp_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Notification smsNotification = new SMSNotification();
            smsNotification.NotifiyUser();

            Notification emailNotification = new EmailNotification();
            emailNotification.NotifiyUser();

            Console.ReadLine();
        }
    }


    public abstract class Notification
    {
        protected void GetUserContactInfo()
        {
            Console.WriteLine("Notification.GetUserContactInfo");
        }

        public abstract void NotifiyUser();
    }

    public class SMSNotification : Notification
    {
        public override void NotifiyUser()
        {
            GetUserContactInfo();
            Console.WriteLine("SMS Notification\n");
        }
    }

    public class EmailNotification : Notification
    {
        public override void NotifiyUser()
        {
            GetUserContactInfo();
            Console.WriteLine("Email Notification\n");
        }
    }
}

