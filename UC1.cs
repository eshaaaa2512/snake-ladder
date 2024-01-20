using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake_ladder
{
    internal class Program
    {
        static void Main()


        {
            int playerposition = 0;
            Console.WriteLine("Hello,Welcome to snake and ladder game");

            while (playerposition <= 100)
            {
                Console.WriteLine("Current position of the player:" + (playerposition));
                Console.WriteLine("Roll the dice");
               

                int playerRandomNum;
                Random random = new Random();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("Outcome : " + (playerRandomNum));
                


                int option = random.Next(0, 3);

                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play. Stay in the same position.");
                        break;

                    case 1:
                        Console.WriteLine($"Ladder! Move ahead by " + playerRandomNum + "positions.");
                        playerposition += playerRandomNum;
                        break;

                    case 2:
                        Console.WriteLine("Snake! Move behind by " + playerRandomNum + " positions.");
                        if (playerRandomNum == 0)
                        {
                            playerposition += playerRandomNum;
                        }
                        else if (playerRandomNum > 0)
                        {
                            playerRandomNum += playerRandomNum;

                        }
                        else
                        {
                            playerposition = Math.Max(playerposition, 0);
                            Console.WriteLine("Congratulation, U reached the final position");
                        }
                        break;
                }

                            


                        
                }
                Console.ReadLine();
            }
        }

    }


                            




     



                



                


                





                        

        








            

        
    

