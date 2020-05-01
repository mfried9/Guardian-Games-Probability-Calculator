using System;
using System.Collections.Generic;
using System.Text;

namespace GGProbability
{
    class Competition
    {
        public int HunterPoints, TitanPoints, WarlockPoints = 0;
        public int PossibleOutcomes, HunterVictories, TitanVictories, WarlockVictories, TitanWarlockTies, TitanHunterTies, WarlockHunterTies, AllTie = 0;
        public double HVPercent, TVPercent, WVPercent, TWTPercent, THTPercent, WHTPercent, ATPercent = 0;
        public int UnassignedPoints = 0;

        public Competition()
        {
        }

        public Competition(int TW, int WW, int HW, int UP)
        {
            TitanPoints = TW;
            WarlockPoints = WW;
            HunterPoints = HW;
            UnassignedPoints = UP;
        }

        public void recursiveResults()
        {
            if (UnassignedPoints <= 14)
            {
                recursiveResults(TitanPoints + 2, WarlockPoints, HunterPoints, UnassignedPoints - 2);
                recursiveResults(TitanPoints, WarlockPoints + 2, HunterPoints, UnassignedPoints - 2);
                recursiveResults(TitanPoints, WarlockPoints, HunterPoints + 2, UnassignedPoints - 2);
            } else
            {
                recursiveResults(TitanPoints + 1, WarlockPoints, HunterPoints, UnassignedPoints - 1);
                recursiveResults(TitanPoints, WarlockPoints + 1, HunterPoints, UnassignedPoints - 1);
                recursiveResults(TitanPoints, WarlockPoints, HunterPoints + 1, UnassignedPoints - 1);
            }

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
            Console.WriteLine("Titan Victory: " + Math.Round(TVPercent*100, 2) + "%");
            Console.WriteLine("Warlock Victory: " + Math.Round(WVPercent * 100, 2) + "%");
            Console.WriteLine("Hunter Victory: " + Math.Round(HVPercent * 100, 2) + "%");
            Console.WriteLine("Titan/Warlock Tie: " + Math.Round(TWTPercent * 100, 2) + "%");
            Console.WriteLine("Titan/Hunter Tie: " + Math.Round(THTPercent * 100, 2) + "%");
            Console.WriteLine("Warlock/Hunter Tie: " + Math.Round(WHTPercent * 100, 2) + "%");
            Console.WriteLine("Complete Tie: " + Math.Round(ATPercent * 100, 2) + "%");
        }

        public void recursiveResults(int TP, int WP, int HP, int UP)
        {
            if (UP <= 0 || TP >= 15 || HP >= 15 || WP >= 15)
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
            } else if (UP <= 14)
            {
                recursiveResults(TP + 2, WP, HP, UP - 2);
                recursiveResults(TP, WP + 2, HP, UP - 2);
                recursiveResults(TP, WP, HP + 2, UP - 2);
            } else
            {
                recursiveResults(TP + 1, WP, HP, UP - 1);
                recursiveResults(TP, WP + 1, HP, UP - 1);
                recursiveResults(TP, WP, HP + 1, UP - 1);
            }
        }

        public void results()
        {
            if (UnassignedPoints <= 0)
            {
                if (TitanPoints == HunterPoints && TitanPoints == WarlockPoints)
                    AllTie++;
                else if (TitanPoints > HunterPoints && TitanPoints > WarlockPoints)
                    TitanVictories++;
                else if (TitanPoints == HunterPoints && TitanPoints > WarlockPoints)
                    TitanHunterTies++;
                else if (TitanPoints > HunterPoints && TitanPoints == WarlockPoints)
                    TitanWarlockTies++;
                else if (WarlockPoints > HunterPoints && WarlockPoints > TitanPoints)
                    WarlockVictories++;
                else if (WarlockPoints == HunterPoints && WarlockPoints > TitanPoints)
                    WarlockHunterTies++;
                else if (HunterPoints > TitanPoints && HunterPoints > WarlockPoints)
                    HunterVictories++;
                else
                    Console.WriteLine("Error: Uncaught position condition. Numbers as follows:\nTitan Points: " + TitanPoints + "\nWarlock Points: " + WarlockPoints + "\nHunter Points: " + HunterPoints);

                PossibleOutcomes++;
            }
            else
            {
                int tempWinPoints;
                if (UnassignedPoints <= 14)
                    tempWinPoints = 2;
                else
                    tempWinPoints = 1;


            }


        }
    }
}
