using System;

namespace TurnBased
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 40;
            int enemyHp = 20;

            int playerAttack = 5;
            int enemyAttack = 7;

            int healAmount = 5;
            while(playerHp > 0 && enemyHp > 0)
            {
                //Player turn
                Console.WriteLine("-- Player Turn--");
                Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp );
                Console.WriteLine("Enter 'a' to attack or 'h' to heal");

                string choice = Console.ReadLine();
                Random random = new Random();

                if(choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + "damage!");

                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("Plaer restores " + healAmount + " health points");

                }

                if(enemyHp > 0)
                {
                    Console.WriteLine("-- Enemy Turn --");
                    Console.WriteLine("Player Hp - " + playerHp + ". Enemy Hp - " + enemyHp);

                    int enemyChoice = random.Next(0,2);

                    if(enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + "damage!");

                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points");
                    }
                }
            }

            if(playerHp > 0)
            {
                Console.WriteLine("Congratulations, you have won !");

            }
            else
            {
                Console.WriteLine(" You Lose !");
            }
        }
    }
}