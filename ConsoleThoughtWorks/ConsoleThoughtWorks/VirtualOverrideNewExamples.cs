using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleThoughtWorks
{

    class A
    {
        public void Test() { Console.WriteLine("A::Test()"); }
    }

    class B : A
    {
        public virtual void Test() { Console.WriteLine("B::Test()"); }
    }

    class C : B
    {
        public virtual void Test() { Console.WriteLine("C::Test()"); }
    }

    class D : C
    {
        public override void Test() { Console.WriteLine("D::Test()"); }
    }

    class E : D
    {
        public override void Test() { Console.WriteLine("E::Test()"); }
    }

    partial class Program
    {
        static void Main3(string[] args)
        {

            ////A a = new A();
            ////B b = new B();
            ////C c = new C();
            ////D d = new D();

            ////a.Test(); // output --> "A::Test()"
            ////b.Test(); // output --> "B::Test()"
            ////c.Test(); // output --> "C::Test()"
            ////d.Test(); // output --> "D::Test()"

            Console.WriteLine();
            Console.WriteLine("-A-----------");
            //A////////////
            A aa = new B();
            aa.Test(); // output --> "A::Test()"

            A aaa = new C();
            aaa.Test(); // output --> "A::Test()"

            A aaaa = new D();
            aaaa.Test(); // output --> "A::Test()"

            A aaaaa = new E();
            aaaaa.Test(); // output --> "A::Test()"

            Console.WriteLine("-B-----------");

            //B//////////

            B bb = new C();
            bb.Test(); // output --> "B::Test()"

            B bbb = new D();
            bbb.Test(); // output --> "B::Test()"

            B bbbb = new E();
            bbbb.Test(); // output --> "B::Test()"

            Console.WriteLine("-C-----------");

            //C//////////
            C cc = new D();
            cc.Test(); // output --> "D::Test()"

            C ccc = new E();
            ccc.Test(); // output --> "D::Test()"
            Console.WriteLine("-D-----------");

            //D//////////
            D dd = new E();
            dd.Test(); // output --> "D::Test()"

            Console.ReadKey();
        }
    }


}
