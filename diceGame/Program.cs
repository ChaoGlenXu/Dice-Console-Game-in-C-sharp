using System;

namespace diceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int playerDice;
            int aiDice;

            int playerScore = 0; 
            int aiScore = 0; 

            Random random = new Random();

            for (int i = 0; i < 5; i++) {
                Console.WriteLine("press enter key to roll the dice!");

                Console.ReadKey();

                playerDice = random.Next(1,7);

                Console.WriteLine("Your dice number is : " + playerDice);

                Console.WriteLine(".....");
                System.Threading.Thread.Sleep(2000);

                aiDice = random.Next(1, 7);
                Console.WriteLine("The AI's Dice dice number is : " + aiDice);

                if (playerDice > aiDice)
                { //player won
                    playerScore++;
                    Console.WriteLine("Player wins this time!");
                }
                else if (playerDice < aiDice)
                { //player lost
                    aiScore++;
                    Console.WriteLine("AI wins this time !");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now Player: " + playerScore + " AI: " + aiScore);
                Console.WriteLine();
            }
            if (playerScore > aiScore)
            { //player won
                
                Console.WriteLine("Player won");
            }
            else if (playerScore < aiScore)
            { //player lost
                Console.WriteLine("AI won!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.WriteLine("This game is over, thank you for playing it!");
        }
    }
}
