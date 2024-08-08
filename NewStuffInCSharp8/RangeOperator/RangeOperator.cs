using System;

namespace NewStuffInCSharp8
{
    public class RangeOperator
    {
        public static void Output()
        {
            var cities = new string[] {
                "New york", //0 - 5
                "Vienna",   //1 - 4
                "Madrid",   //2 - 3
                "London",   //3 - 2
                "Cairo",     //4 - 1  
                "Tokoyo"
            };

            //var copyCities = cities[0..3];
            //var copyCities = cities[^2..^1];
            //var copyCities = cities[..];
            //var copyCities = cities[..3];
            var copyCities = cities[0..];

            foreach (var city in copyCities)
            {
                Console.WriteLine(city);
            }

            Range cityRange = 0..6;
            Console.WriteLine(cityRange.Start);
            Console.WriteLine(cityRange.End);

            var newCities = cities[cityRange];
            foreach (var city in newCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
