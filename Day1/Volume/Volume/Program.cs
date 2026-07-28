using System;

public class Volume
{
    public static void Main()
    {
        Console.Write("Enter Length: ");
        if (!double.TryParse(Console.ReadLine(), out double length))
        {
            Console.WriteLine("Invalid length. enter a numeric value.");
            return;
        }
        if (length <= 0)
        {
            Console.WriteLine("Length must be greater than zero.");
            return;
        }

        Console.Write("Enter Width: ");
        if (!double.TryParse(Console.ReadLine(), out double width))
        {
            Console.WriteLine("Invalid width. enter a numeric value.");
            return;
        }
        if (width <= 0)
        {
            Console.WriteLine("Width must be greater than zero.");
            return;
        }

        Console.Write("Enter Height: ");
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

        double volume = length * width * height;
        volume = Math.Round(volume, 2);

        Console.WriteLine("Volume = " + volume + " cubic units");
    }
}