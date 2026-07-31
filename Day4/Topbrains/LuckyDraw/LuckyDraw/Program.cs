public class Program
{
    public static int SumOfDigits(int x)
    {
        int sum = 0;
        while (x > 0)
        {
            int d = x % 10;
            sum += d;
            x = x / 10;
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        int m, n;
        m = int.Parse(Console.ReadLine()!);
        n = int.Parse(Console.ReadLine()!);

        int count = 0;
        for (int i = m; i <= n; i++)
        {
            int first = SumOfDigits(i);
            int second = SumOfDigits(i * i);
            if (first * first == second)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}