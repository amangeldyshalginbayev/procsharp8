using System;

namespace SimpleDispose
{
    public class MyResourceWrapper : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("***** Inside MyResourceWrapper.Dispose() *****");
        }
    }
}