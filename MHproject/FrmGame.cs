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
using System.Threading.Tasks;
using System.Windows.Forms;
using GameEngineDLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MHproject
{
    public partial class FrmGame : Form
    {
        //Constants\
        const int SQUARE_SIZE = 50;

        //variables
        Hunter myPlayer = new Hunter();
        Map Map = new Map();

        public bool gameWon = false;

        int monster1X = 7;
        int monster1Y = 3;

        int monster2X = 7;
        int monster2Y = 5;

        public FrmGame(string text, string username)
        {
            InitializeComponent();
            this.Text = username + " is now playing";
        }

        //jagged array 
        private char[][] mapArray = new char[][] { };

        private void LoadMapFromFile(string filename)
        {
            int Y = 0;
            foreach (string fileLine in System.IO.File.ReadAllLines(filename))
            {
                //convert the string into a char array
                char[] fileLineArray = fileLine.ToCharArray();

                Array.Resize(ref mapArray, mapArray.Length + 1);

                mapArray[mapArray.GetUpperBound(0)] = fileLineArray;

                //loop into fileLineArray to find the player and the monsters
                for (int X = 0; X < fileLineArray.Length; X++)
                {
                    if (fileLineArray[X] == 'H')
                    {
                        myPlayer.X = X;
                        myPlayer.Y = Y; // Correctly captures the Y coordinate
                    }
                }
                Y++; // Increment AFTER processing the line
            }
        }
        private void GUIDrawMap(char[][] map)
        {
            picPlayer.Width = SQUARE_SIZE;
            picPlayer.Height = SQUARE_SIZE;
            picMonster1.Width = SQUARE_SIZE;
            picMonster2.Width = SQUARE_SIZE;
            picMonster1.Height = SQUARE_SIZE;
            picMonster2.Height = SQUARE_SIZE;
            for (int Y = 0; Y < map.GetLength(0); Y++)
            {
                //loop in the 2nd dimension
                for (int X = 0; X < map[Y].Length; X++)
                {
                    if (map[Y][X] == '#')
                    {
                        PictureBox newWall = new PictureBox();
                        newWall.Name = "picWall" + X + "-" + Y;
                        newWall.Image = Properties.Resources.brickWallImage;
                        newWall.Width = SQUARE_SIZE; // dont forget to make it constants after
                        newWall.Height = SQUARE_SIZE;
                        newWall.SizeMode = PictureBoxSizeMode.StretchImage;
                        newWall.Left = X * SQUARE_SIZE; //dont forget to make it constants after
                        newWall.Top = Y * SQUARE_SIZE;
                        this.Controls.Add(newWall);
                    }

                }
                Console.WriteLine();
            }
            //draw the player
            picPlayer.Left = myPlayer.X * SQUARE_SIZE;
            picPlayer.Top = myPlayer.Y * SQUARE_SIZE;
            //draw the monster
            picMonster1.Left = monster1X * SQUARE_SIZE;
            picMonster1.Top = monster1Y * SQUARE_SIZE;
            picMonster2.Left = monster2X * SQUARE_SIZE;
            picMonster2.Top = monster2Y * SQUARE_SIZE;
        }


        private void btnCreateMap_Click(object sender, EventArgs e)
        {
            //error handling
            if (cboMaps.SelectedIndex == -1)
            {
                lblErrorMap.Visible = true;
                lblErrorMap.Text = "Please choose a map!";
            }
            else
            {
                lblErrorMap.Visible = false;

                picMonster1.Visible = true;
                picMonster2.Visible = true;
                picPlayer.Visible = true;

                LoadMapFromFile(cboMaps.Text);
                GUIDrawMap(mapArray);
            }

            //hiding GUI
            btnCreateMap.Visible = false;
            cboMaps.Visible = false;
        }


        private void FrmGame_Load(object sender, EventArgs e)
        {
            string[] mapfiles = Directory.GetFiles(@".", "*.txt");

            //list all the files in ....
            foreach (string eachFile in mapfiles)
            {
                cboMaps.Items.Add(eachFile);
            }

            picMonster1.Visible = false;
            picMonster2.Visible = false;
            picPlayer.Visible = false;
        }


    }
}
