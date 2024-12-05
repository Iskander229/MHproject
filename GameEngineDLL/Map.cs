//   ISKANDER TANIYEV            11/30/2024 2:40     FINISHED CONSOLE MAP;
//   ISKANDER TANIYEV            11/30/2024 3:45     FINISHED MOVEMENT IN MAP;



using Microsoft.Win32;
using System;
using System.IO;
using System.Reflection.Emit;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Xml.Linq;
using static GameEngineDLL.Monster;

namespace GameEngineDLL
{
    public class Map
    {
        //constants

        //Player instance
        public Hunter myPlayer = new Hunter();

        //sword instance
        public Sword CurrentSword { get; private set; }

        //Map array to hold the map layout
        public char[][] mapArray = new char[][] { };

        //variables for rendering info
        public string playerName = "";
        public string pickedMap = "";
        public string infos = "";
        public string currentLevel = "";


        //Load map from a file
        public void LoadMapFromFile(string filename)
        {

            int Y = 0;

            foreach (string fileLine in System.IO.File.ReadAllLines(filename))
            {
                //convert the string into a char array
                char[] fileLineArray = fileLine.ToCharArray();

                Array.Resize(ref mapArray, mapArray.Length + 1);

                mapArray[mapArray.GetUpperBound(0)] = fileLineArray;
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

        // Method to draw the map for console
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
            CurrentSword = new Sword();

            //Ensure the new position is within map bounds
            if (newX >= 0 && newY >= 0 && newY < mapArray.Length && newX < mapArray[newY].Length)
            {
               
                //Check if the new position is a wall
                if (mapArray[newY][newX] == '#')
                {
                    return;
                }

                //check if new pos is a goal
                if (mapArray[newY][newX] == 'G')
                {
                    infos = "PLAYER HAS WON!";
                    Console.Clear();
                    Console.WriteLine($"{myPlayer.Name} Has Won!");
                
                }

                //if meet with a sword
                if (mapArray[newY][newX] == 'w')
                {
                    infos = "...";

                    infos = "A Sword!";

                    myPlayer.FindSword();
                }

                if (mapArray[newY][newX] == 'M')
                {
                    
                    infos = "Monster!!";
                    //method for takin damage

                    myPlayer.TakeDamage(20);
                    //method for sword attacking
                    myPlayer.EncounterMonster();

                    // Check if the player is dead
                    if (myPlayer.IsDead())
                    {
                        infos = "You have died!";
                        Console.Clear();
                        Console.WriteLine("Game Over! Your character has died.");
                        Console.ReadKey();
                        Environment.Exit(0); // Exit the game
                    }
                }

                if (mapArray[newY][newX] == 'p')
                {
                    infos = "...";
                    infos = "Healing!";
                    myPlayer.currentHP += 15;
                }

                mapArray[newY][newX] = ' '; // Replace the item with a space

               
                

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



        //Info rendering method
        public void RenderInfos(string playerName, string currentLevel, int currentHP, string infos, int pickedMap)
        {   //in the top right corner of the console
            int infoStartX = Console.WindowWidth - 30;
            int infoStartY = 0;

            Console.SetCursorPosition(infoStartX, infoStartY);
            Console.WriteLine($"Player Name: {playerName}");

            Console.SetCursorPosition(infoStartX, infoStartY + 1); // starts from new line
            Console.WriteLine($"Level: {currentLevel}");

            Console.SetCursorPosition(infoStartX, infoStartY + 3);
            Console.WriteLine($"HP: {currentHP}");

            Console.SetCursorPosition(infoStartX, infoStartY + 4);
            Console.WriteLine($"Info: {infos}");
        }
    }
}
