using System;

namespace c_sharp_polymorphism
{
    public abstract class Notification
    {
        protected void GetUserContactInfo()
        {
            Console.WriteLine("\nNotification.GetUserContactInfo");
        }

        public abstract void NotifiyUser();

        //public virtual void NotifiyUser()
        //{
        //    Console.WriteLine("Notification.NotifiyUser");
        //}
    }
}

