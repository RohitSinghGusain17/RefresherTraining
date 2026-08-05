using System;
using System.Collections.Generic;

public class Bike
{
    public string? Model { get; set; }
    public int PricePerDay { get; set; }
    public string? Brand { get; set; }
}

public class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        Bike bike = new Bike();
        bike.Model = model;
        bike.Brand = brand;
        bike.PricePerDay = pricePerDay;
        int key = Program.bikeDetails.Count+1;
        Program.bikeDetails.Add(key, bike);
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> groupedBikes = new SortedDictionary<string, List<Bike>>();

        foreach(Bike bike in Program.bikeDetails.Values)
        {
            if(!groupedBikes.ContainsKey(bike.Brand!))
            {
                groupedBikes[bike.Brand!] = new List<Bike>();
            }
            groupedBikes[bike.Brand!].Add(bike);
        }

        return groupedBikes;
    }
}

public class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    public static void Main()
    {
        BikeUtility utility = new BikeUtility();

        while(true)
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice:");
            int choice = int.Parse(Console.ReadLine()!);

            if(choice==1)
            {
                Console.Write("Enter the model:");
                string model = Console.ReadLine()!;
                Console.Write("Enter the brand:");
                string brand = Console.ReadLine()!;
                Console.Write("Enter the price per day:");
                int pricePerDay = int.Parse(Console.ReadLine()!);

                utility.AddBikeDetails(model, brand, pricePerDay);
                Console.WriteLine("Bike details added successfully");
            }
            else if(choice==2)
            {
                SortedDictionary<string, List<Bike>> result = utility.GroupBikesByBrand();

                foreach(var item in result)
                {
                    foreach(Bike bike in item.Value)
                    {
                        Console.WriteLine(bike.Brand+" "+bike.Model);
                    }
                }
            }
            else if(choice==3)
            {
                break;
            }
        }
    }
}