using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int RandomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;


            Console.WriteLine("Choose between ROCK, PAPER and SCISSOR:    ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random RND = new Random();
            RandomInt = RND.Next(1, 4);

            switch (RandomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer Chooses ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                        Console.ReadLine();
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("PLAYER WIN!!\n\n");
                        scorePlayer++;
                        Console.ReadLine();
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                        Console.ReadLine();

                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer Chooses PAPER");
                    if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                        Console.ReadLine();
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("CPU WIN!!\n\n");
                        scoreCPU++;
                        Console.ReadLine();
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("PLAYER WINS!!\n\n");
                        scorePlayer++;
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    inputCPU = "SCISSOR";
                    Console.WriteLine("Computer Chooses SCISSOR");
                    if (inputPlayer == "SCISSOR")
                    {
                        Console.WriteLine("DRAW!!\n\n");
                        Console.ReadLine();
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("PLAYER WIN!!\n\n");
                        scorePlayer++;
                        Console.ReadLine();
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("CPU WINS!!\n\n");
                        scoreCPU++;
                        Console.ReadLine();
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    Console.ReadLine();
                    break;
            
            
            







            }
        }
    }
}
