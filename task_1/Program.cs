using System;
using System.Collections.Generic;

namespace task1
{

    class Program
    {
        enum day
        {

            q,
            w,
            e,
            r,
            t
        }
        /*Создать список из 5 элементов и вывести все на консоль
         * Создать массив из 5 элементов и вывести все на консоль
         * Создать перечесление и вывести на консоль 
         */


        static void Main()
        {
            List<int> ts = new List<int>();
            ts.Add(0);
            ts.Add(2);
            ts.Add(3);
            ts.Add(4);
            ts.Add(5);

            for (int i = 0; i < ts.Count; i++)
            {
                Console.WriteLine($"{ts[i]}");

            }

            int[] mass = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{(day)(i) }");
            }

            Console.ReadLine();

        }
    }
}
