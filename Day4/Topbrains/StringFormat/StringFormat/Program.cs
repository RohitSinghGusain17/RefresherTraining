using System.Text.Json;

public record Student(string name, int score);
public class Program
{
    public static void Main(string[] args)
    {
        string[] students = new string[5];
        students[0] = "Test1:59";
        students[1] = "Test2:98";
        students[2] = "Test5:89";
        students[3] = "Test4:53";
        students[4] = "Test3:89";

        int minScore = 55;

        List<Student> list = new List<Student>();
        for (int i = 0; i < students.Length; i++)
        {
            var s = students[i].Split(":");
            list.Add(new Student(s[0], int.Parse(s[1])));
        }

        var result = list.Where(x => x.score >= minScore).OrderByDescending(x => x.score).ThenBy(x => x.name);
        var serialize = JsonSerializer.Serialize(result);
        Console.WriteLine(serialize);
    }
}