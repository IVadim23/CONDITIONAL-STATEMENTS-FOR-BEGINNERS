using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Прочитаме времет на всеки от състезателите
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            //2. Намираме общото време
            int time = first + second + third;

            //3. Намираме това колко минути и колко секунди са
            int min = time / 60; //колко пъти 60 се съдържа в time 
            int sec = time % 60; //колко пъти 60 НЕ СЕ съдържа в time

            //4. Отпечатваме резултата
            //   => Секундите да се изведат с водеща нула (2=>"02", 17=>"17")
            if (sec >= 10)
            {
                Console.WriteLine($"{min}:{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:0{sec}");
            }
        }
    }
}
