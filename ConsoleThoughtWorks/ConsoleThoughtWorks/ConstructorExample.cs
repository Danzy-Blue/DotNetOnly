using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleThoughtWorks
{
    public class Small
    {
        public Small(int i)
        {
            Console.WriteLine(" :: Small ::");
        }
    }

    public class Big : Small
    {
        public Big(int i):base(i)
        {
            Console.WriteLine(" :: Big ::");
        }
    }

    partial class Program
    {
        static void Main4(string[] args)
        {
            Small s1 = new Small(20);
            Small s2 = new Big(10);

            //Big b1 = new Small();
            Big b2 = new Big(10);

        }
    }
}
