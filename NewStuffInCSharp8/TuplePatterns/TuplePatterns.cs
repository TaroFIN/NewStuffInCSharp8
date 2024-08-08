namespace NewStuffInCSharp8
{
    class TuplePatternsApp
    {
        public static void Output()
        {
            Console.WriteLine(CheckPrices("Vienna", "Austria"));
            Console.WriteLine(CheckPrices("Paris", "France"));
            Console.WriteLine(CheckPrices("Paris", "US"));
            Console.WriteLine("--------");
            Console.WriteLine(CheckPrices("Vienna", "Austria", "German"));
            Console.WriteLine(CheckPrices("Paris", "FR", "FR"));
        }

        public static string CheckPrices(string city, string country, string language) =>
            (city, country, language) switch
            {
                ("Vienna", "Austria", "German") => "Above Average",
                ("Paris", "France", "French") => "Pretty High",
                ("Paris", "USA", "English") => "Average",
                ("Paris", _, _) => "Pretty High",
                (_, _, _) => "Invalid Input"
            };

        public static string CheckPrices(string city, string country) =>
            (city, country) switch
            {
                ("Vienna", "Austria") => "Above Average",
                ("Paris", "France") => "Pretty High",
                ("Paris", "USA") => "Average",
                ("Paris", _) => "Pretty High",
                (_, _) => "Invalid Input"
            };

    }
}
