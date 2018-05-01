using System;

class Time
{
    public static void Main()
    {
        int numberNights = int.Parse(Console.ReadLine());
        string destination = Console.ReadLine();
        string transport = Console.ReadLine();
        double priceAdults = 0;
        double priceChildren = 0;


        switch (destination)
        {
            case "Miami":
                if (numberNights > 15)
                {
                    priceAdults = 20;
                    priceChildren = 10;
                }

                else if (numberNights > 10)
                {
                    priceAdults = 22.99;
                    priceChildren = 11.99;
                }

                else
                {
                    priceAdults = 24.99;
                    priceChildren = 14.99;
                }
                break;

            case "Canary Islands":
                if (numberNights > 15)
                {
                    priceAdults = 28;
                    priceChildren = 22;
                }

                else if (numberNights > 10)
                {
                    priceAdults = 30.5;
                    priceChildren = 25.6;
                }

                else
                {
                    priceAdults = 32.5;
                    priceChildren = 28.5;
                }
                break;

            case "Philippines":
                if (numberNights > 15)
                {
                    priceAdults = 38.5;
                    priceChildren = 32.4;
                }

                else if (numberNights > 10)
                {
                    priceAdults = 41;
                    priceChildren = 36;
                }

                else
                {
                    priceAdults = 42.99;
                    priceChildren = 39.99;
                }
                break;
        }

        double priceTransport = 0;
        if (transport == "train")
        {
            priceTransport = 2 * 22.3 + 3 * 12.5;
        }

        else if (transport == "bus")
        {
            priceTransport = 2 * 45 + 3 * 37;
        }

        else
        {
            priceTransport = 2 * 90 + 3 * 68.5;
        }

        double totalPrice = numberNights * priceAdults * 2 + numberNights * priceChildren * 3;
        double priceDog = 0.25 * totalPrice;
        double finalPrice = totalPrice + priceDog;
        Console.WriteLine($"{(finalPrice + priceTransport):F3}");
    }
}
