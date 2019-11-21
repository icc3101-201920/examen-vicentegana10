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
        internal int turn;

        public Game()
        {
            players = new Player[2] { new Player(), new Player() };
            boards  = new Board[2]  { new Board(),  new Board()  };
            Console.WriteLine(players[1]);
            Console.ReadKey();
        }

        

}
}
