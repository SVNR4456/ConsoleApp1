using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

#if true
            Console.WriteLine("Enter the second Number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            

#endif



            Console.WriteLine("Enter the Operation");
            string oper = Console.ReadLine();
            var x = (oper == "add") ? (Operation.add(firstNumber, secondNumber)) : (Operation.multiply(firstNumber, secondNumber));
            int Sum = 0;
            for (int counter = 0; counter < 10; counter++)
            {
                 
                   Sum = Sum + counter;
                if (counter % 2 == 0)
                {
                    Console.WriteLine("The counter is : {0}", counter);
                    Console.ReadLine();
                }
            }
            Console.WriteLine("The sum of couners is : {0}", Sum);
            Console.ReadLine();

        }
    }
}
