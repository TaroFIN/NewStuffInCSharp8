namespace NewStuffInCSharp8
{
    class Resource : IDisposable
    {
        public void Use() => Console.WriteLine("Using Resource...");
        public void Dispose() => Console.WriteLine("Disposing Resource..");
    }
    class UsingDeclarations
    {
        static void Output()
        {
            //var resource = new Resource();
            //resource.Use();
            //Console.WriteLine("This app is awesome");

            //output：Using Resource...
            //        This app is awesome


            //using var resource = new Resource();
            //resource.Use();
            //Console.WriteLine("This app is awesome");

            //output：Using Resource...
            //        This app is awesome
            //        Disposing Resource..

            using (var resource = new Resource())
            {
                resource.Use();
            }
            Console.WriteLine("This app is awesome");

            //output：Using Resource...
            //        Disposing Resource..
            //        This app is awesome

        }
    }
}
