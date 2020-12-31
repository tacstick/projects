using System;

namespace overlordns
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
