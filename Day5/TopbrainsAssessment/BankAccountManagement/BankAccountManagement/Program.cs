using System;

public class Account
{
    private string name;
    private double balance;

    public Account(string name, double initialBalance)
    {
        this.name = name;
        this.balance = initialBalance;
    }
    public double deposit(double depositAmount)
    {
        balance += depositAmount;
        return balance;
    }
    public double getBalance()
    {
        return balance;
    }
    public void setName(string newName)
    {
        name = newName;
    }
    public string getName()
    {
        return name;
    }
}

public class Program
{
    public static void Main()
    {
        Account account1 = new Account("John Doe", 1000);
        Console.WriteLine(account1.deposit(250));
        Console.WriteLine(account1.getName());
        Account account2 = new Account("Rohit", 500);
        Console.WriteLine(account2.getBalance());
        Console.WriteLine(account2.deposit(750.5));
        Console.WriteLine(account2.getBalance());
        account2.setName("Riya Amit Mehta");
        Console.WriteLine(account2.getName());
    }
}