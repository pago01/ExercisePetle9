using System;
using System.ComponentModel.Design;

namespace ExercisePetle9
{
    class Program
    {
        private static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            string wynik = "";
            double i = 0;
            bool parseresult;

            do
            {
                Console.WriteLine("Podaj liczbe do konwersji na zapis binarny");
                parseresult = Int32.TryParse(Console.ReadLine(), out a);
            }
            while (!parseresult && a>0);


            //Convertion do binary
            do
            {
                
                if (a % 2 == 1)
                {
                    wynik = "1" + wynik;
                    i++;
                }
                else if (a % 2 == 0)
                {
                    wynik = "0" + wynik;
                    i++;
                }
                a = a / 2;
            }
            while (a >0);

            Console.WriteLine(wynik);
        }
    }
}