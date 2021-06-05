using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppExam_KatkovISiP_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            Console.WriteLine("Введите длинну массива");
            ushort n = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Введите число K");
            int K = int.Parse(Console.ReadLine());
            ushort[] a = new ushort[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Введите {0}-й элемент", i+1);
                a[i] = ushort.Parse(Console.ReadLine());
                if (a[i] % K == 0)
                {
                    s += a[i];
                }
                else Console.WriteLine("Это число не кратно {0}", K);
            }
            Console.WriteLine("Сумма чисел, кратных {0} равна {1}", K, s);
        }
    }
}
