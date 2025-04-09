namespace FlareSolverrSharp.Sample
{
    internal static class Program
    {
        private static void Main()
        {
            ClearanceHandlerSample.SampleGet().Wait();
            ClearanceHandlerSample.SamplePostUrlEncoded().Wait();
        }
    }
}