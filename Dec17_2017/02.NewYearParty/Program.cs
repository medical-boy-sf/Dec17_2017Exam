using System;

namespace _02.NewYearParty
{
    class Program
    {
        static void Main()
        {
            int numberOfGuests = int.Parse(Console.ReadLine());
            double budget = int.Parse(Console.ReadLine());
            double priceCouvert = numberOfGuests * 20;
            double fireworksMoney = 0;
            double charity = 0;
            if (budget >= priceCouvert)
            {
                charity = (budget - priceCouvert) * 0.6;
                fireworksMoney = 0.4 * (budget - priceCouvert);
                Console.WriteLine($"Yes! {Math.Round(fireworksMoney)} lv are for fireworks and {Math.Round(charity)} lv are for donation.");
            }

            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {Math.Round(Math.Abs(priceCouvert - budget))} lv more.");
            }

        }
    }
}
