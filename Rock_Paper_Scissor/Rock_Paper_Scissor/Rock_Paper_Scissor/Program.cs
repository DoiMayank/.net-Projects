using System;

namespace Rock_Paper_Scissor
{
    class Program
    {
        static void Main(string[] args)

            
        {
            Random random = new Random();
            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to rock paper scissor!");

            while(playerScore != 3 && enemyScore != 3)
            {
                Console.WriteLine("Player score - " + playerScore + ". Enemy score - " + enemyScore);
                Console.WriteLine("Please enter 'r' for rock, 'p' for paper or anything else for scissor");
                string playerChoice = Console.ReadLine();

                int enemyChoice = random.Next(0, 3);

                if(enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock");
                    switch(playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins this round. ");
                            playerScore++;                          
                            break;
                        default:
                            Console.WriteLine("Enemy won this round.");
                            enemyScore++;
                            break;
                    }
                }
                else if(enemyChoice == 1)
                {
                    Console.WriteLine("Enemy chooses paper");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy won this round");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");
                            
                            break;
                        default:
                            Console.WriteLine("Player wins this round.");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy chooses scissor");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins this round.");
                            playerScore++; 
                            break;
                        case "p":
                            Console.WriteLine("Enemy won this round");

                            break;
                        default:
                            Console.WriteLine("Tie!");
                            enemyScore++;
                            break;
                    }
                }
            }

            if(playerScore == 3) 
            {
                Console.WriteLine("You Win 1");
            }
            else
            {
                Console.WriteLine("You Lose !");
            }
        }
    }
}