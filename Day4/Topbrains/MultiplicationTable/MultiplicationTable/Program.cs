public class Program
{
    public static void Main(string[] args)
    {
        int n, upto;
        n = int.Parse(Console.ReadLine()!);
        upto = int.Parse(Console.ReadLine()!);

        int[] result = new int[upto];
        for (int i = 1; i <= upto; i++)
        {
            result[i - 1] = i * n;
        }

        for (int i = 0; i < upto; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}