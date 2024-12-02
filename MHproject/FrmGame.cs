//     Iskander Taniyev       12/1/2024 10:22      Finished smallest requirements for game console and windows forms. Feeling a bit cooked


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private void GUIDrawMap(char[][] map)
        {
            picPlayer.Width = 50;
            picPlayer.Height = 50;
            picMonster1.Width = 50;
            picMonster2.Width = 50;
            picMonster1.Height = 50;
            picMonster2.Height = 50;
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
                        newWall.Width = 50; // dont forget to make it constants after
                        newWall.Height = 50;
                        newWall.SizeMode = PictureBoxSizeMode.StretchImage;
                        newWall.Left = X * 50; //dont forget to make it constants after
                        newWall.Top = Y * 50;
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
            picMonster1.Visible = true;
            picMonster2.Visible = true;
            picPlayer.Visible = true;

            LoginForm myFormGame = new LoginForm();
           
            Map.LoadMapFromFile(myFormGame.cboMaps.Text);
            GUIDrawMap(Map.mapArray);
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {
            picMonster1.Visible = false;
            picMonster2.Visible = false;
            picPlayer.Visible = false;
            picWall.Visible = false;
        }

   
    }
}
