using System;

namespace c_sharp_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = -1;

            Console.WriteLine(@"Choose type of notification:
            Press 1 for 'SMS'
            Press 2 for 'Email'
            Press 3 for 'App'
            -------------------
            Press 0 to Exit");
            Console.WriteLine();

            while (userChoice != 0)
            {
                Console.Write("Enter your Choice: ");
                try
                {
                    userChoice = Convert.ToInt32(Console.ReadLine());
                    if (userChoice == 0)
                        break;

                    Console.WriteLine("----------------------");

                    Notification notification = NotificationTypeFactory.CreateNotificationType((NotificationTypeEnum)userChoice);

                    if (notification != null)
                        notification.NotifiyUser();
                    else
                        throw new Exception();
                }
                catch
                {
                    Console.WriteLine("Invalid Choice\n");
                }
            }
        }
    }
}

