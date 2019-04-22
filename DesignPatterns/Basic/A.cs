using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    class A
    {
        public virtual void MethodA()
        {
            Console.WriteLine("Class A - Method A");
        }
    }

    class B : A
    {
        public override void MethodA()
        {
            Console.WriteLine("Class B - Method A");
        }

        public void MethodB()
        {
            Console.WriteLine("Class B - Method B");
        }
    }

    class test
    {
        static void Main(String[] str)
        {
            A obj1 = new A();
            obj1.MethodA();

            B obj2 = new B();
            obj2.MethodA();
            obj2.MethodB();

            A obj3 = new B();
            obj3.MethodA();
        }
    }
}
