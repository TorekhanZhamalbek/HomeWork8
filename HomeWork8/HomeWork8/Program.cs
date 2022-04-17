using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.WriteLine("Введите ваше имя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                count++;
            }
            if (Properties.Settings.Default.UserAge <= 0)
            {
                Console.WriteLine("Введите ваш возраст:");
                Properties.Settings.Default.UserAge = Convert.ToInt32(Console.ReadLine());
                Properties.Settings.Default.Save();
            }
            else
            {
                count++;
            }
            if (string.IsNullOrEmpty(Properties.Settings.Default.Activity))
            {
                Console.WriteLine("Введите ваш род деятельности: ");
                Properties.Settings.Default.Activity = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                count++;
            }
            if (count == 3)
            {
                string userName = Properties.Settings.Default.UserName;
                int userAge = Properties.Settings.Default.UserAge;
                string activity = Properties.Settings.Default.Activity;
                string greeting = Properties.Settings.Default.Greeting;
                Console.WriteLine($"{greeting}{userName}.\nВаш возраст: {userAge}.\nВаш род деятельности: {activity}.");
                Console.ReadLine();
            }
        }
    }
}
