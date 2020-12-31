using System;

namespace overlord
{
    class Program
    {
        static void Main(string[] args)
        {
            var bodyguard = new Bodyguard();
            bodyguard.RunAsync().GetAwaiter().GetResult();
        }
    }
}
