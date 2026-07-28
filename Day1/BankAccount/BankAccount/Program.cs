using System;

public class Program
{
    public static void Main()
    {
        double openingBalance, deposits, withdrawals;

        Console.Write("Enter Opening Balance: ");
        if (!double.TryParse(Console.ReadLine(), out openingBalance) || openingBalance < 0)
        {
            Console.WriteLine("Error: Invalid opening balance.");
            return;
        }

        Console.Write("Enter Total Deposits: ");
        if (!double.TryParse(Console.ReadLine(), out deposits) || deposits < 0)
        {
            Console.WriteLine("Error: Invalid deposit amount.");
            return;
        }

        Console.Write("Enter Total Withdrawals: ");
        if (!double.TryParse(Console.ReadLine(), out withdrawals) || withdrawals < 0)
        {
            Console.WriteLine("Error: Invalid withdrawal amount.");
            return;
        }

        double availableBalance = openingBalance + deposits;

        if (withdrawals > availableBalance)
        {
            Console.WriteLine("Error: Withdrawals exceed available balance.");
            return;
        }

        double finalBalance = availableBalance - withdrawals;

        Console.WriteLine($"Opening Balance : {openingBalance}");
        Console.WriteLine($"Deposits : {deposits}");
        Console.WriteLine($"Withdrawals : {withdrawals}");
        Console.WriteLine($"Final Balance : {finalBalance}");
    }
}