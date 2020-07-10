using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_polymorphism
{
    public static class NotificationTypeFactory
    {
        public static Notification CreateNotificationType(NotificationTypeEnum notificationType)
        {
            switch (notificationType)
            {
                case NotificationTypeEnum.SMS:
                    return new SMSNotification();
                case NotificationTypeEnum.Email:
                    return new EmailNotification();
                case NotificationTypeEnum.App:
                    return new AppNotification();
                default:
                    throw new Exception();
            }
        }
    }
}
