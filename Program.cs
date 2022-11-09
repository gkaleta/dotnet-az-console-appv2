// sample dotnet app that writes to the console for Spot instances

using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i > 0; i++)
            {
                    // send a msg every sec
                    Thread.Sleep(1000);
                    //set UTC timestamp
                    var Timestamp = new DateTimeOffset(DateTime.UtcNow);
                    //write to console
                    Console.WriteLine("Msg #{0} Spot-demo-app timestamp is " + Timestamp, i);
                    
            }
        
        }
    }
}