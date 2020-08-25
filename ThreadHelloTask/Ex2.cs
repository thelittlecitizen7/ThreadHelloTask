using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadHelloTask
{
    public class Ex2
    {
        public ConcurrentStack<int> Numbers { get; set; }
        public Ex2(int maxNumber)
        {
            Numbers = new ConcurrentStack<int>();
            for (int i = 1; i <= maxNumber; i++)
            {
                Numbers.Push(i);
            }
        }


        public void A()
        {
            for (int i = 0; i < 3; i++)
            {
                Task.Run(() =>
                {
                    if (Numbers.Count > 0)
                    {
                        int num;
                        Numbers.TryPeek(out num);
                        Console.WriteLine(num);
                    }
                });
            }
        }


        public void B()
        {
            Parallel.For(0, 3, obj =>
              {
                  if (Numbers.Count > 0)
                  {
                      int num;
                      Numbers.TryPeek(out num);
                      Console.WriteLine(num);
                  }
              });

        }


    }
}
