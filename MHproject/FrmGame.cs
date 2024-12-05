//     Iskander Taniyev       12/1/2024 10:22      Finished smallest requirements for game console and windows forms. Feeling a bit cooked

//   ISKANDER TANIYEV            11/30/2024 3:45     FINISHED basic game in windows forms as in the console
//   
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameEngineDLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MHproject
{
    public partial class FrmGame : Form
    {

        //constants
        const int SQUARE_SIZE = 50;

        //instances
        Hunter myPlayer = new Hunter();

        List<Monster> monsters = new List<Monster>();

        List<PictureBox> monsterPictures = new List<PictureBox>();

        Sword currentSword = new Sword();

        PictureBox newWall = new PictureBox();

        //variables
        public bool gameWon = false;

        bool readyToMove = true;

        private char[][] mapArray = new char[][] { };

        public FrmGame(string text, string username)
        {
            InitializeComponent();
            this.Text = $"{username} is now playing";
        }

        //loading form textfile
        private void LoadMapFromFile(string filename)
        {
            int Y = 0;
            foreach (string fileLine in File.ReadAllLines(filename))
            {
                char[] fileLineArray = fileLine.ToCharArray();
                Array.Resize(ref mapArray, mapArray.Length + 1);
                mapArray[mapArray.GetUpperBound(0)] = fileLineArray;

                for (int X = 0; X < fileLineArray.Length; X++)
                {
                    if (fileLineArray[X] == 'H')
                    {
                        myPlayer.X = X;
                        myPlayer.Y = Y;
                    }
                    else if(fileLineArray[X] == 'M')
                    {
                        CreateMonster(X, Y);
                    }
                 
                }
                Y++;
            }
        }

        //method for creating monsters
        private void CreateMonster(int x, int y)
        {
            Monster monster = new Monster(x, y)
            {
                monsterPictureBox = new PictureBox
                {
                    //monster properties
                    Width = SQUARE_SIZE,
                    Height = SQUARE_SIZE,
                    Left = x * SQUARE_SIZE,
                    Top = y * SQUARE_SIZE,
                    Image = Properties.Resources.susPlayerImage, //monster image
                    SizeMode = PictureBoxSizeMode.StretchImage
                }
            };
            //adding them
            monsters.Add(monster);
            this.Controls.Add(monster.monsterPictureBox);
            monsterPictures.Add(monster.monsterPictureBox);
        }

        private void MoveMonsters()
        {
            foreach (var monster in monsters)
            {
                monster.Move(mapArray, myPlayer);
                monster.monsterPictureBox.Left = monster.X * SQUARE_SIZE;
                monster.monsterPictureBox.Top = monster.Y * SQUARE_SIZE;
            }
        }

        //drawing the map in GUI
        private void GUIDrawMap()
        {
            picPlayer.Width = SQUARE_SIZE;
            picPlayer.Height = SQUARE_SIZE;

            for (int Y = 0; Y < mapArray.GetLength(0); Y++)
            {
                for (int X = 0; X < mapArray[Y].Length; X++)
                {
                    if (mapArray[Y][X] == '#')
                    {
                        PictureBox newWall = new PictureBox
                        {
                            Name = $"picWall{X}-{Y}",
                            Image = Properties.Resources.brickWallImage,
                            Width = SQUARE_SIZE,
                            Height = SQUARE_SIZE,
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Left = X * SQUARE_SIZE,
                            Top = Y * SQUARE_SIZE
                        };
                        this.Controls.Add(newWall);
                    }
                }
            }
            //drawing player in the map
            picPlayer.Left = myPlayer.X * SQUARE_SIZE;
            picPlayer.Top = myPlayer.Y * SQUARE_SIZE;
        }


        //starting the map chosen
        private void btnCreateMap_Click(object sender, EventArgs e)
        {
            if (cboMaps.SelectedIndex == -1)
            {
                lblErrorMap.Visible = true;
                lblErrorMap.Text = "Please choose a map!";
            }
            else
            {
                lblErrorMap.Visible = false;
                picPlayer.Visible = true;
                btnCreateMap.Visible = false;
                cboMaps.Visible = false;

                LoadMapFromFile(cboMaps.Text);
                GUIDrawMap();
            }
            MoveMonsters();
        }


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

                //check if new pos is a goal
                if (mapArray[newY][newX] == 'G')
                {
                    lblInfos.Text = "PLAYER HAS WON!";
                    gameWon = true;
                    

                }
           
                if (mapArray[newY][newX] == 'M')
                {

                    lblInfos.Text = "Monster!!";
                    //method for takin damage
                    myPlayer.TakeDamage(20);
                    lblcurrentHP.Text = myPlayer.currentHP.ToString();
                    //method for sword attacking
                    myPlayer.EncounterMonster();

                    // Remove the monster and its picture from the game
                    RemoveMonster(newX, newY);


                    // Check if the player is dead
                    if (myPlayer.IsDead())
                    {
                        lblInfos.Text = "You have died!";
                        Thread.Sleep(3000);
                        Application.Exit();
                    }
                }

                if (mapArray[newY][newX] == 'p')
                {
                    lblInfos.Text = "...";
                    lblInfos.Text = "Healing!";
                    myPlayer.currentHP += 15;
                    lblcurrentHP.Text = myPlayer.currentHP.ToString();
                }

                //Clear the previous player position

                //Update player's position
                myPlayer.X = newX;
                myPlayer.Y = newY;
            }
        }

       

        //adding maps from textfiles to combobox
        private void FrmGame_Load(object sender, EventArgs e)
        {
            //without keypreview no movement in GUI
            this.KeyPreview = true;

            string[] mapfiles = Directory.GetFiles(@".", "*.txt");
            foreach (string eachFile in mapfiles)
            {
                cboMaps.Items.Add(eachFile);
            }
            picPlayer.Visible = false;
        }

        private void FrmGame_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString().ToLower())
            {
                
                case "a":
                    //move left
                    if (readyToMove && myPlayer.X > 0)
                    {
                        if (mapArray[myPlayer.Y][myPlayer.X - 1] != '#')
                        {

                            MovePlayer(myPlayer.X - 1, myPlayer.Y); //Move left

                            readyToMove = false;
                            Thread moveUpThread = new Thread(new ThreadStart(this.moveLeftPlayerSlowlyInChildThread));
                            moveUpThread.IsBackground = true; //if close main thread, it will close the child thread
                            moveUpThread.Start();
                        }

                    }
                    break;

                case "d":
                    //move right
                    if (readyToMove)
                    {
                        if (myPlayer.X < mapArray[myPlayer.Y].Length - 1)
                        {
                            if ((mapArray[myPlayer.Y][myPlayer.X + 1] != '#'))
                            {
                                MovePlayer(myPlayer.X + 1, myPlayer.Y); //Move right

                                readyToMove = false;
                                Thread moveUpThread = new Thread(new ThreadStart(this.moveRightPlayerSlowlyInChildThread));
                                moveUpThread.IsBackground = true; //if close main thread, it will close the child thread
                                moveUpThread.Start();
                            }
                        }
                    }
                    break;


                case "w":
                    //move up
                    if (readyToMove && myPlayer.Y > 0)
                    {   //detect collison with the walls
                        if (mapArray[myPlayer.Y - 1][myPlayer.X] != '#')
                        {//ok, we can move
                            MovePlayer(myPlayer.X, myPlayer.Y - 1); //Move up

                            readyToMove = false;
                            Thread moveUpThread = new Thread(new ThreadStart(this.moveUpPlayerSlowlyInChildThread));
                            moveUpThread.IsBackground = true; //if close main thread, it will close the child thread
                            moveUpThread.Start();
                        }
                        //Thread.Sleep(1000); //this will FREEZE my app for one second
                    }
                    break;

                case "s":
                    //move down
                    if (readyToMove)
                    {
                        if (myPlayer.Y < mapArray.GetLength(0) - 1)
                        {
                            if (mapArray[myPlayer.Y + 1][myPlayer.X] != '#')
                            {
                                MovePlayer(myPlayer.X, myPlayer.Y + 1); //Move down

                                readyToMove = false;
                                Thread moveUpThread = new Thread(new ThreadStart(this.moveDownPlayerSlowlyInChildThread));
                                moveUpThread.IsBackground = true; //if close main thread, it will close the child thread
                                moveUpThread.Start();
                            }
                        }
                    }
                    break;
            }

        }


        //delegate for communication
        private delegate void movePlyerBetweenThreads(int XVelocity, int YVelocity, bool doneMoving);

        //In the main thread, we need to move teh pictureBOX
        private void movePlayerByOneFrame(int XVelocity, int YVelocity, bool doneMoving)
        {
            picPlayer.Left = picPlayer.Left + XVelocity;
            picPlayer.Top = picPlayer.Top + YVelocity;

            if (doneMoving)
            {
                readyToMove = true;
            }
        }

        private void movePlayerSlowlyInChildThread(int XVelocity, int YVelocity)
        {
            int squareSize = 50;
            //use constant
            int sleepTime = 1000 / squareSize;

            for (int i = 1; i <= squareSize; i++)
            {
                Thread.Sleep(sleepTime);

                Invoke(new movePlyerBetweenThreads(movePlayerByOneFrame),
                    new object[] { XVelocity, YVelocity, i == squareSize });
            }
        }
        //function to move the player slowly in another thread
        private void moveUpPlayerSlowlyInChildThread()
        {
            int XVelocity = 0;
            int YVelocity = -1;
            movePlayerSlowlyInChildThread(XVelocity, YVelocity);
        }
        //function to move the player slowly in another thread
        private void moveDownPlayerSlowlyInChildThread()
        {
            int XVelocity = 0;
            int YVelocity = 1;
            movePlayerSlowlyInChildThread(XVelocity, YVelocity);
        }
        //function to move the player slowly in another thread
        private void moveLeftPlayerSlowlyInChildThread()
        {
            int XVelocity = -1;
            int YVelocity = 0;
            movePlayerSlowlyInChildThread(XVelocity, YVelocity);
        }
        //function to move the player slowly in another thread
        private void moveRightPlayerSlowlyInChildThread()
        {
            int XVelocity = 1;
            int YVelocity = 0;
            movePlayerSlowlyInChildThread(XVelocity, YVelocity);
        }

        //delete map without overlapping the system when you want to start a new level.
        private void DeleteMap(object sender, EventArgs e)
        {
            // to delete ALL the walls
            foreach (Control control in this.Controls)
            {

                if (control.Name.Substring(0, 7) == "picWall")
                {
                    control.Dispose();
                }
            }
            monsters.Clear();  // Clear 
            monsterPictures.Clear();  
        }

        // Method to remove the monster from the game
        private void RemoveMonster(int x, int y)
        {
            // Find the monster based on the coordinates (x, y)
            var monsterToRemove = monsters.FirstOrDefault(monster => monster.X == x && monster.Y == y);
            if (monsterToRemove != null)
            {
                // Remove the PictureBox from the form
                this.Controls.Remove(monsterToRemove.monsterPictureBox);

                // Dispose the PictureBox 
                monsterToRemove.monsterPictureBox.Dispose();

                // Remove the monster from the monsters list 
                monsters.Remove(monsterToRemove);
                monsterPictures.Remove(monsterToRemove.monsterPictureBox);
            }
        }
    }
}