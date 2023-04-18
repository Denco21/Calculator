using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = RequestData.GetInput("Please enter your name: ");
            UserMessages.WelcomeMessage(firstName);
            
            double a = RequestData.GetANumberOnly("Enter your first number: ");
            double b =RequestData.GetANumberOnly("Enter your second number: ");
             string operation = RequestData.OperetaionChose("Choose the operation (+,-,*,/): ");
            double result = RequestData.PerformOperation(operation, a, b);
            


            
            UserMessages.DisplayMessage($"The result of {a} {operation} {b} is {result}");

            Console.ReadLine();
        }
    }
}
