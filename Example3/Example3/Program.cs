using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {

            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;

            Task task = new Task(() => Display( token));
            task.Start();
            Thread.Sleep(1000);

            Console.WriteLine("Введите любую клавишу для отмены задачи:");
            Console.ReadKey();
         
            cancelTokenSource.Cancel();

            Console.ReadLine();
        }

        static void Display(CancellationToken token)
        {
            while (!token.IsCancellationRequested) ;
            Console.WriteLine("Задача прервана.");

        }
    }
    }

