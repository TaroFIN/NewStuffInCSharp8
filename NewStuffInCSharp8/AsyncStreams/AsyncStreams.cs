using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NewStuffInCSharp8
{
    public class AsyncStreams
    {
        public static async Task Output()
        {
            foreach (var prod in GetProducts())
            {
                Console.WriteLine(prod);
            }
            Console.WriteLine("--------");

            await foreach (var prod in GetProductsAsync())
            {
                Console.WriteLine(prod);
            }
        }

        static IEnumerable<string> GetProducts()
        {
            yield return "Getting Products...";
            yield return "Product 1";
            yield return "Product 2";
            yield return "Product 3";

        }

        static async IAsyncEnumerable<string> GetProductsAsync()
        {
            yield return "Getting Products...";
            await Task.Delay(2000);
            yield return "Product 1";
            await Task.Delay(2000);
            yield return "Product 2";
            await Task.Delay(2000);
            yield return "Product 3";
        }
    }
}
