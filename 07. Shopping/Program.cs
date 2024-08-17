using System;

namespace _7._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int graphics_cards = int.Parse(Console.ReadLine());
            int processors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double sum_graphics_cards = graphics_cards * 250;
            double sum_processors = sum_graphics_cards * 35 / 100;
            double processors_price = sum_processors * processors;
            double sum_ram = sum_graphics_cards * 10 / 100;
            double ram_price = sum_ram * ram;
            double total_sum = sum_graphics_cards + processors_price + ram_price;
            if (graphics_cards > processors)
            {
                total_sum = total_sum - total_sum * 15 / 100;
            }
            if (total_sum <= budget)
            {
                Console.WriteLine($"You have {budget - total_sum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {total_sum - budget:f2} leva more!");
            }
        }
    }
}