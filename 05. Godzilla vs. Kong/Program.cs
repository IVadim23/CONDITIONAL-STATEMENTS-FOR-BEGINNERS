using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Budgetforthemovie = double.Parse(Console.ReadLine());
            double Numberofextras = double.Parse(Console.ReadLine());
            double Priceforclothingofonestatis = double.Parse(Console.ReadLine());
            double Amountfordecor = Budgetforthemovie * 0.10;


            if (Numberofextras <= 150)
            {
                double Amountforclothing =(Numberofextras * Priceforclothingofonestatis) ;
                double Totalforthefilm = Amountforclothing + Amountfordecor;
                if (Totalforthefilm <= Budgetforthemovie)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {Totalforthefilm - Budgetforthemovie:F2} leva left. ");
                }
                else
                {

                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {Budgetforthemovie- Totalforthefilm:F2} leva more.");
                }


            }
            else
            {
                double Amountforclothing = ((Numberofextras * Priceforclothingofonestatis)*0.10);
                double Totalforthefilm = Amountforclothing + Amountfordecor;
                double a = Budgetforthemovie - Totalforthefilm;
                if (Totalforthefilm <= Budgetforthemovie)
                {
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {Totalforthefilm - Budgetforthemovie:F2} leva left. ");
                }
                else 
                        {

                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {Budgetforthemovie - Totalforthefilm:F2} leva more.");
                }
            }  
            
            
          



        }
    }
}
