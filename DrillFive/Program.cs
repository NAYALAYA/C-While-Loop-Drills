using System;

class Program
{
    static void Main()
    {
        double balance = 1000.0;
        double interestRate = 0.05; // 5% annual interest
        double target = 2000.0;
        int years = 0;

        // TODO: Write a while loop to calculate years to reach the target balance.
        // Each year: increase balance by (balance * interestRate) and increment years.



        Console.WriteLine($"It took {years} years to reach ${balance:F2}");
    }
}

