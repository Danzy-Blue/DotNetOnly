using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleThoughtWorks
{
    public class SingletonPattern
    {
        private static SingletonPattern obj;
        private SingletonPattern()
        {
            Console.WriteLine($"Constructor Called");
        }

        public static SingletonPattern getSingletonObject()
        {
            if (obj == null)
            {
                obj = new SingletonPattern();
            }

            return obj;
        }
    }

    partial class Program
    {
        public static void Main()
        {
            // 1
            SingletonPattern.getSingletonObject();
            SingletonPattern.getSingletonObject();
            SingletonPattern.getSingletonObject();

            Console.WriteLine();
        }
    }
}
