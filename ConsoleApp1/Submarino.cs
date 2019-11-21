using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Submarino : Boat
    {
        public Submarino()
        {
            name = "Submarino";
            lives = 3;
            moveSpaces = 3;
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

        public void Hundirse(Board px)
        {
            
        }
    }
}
