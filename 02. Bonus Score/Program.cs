using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Въвеждам num
            int num = int.Parse(Console.ReadLine());

            double bonus = 0;
            //2. Начисляваме основния бонус:
            //ако num <=100
            if (num <= 100)
            {
                //=> бонуса е 5т.
                bonus = 5;
            }
            //ако num > 1000 
            else if (num > 1000)
            {
                //=> бонус = 10 % от num
                bonus = num * 0.10;
                //bonus = num *10/100.0;
            }
            else
            {
                //бонус => 20% от num
                bonus = num * 0.20;
            }

            //3. Начисляваме допълнителния бонус:
            //ако числото е четно => +1т. 
            if (num % 2 == 0)
            {
                //bonus = bonus + 1;
                bonus += 1;
            }
            //ако числото завършва на 5 => +2т.
            else if (num % 10 == 5)
            {
                //bonus = bonus + 2;
                bonus += 2;
            }

            //4. Отпечатваме резултата (бонус т. и числото+бонуса)
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
