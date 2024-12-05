//   ISKANDER TANIYEV            11/30/2024 2:40     FINISHED CONSOLE MAP;
//   ISKANDER TANIYEV            11/30/2024 3:45     FINISHED MOVEMENT IN MAP;

//     Iskander Taniyev       12/1/2024 10:22      Finished smallest requirements for game console Feeling a bit cooked
using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Threading;
using GameEngineDLL;

namespace GameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int pickedMap = 0;

            //an instance of the DLL classes
            Hunter myPLayer = new Hunter();
            Character DLLVal = new Character(); 
            Map DLLMap = new Map();


            Console.WriteLine("Please type your name (25 char max):");

            //Loop until valid input
            do
            {
                DLLMap.playerName = Console.ReadLine();

                // Set the name from DLL for validation in setter
                DLLVal.Name = DLLMap.playerName;

                // If validation error occurred, show the message
                if (DLLVal.ValidationErrorsOccurred)
                {
                    Console.WriteLine(DLLVal.ValidationError); // Print the validation error message
                    Console.WriteLine("Please try again:");
                }

            } while (DLLVal.ValidationErrorsOccurred); 

            Console.WriteLine("Welcome, " + DLLMap.playerName + "!");
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

                    //Load the selected map
                    switch (pickedMap)
                    {
                        case 1:
                            DLLMap.LoadMapFromFile("FirstLevel.txt");
                            DLLMap.currentLevel = "Level One!";
                            break;
                        case 2:
                            DLLMap.LoadMapFromFile("SecondLevel.txt");
                            DLLMap.currentLevel = "Level Two!";
                            break;
                        case 3:
                            DLLMap.LoadMapFromFile("ThirdLevel.txt");
                            DLLMap.currentLevel = "Level Three!";
                            break;
                        default:
                            throw new Exception("Wrong map selection.");
                    }


                    //Validate map choice
                    if (pickedMap < 1 || pickedMap > 3)
                    {
                        throw new Exception("Choice must be between 1 and 3.");
                    }

                    mapLoaded = true; //Exit loop if success
                }
                //Exceptions if map was not loaded
                catch (Exception e)
                {
                    Console.WriteLine($"Unexpected error", e);
                }
            }
            
            Console.Clear(); //Clearing the console for the map

            Console.WriteLine("Map loaded!");
            //Draw the map (from instances)
            DLLMap.DrawMap();

            //GAME INFOS:

            

            //MOVEMENT
            //player variables
            ConsoleKeyInfo keyPressed;
            do
            {
                DLLMap.RenderInfos(
                DLLMap.playerName,
                DLLMap.currentLevel,
                DLLMap.myPlayer.currentHP,  // Pass currentHP
                DLLMap.infos,
                pickedMap
                );

                

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


            } while (DLLMap.myPlayer.currentHP > 0);
           
        }
    }
}
