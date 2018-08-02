using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;

namespace ConsoleThoughtWorks
{
    public class EventsDelegates
    {
        // Declaration
        public delegate void SimpleDelegate(string name);

        // The use of the delegate is just like calling a function directly,
        // though we need to add a check to see if the delegate is null
        // (that is, not pointing to a function) before calling the function.
        public static void MyStaticFunc(string name)
        {
            Console.WriteLine($"I was called by STATIC delegate ..." + name);
        }

        public void MyNonStaticFunc(string name)
        {
            Console.WriteLine($"I was called by NON STATIC delegate ..." + name);
        }
    }

    partial class Program
    {
        public static void Main()
        {
            EventsDelegates.SimpleDelegate delegateObj = new EventsDelegates.SimpleDelegate(EventsDelegates.MyStaticFunc);
            delegateObj("~~Static~~");
            delegateObj.BeginInvoke("Hello Danzy", null, null);  // not supported in .NetCore, but it work perfactlly in normal .Net

            EventsDelegates obj = new EventsDelegates();
            delegateObj = new EventsDelegates.SimpleDelegate(obj.MyNonStaticFunc);
            delegateObj("~~Non Static~~");

            delegateObj += new EventsDelegates.SimpleDelegate(EventsDelegates.MyStaticFunc);
            delegateObj("~~{both non static and static function will be called one by one}~~");
        }
    }
}

