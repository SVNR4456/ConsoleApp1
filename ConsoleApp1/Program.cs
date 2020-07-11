using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write("TEST");
            Console.Read();

            var test = if(1 <= 3 ) ? Console.WriteLine("wrong") : Console.WriteLine("Correct");
            Console.Read();
        }
    }
}
