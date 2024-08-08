namespace NewStuffInCSharp8
{
    class DisposableRefStructs
    {
        static void Output()
        {
            using (var car = new Car())
            {
                Console.WriteLine("My car is very cool.");
            }
        }
    }

    //ref struct Car : IDisposable // raise CS8343 error：ref can not implement interface
    //{

    //}

    ref struct Car
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose Method is Called");
        }
    }
}
