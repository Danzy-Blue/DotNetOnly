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
        private static readonly SingletonPattern obj = new SingletonPattern();
        //private static readonly object readObj = new object();
        private SingletonPattern()
        {
            Console.WriteLine($"Constructor Called");
        }

        public static SingletonPattern getSingletonObject()
        {
            //lock (readObj)
            //{
            //    if (obj == null)
            //    {
            //        obj = new SingletonPattern();
            //    }

            return obj;
            //}
        }

        public async static void callAsync()
        {
            await Task.Run(() => SingletonPattern.getSingletonObject());
        }
    }

    partial class Program
    {
        public static void Main()
        {
            // 1
            //SingletonPattern.getSingletonObject();
            //SingletonPattern.getSingletonObject();
            //SingletonPattern.getSingletonObject();

            // 2
            //Task firstTask = new Task(() =>
            //{
            //    SingletonPattern.getSingletonObject();
            //});

            //Task secondTask = new Task(() =>
            //{
            //    SingletonPattern.getSingletonObject();

            //});

            //Task thirdTask = new Task(() =>
            //{
            //    SingletonPattern.getSingletonObject();
            //});

            //firstTask.Start();
            //secondTask.Start();
            //thirdTask.Start();

            // 3
            //SingletonPattern.callAsync();
            //SingletonPattern.callAsync();
            //SingletonPattern.callAsync();

            //4
            SingletonPattern.callAsync();
            SingletonPattern.callAsync();
            SingletonPattern.callAsync();

            Console.WriteLine();
        }
    }
}
