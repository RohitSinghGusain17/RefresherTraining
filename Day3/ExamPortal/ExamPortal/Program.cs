using System;
using System.Collections.Generic;

namespace ExamPortal
{
    public abstract class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Category { get; set; }
        public string Topic { get; set; }

        public Question(int id, string text, string category, string topic)
        {
            Id = id;
            Text = text;
            Category = category;
            Topic = topic;
        }

        public abstract void Display();
    }

    public class MCQQuestion : Question
    {
        public List<string> Options { get; set; }

        public MCQQuestion(int id, string text, string category, string topic, List<string> options) : base(id, text, category, topic)
        {
            Options = options;
        }

        public override void Display()
        {
            Console.WriteLine("Question ID : " + Id);
            Console.WriteLine("Question : " + Text);
            Console.WriteLine("Category : " + Category);
            Console.WriteLine("Topic : " + Topic);
            Console.WriteLine("Options:");
            for (int i = 0; i < Options.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + Options[i]);
            }

            Console.WriteLine();
        }
    }

    public class ParagraphQuestion : Question
    {
        public ParagraphQuestion(int id, string text, string category, string topic) : base(id, text, category, topic)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Question ID : " + Id);
            Console.WriteLine("Question : " + Text);
            Console.WriteLine("Category : " + Category);
            Console.WriteLine("Topic : " + Topic);
            Console.WriteLine();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Question> questions = new List<Question>();

            questions.Add(new MCQQuestion(1, "What is C#?", "Programming", ".NET",
                new List<string> { "Language", "Database", "OS", "Browser" }));

            questions.Add(new MCQQuestion(2, "What is CLR?", "Programming", ".NET", 
                new List<string> { "Compiler", "Runtime", "IDE", "Editor" }));

            questions.Add(new ParagraphQuestion(3, "Explain OOP Principles.", "Theory", "OOP"));

            questions.Add(new ParagraphQuestion(4, "Explain Abstraction.", "Theory", "OOP"));

            Console.WriteLine("Total Questions = " + questions.Count);

            Console.WriteLine("Questions for Topic : .NET");

            foreach (Question q in questions)
            {
                if (q.Topic.Equals(".NET", StringComparison.OrdinalIgnoreCase))
                {
                    q.Display();
                }
            }

            Console.WriteLine("Questions for Topic : OOP and Category : Theory");

            foreach (Question q in questions)
            {
                if (q.Topic.Equals("OOP", StringComparison.OrdinalIgnoreCase) && q.Category.Equals("Theory", StringComparison.OrdinalIgnoreCase))
                {
                    q.Display();
                }
            }
        }
    }
}