using System;

namespace UC1andUC2
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            int rollDice, player = 1;

            //To generate random number
            Random random = new Random();
            
            //Print the current Player
            Console.WriteLine("Player: " + player + " is playing \n");

            //Rolling dice
            rollDice = random.Next(1, 7);
            Console.WriteLine("Dice number is : " + rollDice + "\n");

        }

    }
}