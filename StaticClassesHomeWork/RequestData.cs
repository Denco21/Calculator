using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassesHomeWork
{
    internal class RequestData
    {
        public static string GetInput(string message)
        {
            Console.WriteLine(message);
            string output = Console.ReadLine();
            return output;
        }


        public static double GetANumberOnly(string message)
        {
            Console.WriteLine(message);
            string inputText = Console.ReadLine();
            double output;
            bool isValidNumber = double.TryParse(inputText, out output);
            while (isValidNumber == false)
            {
                Console.WriteLine("You entered invalid number");
                Console.WriteLine(message);
                inputText = Console.ReadLine();
                isValidNumber = double.TryParse(inputText, out output);
            }
            return output;
        }

        public static string OperetaionChose(string operation)
        {

            Console.WriteLine(operation);
            string inputText = Console.ReadLine();
            return inputText;
        }

        public static double PerformOperation(string operation, double a, double b)

        {
           
            double result = 0;

            if (operation == "+")
            {
                result = CalculateValues.Add(a, b);
            }
            else if (operation == "-")
            {
                result = CalculateValues.Subtract(a, b);
            }
            else if (operation == "*")
            {
                result = CalculateValues.Multiply(a, b);
            }
            else if (operation == "/" && b == 0)
            {
                Console.WriteLine("You can not divide by zero");
            }
            else if (operation == "/")

            {
                result = CalculateValues.Divide(a, b);
            }

            else
            {
                Console.WriteLine("You entered an invalid operation");
            }
            return result;

        }
    }
}

