using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOOP
{
    public class Calculator
    {
        //Data members(inputs)
        public int num1 { get; set; }
        public int num2 { get; set; }

        //Construtor
        public Calculator() 
        {
            num1 = 0;
            num2 = 0;
        }

        //Overload Method
        public Calculator(int x, int y)
        {
            num1 = x;
            num2 = y;
        }

        //Calculation methods
        public int calculateSum()
        {
            return num1 + num2;
        }
        public int calculateDiff()
        {
            return num1 - num2;
        }
        public int calculateMulti()
        {
            return num1 * num2;
        }
        public int calculateDivide()
        {
            int divide = 0;
            try
            {
                divide = num1 / num2;
            }
            catch(Exception ) 
            { 
                Console.WriteLine("You cannot divide by zero");
            }
            return divide;
        }
    }
}
