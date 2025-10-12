using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorContraseñas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            // queue 5vs5 RAHHHdo
            int opt,playersInQueue;
            createGame game = new createGame();
            
            
            //if (playersInQueue == 10)
            //{
            //    game.CreateGame();
            //}
            Console.Clear();
            do
            {
                Console.Clear();
                Console.Write("SELECT \n1.ADD PLAYER TO QUEUE \n2.REMOVE PLAYER FROM QUEUE \n3.SHOW QUEUE LIST \nOPTION: ");
                opt = Convert.ToInt32(Console.ReadLine());
                opt = opt >= 1 && opt <= 3 ? opt : 4;
                switch (opt)
                {
                    case 1:
                        playersInQueue = game.addPlayer();
                        if (playersInQueue == 10)
                        {
                            game.CreateGame();
                        }
                        break;
                    case 2:
                        game.exitQueue();
                        break;
                    case 3:
                        game.showQueue();

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("PLEASE INPUT A VALID OPTION");
                        Console.WriteLine("\n PRESS ANY KEY TO CONTINUE...");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                }




            } while (opt >= 1 && opt <= 4);

        }
    }
}
