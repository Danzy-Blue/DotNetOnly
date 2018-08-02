using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleThoughtWorks
{
    // 1. defining any method with async will NOT execute medthod asynchronously
    // 2. async just give indication that this function can contains await keyword
    // 3. async just give indication that this function can contains asynchronous code also
    // 4. code below await, actually waits to finish all the asynchronous call, here wait to finish ExecuteAsync()
    // 5. once it reaches to await code, it return its exceution to privious calling method (jahan se async void GetDate() method call hua tha i.e. in main())
    // 6. exception raise in asynchronous code can also handlled in calling block
    //      i.e. exception raised in ExecuteAsync can be catched in GetDate().


    public class AsyncAwait
    {
        public void ExecuteAsync()
        {
            Console.WriteLine(DateTime.Now.ToString() + " ExecuteAsync: before sleep");
            Thread.Sleep(10000);
            throw new DivideByZeroException();
            //Console.WriteLine(DateTime.Now.ToString() + " ExecuteAsync: after sleep");
        }

        public async void GetDate()
        {
            Console.WriteLine(DateTime.Now.ToString() + " GetDate: before Await call");

            //ExecuteAsync(); synchronous call
            //Task.Run(() => ExecuteAsync());
            try
            {
                await Task.Run(() => ExecuteAsync()); // asynchronous call using Task.Run()
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine(DateTime.Now.ToString() + " GetDate: after Await call");
        }
    }

    partial class Program
    {
        static void Main6(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString() + " Main: before GetDate() call");
            AsyncAwait obbj = new AsyncAwait();
            obbj.GetDate();
            Console.WriteLine(DateTime.Now.ToString() + " Main: after GetDate() call");
            Console.ReadLine();
        }
    }
}

