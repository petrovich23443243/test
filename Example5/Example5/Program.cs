using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace Example5
{
    class Program
    {


        static async Task<int[]> MasAsync(int n)
        {
            int[] mas = new int[n];
            Console.WriteLine("Начало метода MasAsync"); // выполняется синхронно
            await Task.Run(() =>
            {
                for (int i = 0; i < n; i++)
                    mas[i] = i;
            });             // выполняется асинхронно
                Console.WriteLine("Конец метода MasAsync");

            return mas;
            }

            static void Main(string[] args)
            {
             

                Console.WriteLine("Введите положительное число: ");
                int n = Int32.Parse(Console.ReadLine());
                Task <int[]> t=  MasAsync(n);   // вызов асинхронного метода
                t.Wait();
            Console.WriteLine(string.Join(",", t.Result));
            Console.Read();
            }
        }
    
    }

