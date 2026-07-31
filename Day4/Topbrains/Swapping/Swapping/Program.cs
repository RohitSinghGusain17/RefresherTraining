public class Program
{
    public static void SwapWithRef(ref int a, ref int b)
    {
        a += b;
        b = a - b;
        a -= b;
    }

    public static void SwapWithOut(ref int m, ref int n, out int x, out int y)
    {
        m += n;
        y = m - n;
        x = m - y;
    }
    public static void Main(string[] args)
    {
        int a = 3;
        int b = 4;
        SwapWithRef(ref a, ref b);
        Console.WriteLine(a + " " + b);
        int m = 5;
        int n = 6;
        SwapWithOut(ref m, ref n, out int x, out int y);
        Console.WriteLine(x + " " + y);
    }
}