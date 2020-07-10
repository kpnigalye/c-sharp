using System;

namespace c_sharp_polymorphism
{
    internal class AppNotification : Notification
    {
        public override void NotifiyUser()
        {
            GetUserContactInfo();
            Console.WriteLine("App Notification\n");
        }
    }
}

