﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            Console.WriteLine($"{num} - четное число");
            else 
            Console.WriteLine($"{num} - не четное число");
        }
    }
}
