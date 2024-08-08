using System;

namespace NewStuffInCSharp8
{
    public class VerbatimInterpolatedStrings
    {
        public static void Output()
        {
            string normal = "Vienna is a very beautiful city. \nI visited it multiple times";
            Console.WriteLine(normal);

            string verbatim = @"Vienna is a very beautiful city
beautiful city.
I visited it mutiple times.";

            Console.WriteLine(verbatim);

            int visits = 2;
            Console.WriteLine("------");

            string concat = "I visited Vienna " + visits + " times.";
            Console.WriteLine(concat);

            string interpolate = $"I visited Vienna {visits} times.";
            Console.WriteLine(interpolate);

            string format = string.Format("I visited Vienna {0} times.", visits);
            Console.WriteLine(format);

            string fileName = "employees.xls";
            string folderName = $@"c:\Documents\files\{fileName}";
            Console.WriteLine(folderName);
            Console.WriteLine("------\n");
            string travelToVienna = @$"Vienna is a very beautiful city 
I visited it {visits} times";
            Console.WriteLine(travelToVienna);

            string[] @for = { "Jack", "Jennifer", "Smith" };
            foreach (var name in @for)
            {
                Console.WriteLine(name);
            }
        }
    }
}
