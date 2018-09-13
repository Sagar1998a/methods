using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("please enter anumber");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The input{Number}Changed is :{ChangeSign(Number)}");
        }
        public static int ChangeSign(int Number)
        {
            return Number *-1;
        }
    }
}



