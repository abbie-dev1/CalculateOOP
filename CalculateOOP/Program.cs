using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            //This program will perform arithmetic calculations

            int num1, num2, num3, result = 0;
            char operation;

            //Assign values 
            Console.WriteLine("Please enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the following for multiple purpose:  " +
                "\n + for addition \n - for subtraction \n * for multiplication \n / for division: ");
            operation = Convert.ToChar(Console.ReadLine());


        }
    }
}
