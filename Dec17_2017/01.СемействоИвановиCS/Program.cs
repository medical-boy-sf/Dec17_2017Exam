using System;

class Program
{

    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        double pricePresentFirstChild = double.Parse(Console.ReadLine());
        double pricePresentSecondChild = double.Parse(Console.ReadLine());
        double pricePresentThirdChild = double.Parse(Console.ReadLine());
        double priceTotal = (pricePresentFirstChild
                    + (pricePresentSecondChild + pricePresentThirdChild));
        double charity = ((budget - priceTotal)
                    * 0.9);
        Console.WriteLine($"{charity:F2}");
    }
}