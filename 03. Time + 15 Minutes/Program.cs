﻿using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double entryHours = double.Parse(Console.ReadLine());
            double entryMinutes = double.Parse(Console.ReadLine());

            entryMinutes = entryMinutes + 15;


            if (entryMinutes > 59)
            {
                entryMinutes = entryMinutes - 60;
                entryHours = entryHours + 1;
            }
            if (entryHours == 24)
            {
                entryHours = 0;
            }

            Console.Write($"{entryHours}:{entryMinutes:0#}");
        }
    }
}
