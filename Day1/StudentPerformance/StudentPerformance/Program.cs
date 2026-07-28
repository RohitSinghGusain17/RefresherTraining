using System;

public class StudentPerformance
{
    public static void Main()
    {
        double mark1, mark2, mark3, mark4, mark5;

        Console.Write("Enter marks for Subject 1: ");
        if (!double.TryParse(Console.ReadLine(), out mark1) || mark1 < 0 || mark1 > 100)
        {
            Console.WriteLine("Error: Invalid marks for Subject 1.");
            return;
        }

        Console.Write("Enter marks for Subject 2: ");
        if (!double.TryParse(Console.ReadLine(), out mark2) || mark2 < 0 || mark2 > 100)
        {
            Console.WriteLine("Error: Invalid marks for Subject 2.");
            return;
        }

        Console.Write("Enter marks for Subject 3: ");
        if (!double.TryParse(Console.ReadLine(), out mark3) || mark3 < 0 || mark3 > 100)
        {
            Console.WriteLine("Error: Invalid marks for Subject 3.");
            return;
        }

        Console.Write("Enter marks for Subject 4: ");
        if (!double.TryParse(Console.ReadLine(), out mark4) || mark4 < 0 || mark4 > 100)
        {
            Console.WriteLine("Error: Invalid marks for Subject 4.");
            return;
        }

        Console.Write("Enter marks for Subject 5: ");
        if (!double.TryParse(Console.ReadLine(), out mark5) || mark5 < 0 || mark5 > 100)
        {
            Console.WriteLine("Error: Invalid marks for Subject 5.");
            return;
        }

        double total = mark1 + mark2 + mark3 + mark4 + mark5;
        double average = total / 5;
        double percentage = (total / 500) * 100;
        double roundedPercentage = Math.Round(percentage);

        Console.WriteLine($"Total Marks : {total}");
        Console.WriteLine($"Average Marks : {average:F2}");
        Console.WriteLine($"Percentage : {percentage:F2}%");
        Console.WriteLine($"Rounded Percentage : {roundedPercentage}%");
    }
}