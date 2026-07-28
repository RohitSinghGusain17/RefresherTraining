using System;

public class BillApp
{
    public static void Main()
    {
        double price = 0;
        int quantity = 0;
        double discountPercent = 0;

        while (true)
        {
            Console.Write("Enter Price:");
            string input = Console.ReadLine()!;

            if (!double.TryParse(input, out price))
            {
                Console.WriteLine("Invalid input. enter a valid number.");
            }
            else if (price < 0)
            {
                Console.WriteLine("Price cannot be negative.");
            }
            else
            {
                break;
            }
        }

        while (true)
        {
            Console.Write("Enter Quantity: ");
            string input = Console.ReadLine()!;

            if (!int.TryParse(input, out quantity))
            {
                Console.WriteLine("Invalid input. enter a whole number.");
            }
            else if (quantity < 1)
            {
                Console.WriteLine("Quantity cannot be negative or zero.");
            }
            else
            {
                break;
            }
        }

        while (true)
        {
            Console.Write("Enter Discount%: ");
            string input = Console.ReadLine()!;

            if (!double.TryParse(input, out discountPercent))
            {
                Console.WriteLine("Invalid input. enter a valid number.");
            }
            else if (discountPercent < 0)
            {
                Console.WriteLine("Discount cannot be negative.");
            }
            else
            {
                break;
            }
        }

        double subtotal = price * quantity;
        double discountAmount = (subtotal * discountPercent) / 100;
        double finalAmount = subtotal - discountAmount;

        Console.WriteLine($"Subtotal: {Math.Round(subtotal, 2)}");
        Console.WriteLine($"Discount Amount: {Math.Round(discountAmount, 2)}");
        Console.WriteLine($"Final Payable Amount: {Math.Round(finalAmount, 2)}");
    }
}