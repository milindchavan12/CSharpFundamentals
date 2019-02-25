using System;

namespace ExplicitImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd Number");

            var oddnumber = new OddGenerator();

            foreach (var number in oddnumber)
            {
                if (number > 50)
                    break;

                Console.WriteLine(number);
            }
        }
    }
}
