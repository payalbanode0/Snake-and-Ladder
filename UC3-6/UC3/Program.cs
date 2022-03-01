using System;
using System.Collections.Generic;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable
            int rollDice, player1 = 0;
            int count = 0;

            //To generate random number
            Random random = new Random();
            //List to check options
            var list = new List<string> { "No Play", "Ladder", "Snake" };
            // 1 ->player 1 is playing . 
            int playerChange = 1;
            while (player1 <= 100)
            {
                //Print the current Player
                Console.WriteLine("Player: " + playerChange + " is playing \n");

                //Rolling dice
                rollDice = random.Next(1, 7);
                Console.WriteLine("Dice number is : " + rollDice + "\n");

                //Print user options
                Console.WriteLine("Player checks options 1.No Play  2.Ladder   3.Snake \n");

                //Use random to check user option
                int index = random.Next(list.Count);
                Console.WriteLine("Player option is : " + list[index] + "\n");


                //Goes to this loop if Player 1 is rolling dice
                if (playerChange == 1)
                {
                    //If option is "No Change" it will change player to 2
                    if (list[index] == "No Play" && playerChange == 1)
                    {
                        continue;
                    }

                    //If player option is "Snake" , position will go down and will change player to 2
                    if (list[index] == "Snake")
                    {
                        player1 -= rollDice;
                    }

                    //If after rolling rice player position <100 then it will increment the position of player to that of number of dice
                    if (player1 + rollDice < 100 && playerChange == 1)
                    {
                        if (list[index] == "Ladder") player1 += rollDice;
                    }



                    //If after rolling dice player reached "Exactly 100" then it will increment and come out of loop.Winner is Player 1
                    if (list[index] == "Ladder" && (player1 + rollDice == 100) && playerChange == 1)
                    {
                        player1 += rollDice;
                        break;
                    }

                    //If after getting "Snake" option , position is less than 0, then reset position to 0
                    if (player1 < 0 && list[index] == "Snake")
                    {
                        player1 = 0;
                    }

                    //Print to Console
                    Console.WriteLine("\n");
                    Console.WriteLine("Player 1 current position : " + player1);
                    count++;
                }
                Console.WriteLine("\n");
                //Print winner of 2Player Game
            }
            if (player1 == 100)
            {
                Console.WriteLine("Winner is player 1  :" + player1);
                Console.WriteLine("Final position of player 1  :" + player1);
            }
            else
            {
                Console.WriteLine("Final position of player 1  :" + player1);
                
            }
        }
    }
}
