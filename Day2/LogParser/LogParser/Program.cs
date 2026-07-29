using System;

public enum LogLevel
{
    Info,
    Warning,
    Error
}

public static class LogParser
{
    public static void ParseLogLine(string logLine, out DateTime timestamp, out LogLevel level, ref int counter)
    {
        counter++;

        string[] parts = logLine.Split(' ');
        timestamp = DateTime.Parse(parts[0] + " " + parts[1]);

        if (logLine.Contains("ERROR"))
        {
            level = LogLevel.Error;
        }
        else if (logLine.Contains("WARNING"))
        {
            level = LogLevel.Warning;
        }
        else
        {
            level = LogLevel.Info;
        }
    }
}

public class Program
{
    public static void Main()
    {
        int count = 0;
        string line = "2023-10-27 14:30:00 ERROR: Disk full";

        LogParser.ParseLogLine(line, out DateTime time, out LogLevel level, ref count);

        Console.WriteLine(time);
        Console.WriteLine(level);
        Console.WriteLine(count);
    }
}