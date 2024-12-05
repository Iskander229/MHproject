//     Iskander Taniyev       12/1/2024 10:22      Finished smallest requirements for game console and windows forms. Feeling a bit cooked

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

namespace MHproject
{
    public partial class LoginForm : Form
    {

        //global variable in the form
        FrmGame myGameForm = null;


        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Character val = new Character();
            val.Name = txtPlayerName.Text;

            do
            {
                // If validation errors occurred
                if (val.ValidationErrorsOccurred)
                {
                    lblErrorMap.Visible = true;
                    lblErrorMap.Text = val.ValidationError;
                    return;
                }

            } while (val.ValidationErrorsOccurred);

            myGameForm = new FrmGame("", txtPlayerName.Text);

            MessageBox.Show("The GAME has started!");

            myGameForm.ShowDialog(); // opening from modal

            if (myGameForm.gameWon)
            {
                MessageBox.Show(txtPlayerName.Text + " won the game");
            }
            else
            {
                MessageBox.Show(txtPlayerName.Text + " left the game");
            }


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
