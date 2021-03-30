using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;

            bool playAgain = true;

            while (playAgain == true)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {

                    Console.Write("Choose between ROCK, PAPER and SCISSORS: ");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer.ToUpper() == "ROCK")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer.ToUpper() == "PAPER")
                            {
                                Console.WriteLine("PLAYR WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer.ToUpper() == "SCISSORS")
                            {
                                Console.WriteLine("COMPUTER WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer.ToUpper() == "PAPER")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer.ToUpper() == "SCISSORS")
                            {
                                Console.WriteLine("PLAYR WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer.ToUpper() == "ROCK")
                            {
                                Console.WriteLine("COMPUTER WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer.ToUpper() == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!\n\n");
                            }
                            else if (inputPlayer.ToUpper() == "ROCK")
                            {
                                Console.WriteLine("PLAYR WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer.ToUpper() == "PAPER")
                            {
                                Console.WriteLine("COMPUTER WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry");
                            break;
                    }//switch

                    Console.WriteLine("Scores:\t\tPlayer: {0}\tComputer: {1}", scorePlayer, scoreCPU);


                }//while loop

                if (scorePlayer == 3)
                {
                    Console.WriteLine("PLAYER WINS!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("COMPUTER WINS!!");
                }

                Console.Write("Do you want to play again?(y/n): ");
                string loop = Console.ReadLine();

                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Inalid entry!");
                }

            }// palyAgain while

            Console.Write("Press enter to continue.......");
            Console.ReadLine();

        }//main
    }//class
}
