public class Program
{
    public static string EvaluateString(string? s)
    {
        var split = s!.Split(" ");
        int a, b;
        string result = "";
        if (s.Length != 5)
        {
            result += "Error:InvalidExpression";
        }
        else if (!int.TryParse(split[0], out a) || !int.TryParse(split[2], out b))
        {
            result += "Error:InvalidNumber";
        }
        else if (b == 0)
        {
            result += "Error:DivideByZero";
        }
        else if (split[1] != "+" && split[1] != "-" && split[1] != "*" && split[1] != "/")
        {
            result += "Error:UnknownOperator";
        }
        else
        {
            switch (split[1])
            {
                case "+":
                    result += (a + b).ToString();
                    break;
                case "-":
                    result += (a - b).ToString();
                    break;
                case "*":
                    result += (a * b).ToString();
                    break;
                case "/":
                    result += (a / b).ToString();
                    break;
            }
        }
        return result;
    }

    public static void Main(string[] args)
    {
        string? str = Console.ReadLine();
        var result = EvaluateString(str);
        Console.WriteLine(result);
    }
}