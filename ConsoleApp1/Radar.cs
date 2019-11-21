using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Radar : Boat
    {
        public Radar()
        {
            name = "Radar";
            lives = 1;
            moveSpaces = 1;
        }
        //Propiedades
        public int lives
        {
            get
            {
                return this.lives;
            }
            set
            {
                this.lives = value;
            }
        }

        public int moveSpaces
        {
            get
            {
                return this.moveSpaces;
            }
            set
            {
                this.moveSpaces = value;
            }
        }

        public string name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public void Detectar()
        {
            int posicionX = Visualization.GetUserInput();
            if (posicionX == 99)
            {
               
                while (posicionX != 99)
                {
                    Console.WriteLine("error");
                    int posicionX1 = Visualization.GetUserInput();
                    posicionX = posicionX1;
                }
            }
            int posicionY = Visualization.GetUserInput();
            if (posicionY == 99)
            {

                while (posicionY != 99)
                {
                    Console.WriteLine("error");
                    int posicionY1 = Visualization.GetUserInput();
                    posicionY = posicionY1;
                }
            }
            //ahora que tengo la posicion buscar el 3x3

        }
    }
}
