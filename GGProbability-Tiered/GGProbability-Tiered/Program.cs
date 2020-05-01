using System;

namespace GGProbability_Tiered
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the current 1st place victories for Titans:");
            int TitanWins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current 2nd place entries for Titans:");
            int TitanSeconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current 3rd place losses for Titans:");
            int TitanLosses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current 1st place victories for Warlocks:");
            int WarlockWins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current 2nd place entries for Warlocks:");
            int WarlockSeconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current 3rd place losses for Warlocks:");
            int WarlockLosses = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current 1st place victories for Hunters:");
            int HunterWins = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current 2nd place entries for Hunters:");
            int HunterSeconds = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the current 3rd place losses for Hunters:");
            int HunterLosses = Convert.ToInt32(Console.ReadLine());

            int UnassignedPoints = 28 - TitanWins - WarlockWins - HunterWins;
            Competition c = new Competition(TitanWins, TitanSeconds, TitanLosses, WarlockWins, WarlockSeconds, WarlockLosses, HunterWins, HunterSeconds, HunterLosses, UnassignedPoints);
            c.recursiveResults();
        }
    }
}
