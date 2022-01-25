using System;

namespace game1
{
    class Program
    {
        static void Main(string[] args)
        {
            var scena = new Scene(10);
            scena.scene[0, 0] = 1;
            scena.PlaceSpaceAroundShips(new Point(0, 0));
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(scena.scene[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
        
    }
}
