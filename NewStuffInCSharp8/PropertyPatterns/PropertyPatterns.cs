namespace NewStuffInCSharp8
{
    public enum Cities
    {
        Vienna,
        Berlin,
        Amsterdam,
        Madrid,
        Budapest,
        Paris,
        London,
        Warsaw,
        Prague,
        Melbourne
    }
    public class City
    {
        public Cities CityName { get; set; }
        public string CountryName { get; set; }

        public City(Cities city, string country)
        {
            CityName = city;
            CountryName = country;
        }
    }
    class PropertyPatterns
    {
        static void Output()
        {
            City viennaAus = new City(Cities.Vienna, "Austria");
            City parisFr = new City(Cities.Paris, "France");
            City parisUS = new City(Cities.Paris, "USA");

            Console.WriteLine(CheckPrices(viennaAus));
            Console.WriteLine(CheckPrices(parisUS));

        }

        public static string CheckPrices(City city) =>
            city switch
            {
                { CityName: Cities.Vienna } => $"{city.CityName} is above Average [cost of living]",
                { CityName: Cities.Budapest } => $"{city.CityName} is resonable [cost of living]",
                { CityName: Cities.Paris, CountryName: "USA" } => "Average",
                //{ CityName: Cities.Paris, CountryName: "France" } => "High",
                { CityName: Cities.Paris } => $"{city.CityName}, {city.CountryName} is high",
                _ => "City is not covered"
            };
    }
}
