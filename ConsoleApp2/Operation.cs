using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Operation
    {
       public static int add(int firstNumber, int secondNumber)
        {
            int add = firstNumber + secondNumber;
            
            
            Console.WriteLine("Addition of value is: {0}",add);
            Console.ReadLine();
            return add;
         
        }
        public static int multiply(int firstNumber, int secondNumber)
        {
            int multiply = firstNumber * secondNumber;
            Console.WriteLine("multiplication of value is: {0}", multiply);
            Console.ReadLine();
            return multiply;

        }
    }
}
