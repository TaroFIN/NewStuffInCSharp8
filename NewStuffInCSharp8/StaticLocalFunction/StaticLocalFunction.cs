using System;

namespace NewStuffInCSharp8
{
    class StaticLocalFunction
    {
        public static void Output()
        {
            var numbers = new int[] { 5, 6, 4 };
            AddNumbers();

            void AddNumbers()
            {
                numbers[2] = 0;
                foreach (var no in numbers)
                {
                    Console.WriteLine(no);
                }
            }

            string firstName = "Clark";
            string lastName = "Kent";
            Console.WriteLine(GetName(firstName, lastName));
            static string GetName(string first, string last) => first + "," + last;
        }
    }
}
