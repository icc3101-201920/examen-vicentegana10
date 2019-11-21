using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Game
    {
        public Player[] players;
        public Board[] boards;
        public int turn;
        
        public Game()
        {
            players = new Player[2] { new Player(), new Player() };
            boards  = new Board[2]  { new Board(),  new Board()  };
            turn = 0;
            Console.WriteLine("colocar botes j1");
            foreach (Boat boat in players[0].Botes)
            {
                players[0].placeBoat(boat.Lives, boat, boards[0]);
            }
            Console.WriteLine("colocar botes j2");
            foreach (Boat boat in players[1].Botes)
            {
                players[1].placeBoat(boat.Lives, boat, boards[1]);
            }

            while (true)
            {
                Console.WriteLine("que desea hacer? atacar(0) mover (1) special(2)");
                string option = Console.ReadLine();
                if (option == "0")
                {
                    players[turn].attack(boards[turn]);

                }
            }
        }

        public int GetWinner()
        {
            
            if (players[0].Botes.Count== 0 && players[1].Botes.Count > 0)
            {
                return 1;
            }
            else if (players[1].Botes.Count == 0 && players[0].Botes.Count > 0)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

    }
}
