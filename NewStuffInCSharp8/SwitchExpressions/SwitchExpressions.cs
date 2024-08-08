namespace NewStuffInCSharp8
{
    class Program
    {
        public enum Months
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }
        static void Main(string[] args)
        {
            Months month = Months.March;
            Console.WriteLine(CheckMonthOldWay(month));
            Console.WriteLine(CheckMonth(month));
        }

        public static string CheckMonth(Months month) =>
            month switch
            {
                Months.January => "Winter",
                Months.February => "Winter",
                Months.March => "Winter",
                Months.April => "Spring",
                Months.May => "Spring",
                Months.June => "Spring",
                Months.July => "Summer",
                Months.August => "Summer",
                Months.September => "Summer",
                Months.October => "Autumn",
                Months.November => "Autumn",
                Months.December => "Winter",
                _ => "Invalid Input"

            };
        public static string CheckMonthOldWay(Months month)
        {
            switch (month)
            {
                case Months.December:
                case Months.January:
                case Months.February:
                case Months.March:
                    return "Winter";

                case Months.April:
                case Months.May:
                case Months.June:
                    return "Spring";

                case Months.July:
                case Months.August:
                case Months.September:
                    return "Summer";

                case Months.October:
                case Months.November:
                    return "Autumn";

                default:
                    return "Invalid input";
            }
        }
    }
}
