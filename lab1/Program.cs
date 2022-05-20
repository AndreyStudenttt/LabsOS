using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace lab1
{
    class Program
    {
        static int[] mass { get; set; }
        static Thread myThread { get; set; }
        static Thread worker { get; set; }
        static int sred { get; set; }

        static void Main()
        {
            int razmer = Convert.ToInt32(Console.ReadLine());
            mass = new int[razmer];

            Random random = new Random();
            for (int i = 0; i < razmer; i++)
            {
                mass[i] = random.Next(13);
                Console.WriteLine($"mass[{i}] = {mass[i]}\n");
            }
            Console.WriteLine($"id потока main(this) = {Thread.CurrentThread.ManagedThreadId}\n");
            
            worker = new Thread(Sred);
            worker.Start();
            Console.WriteLine($"id потока worker = {worker.ManagedThreadId}\n");
            
            int max = mass[0];
            for (int i = 1; i < mass.Length; i++)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                }
                Thread.Sleep(7);
            }
            Console.WriteLine($"Максимум в массиве(main) = {max}\n");
            worker.Join();

            int k = 0;
            for (int i = 0; i < razmer; i++)
            {
                if (mass[i] > sred)
                {
                    k++;
                }
            }
            Console.WriteLine($"Количество значений в массиве больше среднего(main) = {k}\n");

        }
        
        static void Sred()
        {
            int summ = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                summ += mass[i];
                Thread.Sleep(12);
            }

            sred = summ / mass.Length;
            Console.WriteLine($"Среднее значение массива(worker) = {sred}\n");
            int summnechet = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] % 2 != 0)
                    summnechet++;
            }
            Console.WriteLine($"кол нечетных чисел массива(worker) = {summnechet}\n");
        }

    }
}
