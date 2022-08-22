using System;

namespace MethodShadowing
{
    class Class1
    {
        public virtual void Test1()
        {
            Console.WriteLine("Test1 Parent class method, can be overriden");
        }
        public void Test2()
        {
            Console.WriteLine("Test2 Parent class method, can't be overriden");
        }
    }

    class Class2:Class1
    {
        public override void Test1()
        {
            Console.WriteLine("Test1 Child class method, overriden");//Method Overriding:Since we didnot like the parent class Test1 method
        }
        public new void Test2()
        {
            Console.WriteLine("Test2 Child class method, can't be overriden, but method hiding/shadowing is done.");// Method Hiding/Shadowing:Since we didnot like the parent class Test2 method
                                                                                                               //and it was not virtual method, we do method hiding: using "new" keyword is not neccessary, but to tell the compiler we are doing it intensionally...
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class2 obj = new Class2();
            obj.Test1();
            obj.Test2();
            Console.ReadLine();
        }
    }
}
