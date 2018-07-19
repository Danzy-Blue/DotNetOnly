using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleThoughtWorks
{
    static class BigEx
    {
        static int EmpNo;
        static BigEx()
        {
            EmpNo = 10;
            // perform initialization here
            Console.WriteLine($"in static Constructor, EmpNo: {EmpNo}");
        }
        public static void Add()
        {

        }
    }


    partial class Program
    {
        static void Main(string[] args)
        {
            BigEx.Add();
            Console.WriteLine("Static Class can have Static Constructor, but you can't call them directlly [CANT INSTANTIATED] i.e. = newBigEx(); is wrong");
        }
    }
}
