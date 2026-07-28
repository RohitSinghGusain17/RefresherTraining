using System;

public static class InputHelper
{
    public static double ReadPositiveDouble(string message)
    {
        double value;

        while (true)
        {
            Console.Write(message);

            if (double.TryParse(Console.ReadLine(), out value))
            {
                if (value >= 0)
                {
                    return value;
                }
            }

            Console.WriteLine("Invalid input enter a valid positive number.");
        }
    }
}