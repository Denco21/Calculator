using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesHomeWork
{
     public class UserMessages
    {
        public static void WelcomeMessage(string firstName)
        {
          
            int timeOfDay = DateTime.Now.Hour;

            if (timeOfDay < 12)
            {
                Console.WriteLine($"God Morning {firstName}, Welcome to our Application");
            }
            else if (timeOfDay < 19)
            {
                Console.WriteLine($"God afternoon {firstName}, Welcome to our Application");
            }
            else
            {
                Console.WriteLine($"God evening {firstName},Welcome to our Application");
            }
        }

        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
            Console.WriteLine();

            Console.WriteLine("Thank you for using our application for your calculation");

        }
    }

    

}
