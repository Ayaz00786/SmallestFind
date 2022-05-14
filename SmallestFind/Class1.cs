using System;
using System.Collections.Generic;
using System.Text;

namespace SmallestFind
{
    internal class Class1
    {
        public static void findsmall()
        {
            Console.WriteLine("enter 1st number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter 2nd number:");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("enter 3rd number:");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("Smallest Number Is: {0}", num1);
            }
            else if (num2 < num1 && num2 < num3)
            {
                Console.WriteLine("Smallest Number Is: {0}", num2);
            }
            else
            {
                Console.WriteLine("Smallest Number Is: {0}", num3);
            }
            Console.ReadLine();
        }
    }
}
