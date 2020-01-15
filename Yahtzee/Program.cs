using System;

namespace Yahtzee
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dice = new int[] { 1, 2, 3, 4, 5, 6 };
            Random random = new Random();

            int rolOne = dice[random.Next(0, dice.Length)];
            int rolTwo = dice[random.Next(0, dice.Length)];
            int rolThree = dice[random.Next(0, dice.Length)];
            int rolFour = dice[random.Next(0, dice.Length)];
            int rolFive = dice[random.Next(0, dice.Length)];
            int rolSix = dice[random.Next(0, dice.Length)];
            int comRolOne = dice[random.Next(0, dice.Length)];
            int comRolTwo = dice[random.Next(0, dice.Length)];
            int comRolThree = dice[random.Next(0, dice.Length)];


            string rollOne = rolOne.ToString();
            string rollTwo = rolTwo.ToString();
            string rollThree = rolThree.ToString();
            string rollFour = rolFour.ToString();
            string rollFive = rolFive.ToString();
            string rollSix = rolSix.ToString();
            string compRollOne = comRolOne.ToString();
            string compRollTwo = comRolTwo.ToString();
            string compRollThree = comRolThree.ToString();


            Console.WriteLine("Welcome to yahtzee. Your first roll is");
            Console.WriteLine($"{rollOne}, {rollTwo}, {rollThree}");
            Console.WriteLine("Do you wish to re-roll? yes or no");

            string input = Console.ReadLine();

            if (input == "no")
            {
                Console.WriteLine($"The computer's roll is {compRollOne}, {compRollTwo}, {compRollThree}.");
            }

            if (input == "yes")
            {
                Console.WriteLine($"Your second roll is {rollFour}, {rollFive}, {rollSix}.");
                Console.WriteLine($"The computer's roll is {compRollOne}, {compRollTwo}, {compRollThree}.");
            }

            Console.ReadLine();

        }
    }
}
