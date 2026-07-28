using System;

public class BMI
{
    public static void Main()
    {
        Console.Write("Enter Weight in kg: ");
        if (!double.TryParse(Console.ReadLine(), out double weight))
        {
            Console.WriteLine("Invalid weight. enter a numeric value.");
            return;
        }
        if (weight <= 0)
        {
            Console.WriteLine("Weight must be greater than zero.");
            return;
        }

        Console.Write("Enter Height in m: ");
        if (!double.TryParse(Console.ReadLine(), out double height))
        {
            Console.WriteLine("Invalid height. enter a numeric value.");
            return;
        }
        if (height <= 0)
        {
            Console.WriteLine("Height must be greater than zero.");
            return;
        }

        double bmi = weight / (height * height);
        bmi = Math.Round(bmi, 2);

        Console.WriteLine("BMI : " + bmi);

        if (bmi < 18.5)
        {
            Console.WriteLine("Category: Underweight");
        }
        else if (bmi < 25)
        {
            Console.WriteLine("Category: Normal weight");
        }
        else if (bmi < 30)
        {
            Console.WriteLine("Category: Overweight");
        }
        else
        {
            Console.WriteLine("Category: Not healthy");
        }
    }
}