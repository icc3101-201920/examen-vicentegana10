using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player
    {
        List<Boat> botes;  // una vez que las vidas de cada bote se acaben estos se van sacando de la lista, una vez q la lista este vacia se acaba el juego
        Board ownBoard;
        //Constructor
        public Player()
        {
            
            Fragata frag = new Fragata();
            botes.Add(frag);

            Portaavion port = new Portaavion();
            botes.Add(port);

            Radar rad = new Radar();
            botes.Add(rad);

            Reparador rep = new Reparador();
            botes.Add(rep);

            Submarino sub = new Submarino();
            botes.Add(sub);
        }

        public List<Boat> Botes { get => botes; set => botes = value; }

        public void placeBoat(int largo,Player player)  // me va a permitir colocar un barco en el tablero, segun su largo
        {
            Console.WriteLine("Posicion en x de la punta del barco?");
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
            Console.WriteLine("Posicion en y de la punta del barco?");
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
            Console.WriteLine("la parte final del barco va hacia? arriba(0) derecha(1) izquierda(2) abajo(3)");
            string option = Console.ReadLine();

            if (option == "0")
            {
                
            }
        }
    }
}
