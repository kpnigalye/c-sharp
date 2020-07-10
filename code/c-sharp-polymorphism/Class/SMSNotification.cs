using System;

namespace c_sharp_polymorphism
{
    internal class SMSNotification : Notification
    {
        public override void NotifiyUser()
        {
            GetUserContactInfo();
            Console.WriteLine("SMS Notification\n");
        }
    }
}

