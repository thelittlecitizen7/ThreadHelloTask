using System;
using System.Threading;

namespace ThreadHelloTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex1 ex1 = new Ex1();
            //ex1.A();
            ex1.B();
            //ex1.C();


            Ex2 ex2 = new Ex2(5000);
            //ex2.A();
            // ex2.B();

            Console.ReadLine();


        }


    }
}
