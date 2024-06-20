using System.ComponentModel.Design;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Red;

            int number1;
            int number2;

            int result;
            string answer;

            Console.WriteLine("Welcome to the Calculator!");
            Console.WriteLine("Please enter your first number");

            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now enter your second number.");

            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Would you like to subtract, divide, multiply, or add?");
            Console.WriteLine("To add, press A. To subtract, press S. To divide, press D. To multiply, press M");


            answer = Console.ReadLine();


            if (answer == "A") 
            {
                result = number1 + number2;
            }
            else if (answer == "S")
            {
                  result = number1 - number2;
            }
            else if (answer == "M") 
            { 
                 result = number1 * number2;
            }
            else
            {
                result = number1 / number2;
            }


            Console.WriteLine($"the result is {result}");

        }
    }
}