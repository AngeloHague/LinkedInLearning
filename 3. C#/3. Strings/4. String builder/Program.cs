using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int jumpCount = 10;
            string[] animals = {"goats", "cats", "pigs"};

            // TODO: create a StringBuilder
            StringBuilder sb = new StringBuilder("Initial string.", 200); // initial value, max length

            // TODO: print some basic stats about the StringBuilder
            Console.WriteLine($"\nCapacity: {sb.Capacity}; Length: {sb.Length}");

            // TODO: Add some strings to the builder using Append
            sb.Append(" Hello,");
            sb.Append(" Jim!");
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"\nCapacity: {sb.Capacity}; Length: {sb.Length}");

            // TODO: AppendLine can append a line ending
            sb.AppendLine();
            sb.AppendLine("This is story about Jim.");
            // Console.WriteLine(sb.ToString());

            // TODO: AppendFormat can be used to append formatted strings
            sb.AppendFormat("He jumped {0} times.", jumpCount);

            // TODO: AppendJoin can iterate over a set of values
            sb.AppendLine(" He jumped over; ");
            sb.AppendJoin(", ", animals);
            // Console.WriteLine(sb.ToString());

            // TODO: Modify the content using Replace
            sb.Replace("cats", "dogs");
            // Console.WriteLine(sb.ToString());

            // TODO: Insert content at any index
            sb.Insert(0, "This is the ");
            
            // TODO: Convert to a single string
            Console.WriteLine($"\nCapacity: {sb.Capacity}; Length: {sb.Length}");
            Console.WriteLine(sb.ToString());

        }
    }
}
