using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Boat
    {
        //Atributos
        string name;
        int lives;
        int moveSpaces;
        int[] positionI;
        int[] positionF;
        // bool horizontal;

        public Boat() { }

        public string Name { get => name; set => name = value; }
        public int Lives { get => lives; set => lives = value; }
        public int MoveSpaces { get => moveSpaces; set => moveSpaces = value; }
        public int[] PositionI { get => positionI; set => positionI = value; }
        public int[] PositionF { get => positionF; set => positionF = value; }
    }

}
