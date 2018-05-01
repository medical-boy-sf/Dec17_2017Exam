using System;

namespace _04.Workout
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            double sum = m;
            double total = m;

            for (int i = 0; i < n; i++)
            {
                double percent = double.Parse(Console.ReadLine()) * 0.01;
                sum = sum + sum * percent;
                total += sum;
            }

            if (total < 1000)
            {
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {Math.Round(1000 - total)} more kilometers");
            }

            else
            {
                Console.WriteLine($"You've done a great job running {Math.Round(total - 1000)} more kilometers!");
            }
        }
    }
}
