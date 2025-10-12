using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VerificadorContraseñas
{
    internal class createGame
    {
        string nickName,nickNameDisplayed,map,playerAdded,conf;
        int i = 0;
        int j;
        string[] maps = new string[] { "Dust2", "Train", "Nuke", "Mirage", "Cobblestone", "Anubis" };
        List<string> playerQueue = new List<string>();
        string[] Team1 = new string[5];
        string[] Team2 = new string[5];
        Random random = new Random();
        public int addPlayer()
        {
            Console.Clear();

            Console.Write("Player Nickname: ");
            nickName = Console.ReadLine();
            nickNameDisplayed = nickName ?? $"Player {i++}";
            playerQueue.Add(nickNameDisplayed);
            Console.WriteLine("\n PRESS ANY KEY TO CONTINUE...");
            Console.ReadKey();
            Console.Clear();
            return playerQueue.Count;
        }
        public void CreateGame()
        {
            Console.Clear();
            j = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            map = maps[random.Next(maps.Length)];
            
            Console.WriteLine($"\t\tGAME STARTED\nGamemode: Competitive \nMap: {map}");
            Console.ResetColor();
            Console.WriteLine("\nTEAM 1");
            foreach(string blank in Team1)
            {
                playerAdded = playerQueue.ToArray()[random.Next(playerQueue.Count)];
                Team1[j] = playerAdded;
                Console.WriteLine(playerAdded);
                playerQueue.Remove(playerAdded);
                

            }

            j = 0;
            Console.WriteLine("\nTEAM 2");
            foreach (string blank in Team2)
            {
                playerAdded = playerQueue.ToArray()[random.Next(playerQueue.Count)];
                Team2[j] = playerAdded;
                Console.WriteLine(playerAdded);
                playerQueue.Remove(playerAdded);
            }
           
            Console.WriteLine("\n PRESS ANY KEY TO CONTINUE...");
            Console.ReadKey();
            Console.Clear();

        }

        public void exitQueue()
        {
            Console.Write("IF THE PLAYER IS REMVOED FROM QUEUE MAY HAVE TO WAIT FOR LONGER \nCONFIRM REMOVING(Y/N): ");
            conf = Console.ReadLine();
            conf = conf.ToUpper();
            
            
            


            switch (conf)
            {
                case "Y":
                    Console.Write("\n\nQUEUE LIST: \n");
                    foreach(string player in playerQueue)
                    {
                        Console.WriteLine(player);
                    }
                    Console.Write("\n\nNICKNAME OF THE PLAYER WE NEED TO REMOVE: ");

                    nickNameDisplayed = Console.ReadLine();
                    playerQueue.Remove(nickNameDisplayed);
                    Console.WriteLine($"{nickNameDisplayed} SUCCESSFULLY REMOVED FROM QUEUE");
                  


                    break;
                case "N":
                 

                    break;
            }
            Console.WriteLine("\n PRESS ANY KEY TO CONTINUE...");
            Console.ReadKey();
            Console.Clear();

        }
        public void showQueue()
        {
            Console.Clear();
            foreach (string player in playerQueue)
            {
                Console.WriteLine(player);
                Thread.Sleep(200);

            }
            Console.WriteLine("\n PRESS ANY KEY TO CONTINUE...");
            Console.ReadKey();
            Console.Clear();
        }



    }
}
