using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryShadowsOfTheKnight
{
    class Player2
    {
        static void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int W = int.Parse(inputs[0]); // width of the building.
            int H = int.Parse(inputs[1]); // height of the building.
            int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
            inputs = Console.ReadLine().Split(' ');
            int X0 = int.Parse(inputs[0]);
            int Y0 = int.Parse(inputs[1]);



            // game loop
            while (true)
            {
                string bombDir = Console.ReadLine(); // Current distance to the bomb compared to previous distance (COLDER, WARMER, SAME or UNKNOWN)
                int X = 0;
                int Y = 0;
                Console.Error.WriteLine($"width = {W}");
                Console.Error.WriteLine($"height = {H}");

                Console.Error.WriteLine($"X0 = {X0}");
                Console.Error.WriteLine($"Y0 = {Y0}");

                if (bombDir == "WARMER")
                {
                  //  int wid = Math.Sqrt(Math.Round(X - X0) + Math.Round(Y - Y0));
                }
                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");

                Console.WriteLine("4 10");
            }
        }
    }
}
