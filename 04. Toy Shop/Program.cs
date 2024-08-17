using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. четем цената на екскурзията
            double excursionPrice = double.Parse(Console.ReadLine());

            //2. четем количеството на всяка от играчките
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            //3. Изчисляваме как е печалбата от поръчката
            int toysQuantity = puzzles + dolls + bears + minions + trucks;
            double money = puzzles * 2.60 + dolls * 3.00 + bears * 4.10 + minions * 8.20 + trucks * 2.00;

            //4. Ако играчките са >=50 => 25% отстъпка
            if (toysQuantity >= 50)
            {
                money = money - money * 0.25;
                //money -= money * 0.25;
            }

            //5. изваждаме от печалбата парите за наема
            money = money - money * 0.10;
            //money -= money * 0.10;

            //6. Проверваме дали печалбата е достатъчно
            double difference = excursionPrice - money;
            //   => aко difference <=0 => парите са достатъчно 
            //   => aко difference е положително => парите НЕ са достатъчно 

            if (difference <= 0)
            {
                //парите са достатъчно 
                Console.WriteLine($"Yes! {Math.Abs(difference):F2} lv left.");
            }
            else
            {
                //парите НЕ са достатъчно 
                Console.WriteLine($"Not enough money! {difference:F2} lv needed.");
            }
        }
    }
}
