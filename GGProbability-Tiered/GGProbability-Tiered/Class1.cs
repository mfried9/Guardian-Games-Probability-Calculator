using System;
using System.Collections.Generic;
using System.Text;

namespace GGProbability_Tiered
{
    class Competition
    {
        public int HunterPoints, TitanPoints, WarlockPoints = 0;
        public long PossibleOutcomes, HunterVictories, TitanVictories, WarlockVictories, TitanWarlockTies, TitanHunterTies, WarlockHunterTies, AllTie = 0;
        public double HVPercent, TVPercent, WVPercent, TWTPercent, THTPercent, WHTPercent, ATPercent = 0;
        public int UnassignedPoints = 0;

        public Competition()
        {
        }

        public Competition(int TW, int TS, int TT, int WW, int WS, int WT, int HW, int HS, int HT, int UP)
        {
            TitanPoints = TW * 3 + TS * 2 + TT * 1;
            WarlockPoints = WW * 3 + WS * 2 + WT * 1;
            HunterPoints = HW * 3 + HS * 2 + HT * 1;
            UnassignedPoints = UP;
        }

        public void recursiveResults()
        {
            int temp;
            if (UnassignedPoints <= 14)
            {
                temp = 2;
                
            }
            else
            {
                temp = 1;
            }

            recursiveResults(TitanPoints + 3 * temp, WarlockPoints + 2 * temp, HunterPoints + 1 * temp, UnassignedPoints - temp);
            recursiveResults(TitanPoints + 3 * temp, WarlockPoints + 1 * temp, HunterPoints + 2 * temp, UnassignedPoints - temp);
            recursiveResults(TitanPoints + 2 * temp, WarlockPoints + 3 * temp, HunterPoints + 1 * temp, UnassignedPoints - temp);
            recursiveResults(TitanPoints + 2 * temp, WarlockPoints + 1 * temp, HunterPoints + 3 * temp, UnassignedPoints - temp);
            recursiveResults(TitanPoints + 1 * temp, WarlockPoints + 3 * temp, HunterPoints + 2 * temp, UnassignedPoints - temp);
            recursiveResults(TitanPoints + 1 * temp, WarlockPoints + 2 * temp, HunterPoints + 3 * temp, UnassignedPoints - temp);

            TVPercent = (double)TitanVictories / (double)PossibleOutcomes;
            WVPercent = (double)WarlockVictories / (double)PossibleOutcomes;
            HVPercent = (double)HunterVictories / (double)PossibleOutcomes;
            TWTPercent = (double)TitanWarlockTies / (double)PossibleOutcomes;
            THTPercent = (double)TitanHunterTies / (double)PossibleOutcomes;
            WHTPercent = (double)WarlockHunterTies / (double)PossibleOutcomes;
            ATPercent = (double)AllTie / (double)PossibleOutcomes;

            Console.WriteLine("Total Number of Outcomes: " + PossibleOutcomes);
            Console.WriteLine("Number of Titan Victories: " + TitanVictories);
            Console.WriteLine("Number of Warlock Victories: " + WarlockVictories);
            Console.WriteLine("Number of Hunter Victories: " + HunterVictories);
            Console.WriteLine("Number of Titan/Warlock Ties: " + TitanWarlockTies);
            Console.WriteLine("Number of Titan/Hunter Ties: " + TitanHunterTies);
            Console.WriteLine("Number of Warlock/Hunter Ties: " + WarlockHunterTies);
            Console.WriteLine("Number of Complete Ties: " + AllTie);

            Console.WriteLine("\n\nPercentages: ");
            Console.WriteLine("Titan Victory: " + Math.Round(TVPercent * 100, 2) + "%");
            Console.WriteLine("Warlock Victory: " + Math.Round(WVPercent * 100, 2) + "%");
            Console.WriteLine("Hunter Victory: " + Math.Round(HVPercent * 100, 2) + "%");
            Console.WriteLine("Titan/Warlock Tie: " + Math.Round(TWTPercent * 100, 2) + "%");
            Console.WriteLine("Titan/Hunter Tie: " + Math.Round(THTPercent * 100, 2) + "%");
            Console.WriteLine("Warlock/Hunter Tie: " + Math.Round(WHTPercent * 100, 2) + "%");
            Console.WriteLine("Complete Tie: " + Math.Round(ATPercent * 100, 2) + "%");
        }

        public void recursiveResults(int TP, int WP, int HP, int UP)
        {
            if (UP <= 0 || TP >= 71 || HP >= 71 || WP >= 71)
            {
                if (TP == HP && TP == WP)
                    AllTie++;
                else if (TP > HP && TP > WP)
                    TitanVictories++;
                else if (TP == HP && TP > WP)
                    TitanHunterTies++;
                else if (TP > HP && TP == WP)
                    TitanWarlockTies++;
                else if (WP > HP && WP > TP)
                    WarlockVictories++;
                else if (WP == HP && WP > TP)
                    WarlockHunterTies++;
                else if (HP > TP && HP > WP)
                    HunterVictories++;
                else
                    Console.WriteLine("Error: Uncaught position condition. Numbers as follows:\nTitan Points: " + TP + "\nWarlock Points: " + WP + "\nHunter Points: " + HP);

                PossibleOutcomes++;
            }
            else if (UP <= 14)
            {
                recursiveResults(TP + 6, WP + 4, HP + 2, UP - 2);
                recursiveResults(TP + 6, WP + 2, HP + 4, UP - 2);
                recursiveResults(TP + 4, WP + 6, HP + 2, UP - 2);
                recursiveResults(TP + 4, WP + 2, HP + 6, UP - 2);
                recursiveResults(TP + 2, WP + 4, HP + 6, UP - 2);
                recursiveResults(TP + 2, WP + 6, HP + 4, UP - 2);
            }
            else
            {
                recursiveResults(TP + 3, WP + 2, HP + 1, UP - 1);
                recursiveResults(TP + 3, WP + 1, HP + 2, UP - 1);
                recursiveResults(TP + 2, WP + 3, HP + 1, UP - 1);
                recursiveResults(TP + 2, WP + 1, HP + 3, UP - 1);
                recursiveResults(TP + 1, WP + 2, HP + 3, UP - 1);
                recursiveResults(TP + 1, WP + 3, HP + 2, UP - 1);
            }
        }
    }
}

