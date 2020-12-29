using System;

namespace cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var overlord = new overlord();
            overlord.RunAsync().GetAwaiter().GetResult();
        }
    }
}
