using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Juan Aguirre

namespace Black_Jack
{
    class BlackJack
    {
        static void Main(string[] args)
        {
            int playerCardValue = 0;
            int dealerCardValue = 0;

            Random random = new Random();

            playerCardValue += random.Next(1,12); // generates a random number from 1 -11
            playerCardValue += random.Next(1,12); //  generates a random number from 1 -11

            if (playerCardValue > 21)
            {
                playerCardValue -= 10;
            }

            dealerCardValue += random.Next(1, 12); // generates a random number from 1 -11
            dealerCardValue += random.Next(1, 12); // generates a random number from 1 -11

            if (dealerCardValue > 21)
            {
                dealerCardValue -= 10;
            }

            // Players turn 

            while (true)
            {
                if (playerCardValue == 21)
                {
                    Console.WriteLine(" You are at 21 !! ");
                    break;
                }
                Console.WriteLine("My Card Value: " + playerCardValue.ToString()  + " Hit?");

                string choice = Console.ReadLine();

                if (choice == "y")
                {
                    playerCardValue += random.Next(1,12); // Generates a random card value between 1 - 11

                    if (playerCardValue > 21)
                    {
                        Console.WriteLine(" You Busted !! hahah !!");
                        break;
                    }
                    else
                    {
                        continue;
                    }


                }
                else if (choice == "n")
                {
                    break;
                }

                else
                {
                    Console.WriteLine(" Enter a valid response, try again!! ");
                    continue;
                }
                 
            }

            // Dealers turn

            Console.WriteLine(" Players card value is " +  playerCardValue.ToString());

            if (playerCardValue <= 21)
            {
                // Player has not busted 
                while (dealerCardValue < 21 && dealerCardValue < playerCardValue)
                {
                    dealerCardValue += random.Next(1, 12);
                }

                // Check for winner
                if (playerCardValue == dealerCardValue)
                {
                    Console.WriteLine("Its a tie!!");
                }
                else if (playerCardValue < dealerCardValue && dealerCardValue <= 21)
                {
                    Console.WriteLine(" The dealer has won !! ");
                }
                else if (dealerCardValue > 21)
                {
                    Console.WriteLine(" Dealer has busted, you won!! ");
                }
                  
                  else if (dealerCardValue == 21)
                {
                    Console.WriteLine(" Dealer has won, you busted hahahaha !!");
                }
            }

            else
            {
                Console.WriteLine(" Dealer has won, you busted hahahaha !!");
            }

            Console.WriteLine(" Dealers value: " + dealerCardValue.ToString());
            Console.ReadLine();



        }
    }
}
