using System;

namespace c_sharp_polymorphism
{
    internal class EmailNotification : Notification
    {
        public override void NotifiyUser()
        {
            GetUserContactInfo();
            Console.WriteLine("Email Notification\n");
        }
    }
}

