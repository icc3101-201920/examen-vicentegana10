using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Visualization
    {
        public static int GetUserInput()
        {
            int value;

            if (int.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }
            else
            {
                return 99; //usar como numero de error
            }

        }
    }
}
