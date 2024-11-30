//   ISKANDER TANIYEV            11/30/2024 2:40     FINISHED CONSOLE MAP;
//   ISKANDER TANIYEV            11/30/2024 3:45     FINISHED MOVEMENT IN MAP;


using System;
using System.Threading;
using GameEngineDLL;

namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string playerName;
            int pickedMap = 0;

            //an instance of the DLL classes
            var DLLValidation = new Player(); 
            var DLLMap = new Map();

            Console.WriteLine("Please type your name (25 char max):");

            //Loop until valid input
            do
            {
                playerName = Console.ReadLine();

                //Set the name from dll for validation in setter
                DLLValidation.Name = playerName; 

                //error message
                if (DLLValidation.ValidationErrorsOccurred)
                {
                    Console.WriteLine(DLLValidation.ValidationError);
                    Console.WriteLine("Please try again:");
                }

            } while (DLLValidation.ValidationErrorsOccurred);

            Console.WriteLine("Welcome, " + DLLValidation.Name + "!");
            Thread.Sleep(1000);
            Console.WriteLine("Please Pick a map: \n 1: FirstLevel\n 2: SecondLevel\n 3: ThirdLevel");

            // Map selection
            bool mapLoaded = false;
            while (!mapLoaded)
            {
                try
                {
                    string mapChoice = Console.ReadLine();

                    //Validate and parse input
                    if (!int.TryParse(mapChoice, out pickedMap))
                    {
                        throw new FormatException("Input must be a number.");
                    }

                    //Validate map choice
                    if (pickedMap < 1 || pickedMap > 3)
                    {
                        throw new Exception("Choice must be between 1 and 3.");
                    }

                    //Load the selected map
                    switch (pickedMap)
                    {
                        case 1:
                            DLLMap.LoadMapFromFile("FirstLevel.txt");
                            break;
                        case 2:
                            DLLMap.LoadMapFromFile("SecondLevel.txt");
                            break;
                        case 3:
                            DLLMap.LoadMapFromFile("ThirdLevel.txt");
                            break;
                        default:
                            throw new Exception("Wrong map selection.");
                    }

                    mapLoaded = true; //Exit loop if success
                }
                //Exceptions if map was not loaded
                catch (Exception e)
                {
                    Console.WriteLine($"Unexpected error, Please try again. {e.Message}");
                }
            }

            Console.WriteLine("Map loaded!");
            //Draw the map (from instances)
            Console.Clear(); //Clearing the console for the map
            DLLMap.DrawMap();

            //MOVEMENT
            //player variables
            ConsoleKeyInfo keyPressed;
            do
            {
                keyPressed = Console.ReadKey(true);

                switch (keyPressed.Key)
                {
                    case ConsoleKey.A:
                        DLLMap.MovePlayer(DLLMap.myPlayer.X - 1, DLLMap.myPlayer.Y); //Move left
                        break;
                    case ConsoleKey.D:
                        DLLMap.MovePlayer(DLLMap.myPlayer.X + 1, DLLMap.myPlayer.Y); //Move right
                        break;
                    case ConsoleKey.W:
                        DLLMap.MovePlayer(DLLMap.myPlayer.X, DLLMap.myPlayer.Y - 1); //Move up
                        break;
                    case ConsoleKey.S:
                        DLLMap.MovePlayer(DLLMap.myPlayer.X, DLLMap.myPlayer.Y + 1); //Move down
                        break;
                }

            } while (keyPressed.Key != ConsoleKey.Escape); //Press Escape to end the game

            Console.WriteLine("Game Over!");
        }
    }
}
