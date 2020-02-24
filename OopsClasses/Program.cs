using System;

namespace OopsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ChildClass baseClass = new ChildClass();



            //BaseClass b1 = new BaseClass();

            BaseClass.Method3();
        }
    }

    
    public class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("BaseClass Constructor");
        }

        //1. Static constructor doesn't require access modifier
        //2. Static constructor is used to initialize any static data, it'll be called first
        static BaseClass()
        {
            Console.WriteLine("BaseClass static Constructor");
        }

        //Static constructor must be parameter less
       // static BaseClass(int i) { }       

        public static void Method3()
        {
            Console.WriteLine("Static Method3");
        }

        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public virtual void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    public class ChildClass
    {
        public ChildClass()
        {
            Console.WriteLine("ChildClass Constructor");
        }

        public void Method1()
        {
            Console.WriteLine("ChildClass Method1");
        }

    }
}
