using System;

public class Program
{
    public static void Main()
    {
        int choice;

        while (true)
        {
            Console.WriteLine("Select Customer Type:");
            Console.WriteLine("1. Residential");
            Console.WriteLine("2. Commercial");

            Console.Write("Enter Choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 1 || choice == 2)
                    break;
            }

            Console.WriteLine("Invalid customer type.");
        }

        double units = InputHelper.ReadPositiveDouble("Enter Units Consumed: ");
        double rate = InputHelper.ReadPositiveDouble("Enter Rate Per Unit: ");
        double fixedCharges = InputHelper.ReadPositiveDouble("Enter Fixed Charges: ");

        IBillingCalculator calculator;
        if (choice == 1)
        {
            calculator = new ResidentialCustomer();
        }
        else
        {
            calculator = new CommercialCustomer();
        }

        double totalBill = calculator.CalculateBill(units, rate, fixedCharges);

        Console.WriteLine("Customer Type : " + (choice == 1 ? "Residential" : "Commercial"));
        Console.WriteLine("Units : " + units);
        Console.WriteLine("Rate : " + rate);
        Console.WriteLine("Fixed Charges : " + fixedCharges);
        Console.WriteLine("Total Bill : " + totalBill.ToString("F2"));
    }
}