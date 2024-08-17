using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Четем входните данни, както следва:
            double worldRecord = double.Parse(Console.ReadLine());//свтовния рекорд
            double distance = double.Parse(Console.ReadLine());//разстоянието в метри
            double timePerMeter = double.Parse(Console.ReadLine());//времето в секунди, за което плува разстояние от 1 м. 

            //2. Изчисляваме забавянето
            double delay = distance / 15;
            delay = Math.Floor(delay);
            delay = delay * 12.5;

            //3. Изчисляваме какъв е рекорда на Иван 
            double recordByIvan = distance * timePerMeter + delay;

            //4. Проверяваме дали е подбрил световния рекорд
            if (recordByIvan < worldRecord)
            {
                //подобрил го е
                Console.WriteLine($" Yes, he succeeded! The new world record is {recordByIvan:f2} seconds.");
            }
            else
            {
                //не е успял да го подобри]
                Console.WriteLine($"No, he failed! He was {Math.Abs(worldRecord - recordByIvan):f2} seconds slower.");
            }
            }
    }
}
