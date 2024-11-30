//   ISKANDER TANIYEV            11/30/2024 2:40     FINISHED CONSOLE MAP;
//   ISKANDER TANIYEV            11/30/2024 3:45     FINISHED MOVEMENT IN MAP;



using System;
using System.IO;

namespace GameEngineDLL
{
    public class Map
    {
        //Player instance
        public Player myPlayer = new Player();

        //Map array to hold the map layout
        public char[][] mapArray;

        //Load map from a file
        public void LoadMapFromFile(string filename)
        {
            int Y = 0;
            mapArray = new char[File.ReadAllLines(filename).Length][];

            foreach (string fileLine in File.ReadAllLines(filename))
            {
                //Convert the string into a char array
                char[] fileLineArray = fileLine.ToCharArray();
                mapArray[Y] = fileLineArray;

                //Loop through fileLineArray to find the player
                for (int X = 0; X < fileLineArray.Length; X++)
                {
                    if (fileLineArray[X] == 'H')
                    {
                        myPlayer.X = X; 
                        myPlayer.Y = Y; 
                    }
                }
                Y++; 
            }
        }

        // Method to draw the map
        public void DrawMap()
        {
            //cursor at the top left corner
            Console.SetCursorPosition(0, 0); 
            Console.BackgroundColor = ConsoleColor.Yellow;

            for (int Y = 0; Y < mapArray.GetLength(0); Y++)
            {
                for (int X = 0; X < mapArray[Y].Length; X++)
                {
                    //draw 
                    Console.Write(mapArray[Y][X]); 
                    Console.ForegroundColor = ConsoleColor.Gray; 
                }
                Console.WriteLine();
            }
            //Draw the player
            Console.SetCursorPosition(myPlayer.X, myPlayer.Y);
            Console.ForegroundColor= ConsoleColor.Green;
            Console.Write('H');
        }

        //Method to move the player
        public void MovePlayer(int newX, int newY)
        {
            //Ensure the new position is within map bounds
            if (newX >= 0 && newY >= 0 && newY < mapArray.Length && newX < mapArray[newY].Length)
            {
                //Check if the new position is a wall
                if (mapArray[newY][newX] == '#')
                {
                    return;
                }

                //Clear the previous player position
                Console.SetCursorPosition(myPlayer.X, myPlayer.Y);
                Console.Write(' ');

                //Update player's position
                myPlayer.X = newX;
                myPlayer.Y = newY;

                //Draw player at new position
                Console.SetCursorPosition(myPlayer.X, myPlayer.Y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('H');
            }
        }
    }
}
