# Guardian Games Probability Calculator
 Hi! This repo holds two small programs I wrote to calculate and generate the possible outcomes of Destiny 2's Guardian Games event. These programs work based off of recursive functions, and other than the expontential time complexity if you were to run it from the beginning of the event the programs are lightweight and shouldn't take too long to execute. 
 
 For those of you who do not know, the Guardian Games is essentially a competition between the three classes: Titans, Warlocks, and Hunters. Each day, the classes compete to see who gets 1st, 2nd, and 3rd place. Since Bungie hasn't been super clear on the scoring method, I had to make some assumptions. Also, the event goes on for three weeks, but the last week all gained points are doubled.
 
 There are two programs, GGProbability and GGProbability Tiered. The first was the original program, which uses an All-Or-Nothing based branching in which only the victor each day gains any points. In this scenario, there are 28 possible points (7 per week the first two weeks, 14 for the last week). A class achieves victory by either gaining 15 points or by having the highest number of points at the end.
 
 In the second program, a Tiered Placement system was used. In this system, 1st place gains 3 points, 2nd gains 2, and 3rd gains 1. In this system a total of 168 points will be distributed, with 71 being needed to achieve early majority victory.
 
 Both programs are simple console apps that will ask you to input the current statistics to run the simulations. I tried to make it fairly straightforward, but I didn't spend too much time on it, maybe an hour and a half. Since the Tiered version is a modified program of the first, the source code will be pretty similar. Also, once the program finishes the results will be displayed in both numerical and percentage listings.
 
 I hope anyone reading this enjoys this simple program!
