namespace LibraryShadowsOfTheKnight
{
    public class Player
    {
        public Player()
        {
            Main(new string[0]);
        }
         void Main(string[] args)
        {
            string[] inputs;
            inputs = Console.ReadLine().Split(' ');
            int W = int.Parse(inputs[0]); // width of the building.
            int H = int.Parse(inputs[1]); // height of the building.
            int N = int.Parse(Console.ReadLine()); // maximum number of turns before game over.
            inputs = Console.ReadLine().Split(' ');
            int X0 = int.Parse(inputs[0]);
            int Y0 = int.Parse(inputs[1]);
            int yMax = H;
            int yMin = 0;
            int xMax = W;
            int xMin = 0;
            // game loop
            while (N > 0)
            {

                string bombDir = Console.ReadLine(); // the direction of the bombs from batman's current location (U, UR, R, DR, D, DL, L or UL)


                Console.Error.WriteLine($"width = {W}");
                Console.Error.WriteLine($"height = {H}");

                Console.Error.WriteLine($"{N}");

                Console.Error.WriteLine($"X0 = {X0}");
                Console.Error.WriteLine($"Y0 = {Y0}");

                Console.Error.WriteLine($"yMin = {yMin}");
                Console.Error.WriteLine($"yMax = {yMax}");

                Console.Error.WriteLine($"bombDir = {bombDir}");


                //int height = H;
                //int width = W;
                foreach (char c in bombDir)
                {
                    if (c == 'U')
                    {
                        yMax = Y0;
                        Y0 = ((yMax - yMin) / 2) + yMin;
                    }
                    if (c == 'D')
                    {
                        yMin = Y0;
                        Y0 = ((yMax - yMin) / 2) + yMin;
                    }
                    if (c == 'R')
                    {
                        xMin = X0;
                        X0 = ((xMax - xMin) / 2) + xMin;
                    }
                    if (c == 'L')
                    {
                        xMax = X0;
                        X0 = ((xMax - xMin) / 2) + xMin;
                    }
                }


                // Write an action using Console.WriteLine()
                // To debug: Console.Error.WriteLine("Debug messages...");


                // the location of the next window Batman should jump to.
                Console.WriteLine($"{X0} {Y0}");
                N--;
            }
        }
    }
}