using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            
                Console.WriteLine("Введите целое число:");
            int n = int.Parse(Console.ReadLine());

            Thread myThread = new Thread(new ParameterizedThreadStart(Count));
            myThread.Start(n);

            Console.ReadLine();
        }
        public static void Count(object n)
        {
            int i = 0;
            int n1 = (int)n;
            int S = 0;
            if (n1 < 0)
            {
                i = n1;
                n1 = 0;
            }
            for (; i < n1; i++)
            {
                S = S + i;

            }

            Console.WriteLine(S);
        }
    }
}
