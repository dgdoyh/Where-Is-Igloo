// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 2
// Submission Date: 2023-12-16

using MazeGame_Yeonhee.Classes;
using System;
using System.Windows.Forms;

namespace MazeGame_Yeonhee
{
    public partial class GameEndForm : Form
    {
        public GameEndForm(string text)
        {
            InitializeComponent();

            // Text generated based on Game clear/over
            lbMainText.Text = text;
        }

        private void pbRetry_Click(object sender, EventArgs e)
        {   
            // Restart the game
            GameManager.StartGame();
            GameManager.mainForm.isHintMode = false;
            GameManager.mainForm.Refresh();

            this.Close();
        }

        private void pbQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
