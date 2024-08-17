using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Въвеждаме име на сериал, продължителност на сериала и време обедна почивка
            string seriesName = Console.ReadLine();
            int seriesTime = int.Parse(Console.ReadLine());
            int lunchTime = int.Parse(Console.ReadLine());

            //2. Колко време от обедна почивка е за гледане на сериал
            //   => намираме колко са 5/8 от обедната почивка
            double timeForSeries = lunchTime * 5 / 8.0;

            //3. Проверяваме дали това време ще ни стигне за епизода 
            if (seriesTime <= timeForSeries)
            {
                //има време
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeForSeries - seriesTime)} minutes free time.");
            }
            else
            {
                //няма време 
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesTime - timeForSeries)} more minutes.");
            }
        }
    }
}
