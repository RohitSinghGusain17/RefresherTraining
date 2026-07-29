using System;
using System.Collections.Generic;

public static class LibraryProcessor
{
    public static bool TryParseISBN(string isbn, out string cleanedISBN)
    {
        cleanedISBN = isbn.Replace("-", "").Trim();

        if (cleanedISBN.Length == 13 && long.TryParse(cleanedISBN, out _))
        {
            return true;
        }

        cleanedISBN = "";
        return false;
    }

    public static bool TryProcessOrder(out List<string> validISBNs, params string[] isbnList)
    {
        validISBNs = new List<string>();

        foreach (string input in isbnList)
        {
            string[] books = input.Split(',');
            foreach (string book in books)
            {
                if (TryParseISBN(book, out string cleaned))
                {
                    validISBNs.Add(cleaned);
                }
            }
        }

        return validISBNs.Count > 0;
    }
}

public class Program
{
    public static void Main()
    {
        if (LibraryProcessor.TryProcessOrder(out List<string> books, "978-3-16-148410-0, 1234567890123, invalid-isbn, 978-1-4028-9462-6"))
        {
            Console.WriteLine("Valid ISBNs:");
            foreach (var b in books)
            {
                Console.WriteLine(b);
            }
        }
    }
}