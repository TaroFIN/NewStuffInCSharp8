namespace NewStuffInCSharp8
{
    class NullCoalescingAssignment
    {
        static void Output(string[] args)
        {
            List<int> numbers = new List<int>();
            int? i = null;
            //i = 2;
            numbers.Add(i ??= 10); // will sign value to i
            numbers.Add(i ??= 5);  // will not sign value to i


            Console.WriteLine("Value of i=" + i);

            foreach (var no in numbers)
            {
                Console.WriteLine(no);
                // output: 10
                //         10
            }
        }
    }
}
