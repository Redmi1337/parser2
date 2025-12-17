using System;
using Classes;
using System.Windows.Markup;
using System.Linq.Expressions;

namespace proj3
{
    class Program
    {
        static void Main()
        {
            bool active = true;
            string example = "";
            List<int> numbers = new List<int> { };
            List<char> signs = new List<char> { };
            Console.Clear();
            while (active == true)
            {
                Console.WriteLine("Write an equasion:");
                example = Console.ReadLine();
                switch (example)
                {
                    case "b":
                        active = false;
                        break;
                    default:
                        numbers = Classes.Classes.ReadNumbers(example);
                        signs = Classes.Classes.ReadSigns(example);
                        foreach (int i in numbers)
                        {
                            Console.WriteLine(i);
                        }
                        foreach (char c in signs)
                        {
                            Console.WriteLine(c);
                        }
                        break;
                }
            }
        }
    }
}