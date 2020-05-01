using System;

namespace GGProbability
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current points for Titans:");
            int TitanWins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current points for Warlocks:");
            int WarlockWins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current points for Hunters:");
            int HunterWins = Convert.ToInt32(Console.ReadLine());

            int UnassignedPoints = 28 - TitanWins - WarlockWins - HunterWins;
            Competition c = new Competition(TitanWins, WarlockWins, HunterWins, UnassignedPoints);
            c.recursiveResults();
        }   
    }
}
