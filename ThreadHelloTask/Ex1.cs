using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadHelloTask
{
    public class Ex1
    {
        public  static int Number => 100;
        public Ex1()
        {

        }


        public void A()
        {
            Stopwatch sw;
            sw = Stopwatch.StartNew();
            for (int i = 0; i < Number; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"time sec {sw.ElapsedMilliseconds} ms");
            sw.Stop();
        }


        public async void B()
        {
            object locker = new object();
            Stopwatch sw;
            sw = Stopwatch.StartNew();
            for (int i = 0; i < Number; i++)
            {
                Task.Run(() =>
                {
                    Console.WriteLine(i);
                });
            }
            Console.WriteLine($"time sec {sw.ElapsedMilliseconds} ms");
            sw.Stop();
        }


        public void C()
        {
            Stopwatch sw;
            sw = Stopwatch.StartNew();
            
            for (int i = 0; i < Number; i++)
            {
                ThreadPool.QueueUserWorkItem(obj =>
                {
                    Console.WriteLine(i);
                }, i);
            }
            Console.WriteLine($"time sec {sw.ElapsedMilliseconds} ms");
            sw.Stop();
        }
    }
}
