using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleThoughtWorks
{
    // you can write multiple catch block for single try block
    // but you CANT write super class catch first and then derived class catch later, just uncommnet the below code
    public class ExceptionExample
    {
        public void ThrowException()
        {
            throw new DivideByZeroException();
        }

    }

    partial class Program
    {
        static void Main7(string[] args) 
        {
            ExceptionExample ex = new ExceptionExample();
            try
            {
                ex.ThrowException();
            }
            catch (Exception exx)
            {
                Console.WriteLine(exx.ToString());
            }
            //catch (DivideByZeroException exx)
            //{
            //    Console.WriteLine(exx.ToString());
            //}


            Console.ReadLine();
        }
    }
}
