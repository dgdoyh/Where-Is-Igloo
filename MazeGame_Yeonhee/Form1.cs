// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 2
// Submission Date: 2023-12-16

using System;
using System.Drawing;
using System.Windows.Forms;
using MazeGame_Yeonhee.Classes;
using MazeGame_Yeonhee.Classes.Pathfinding;
using MazeGame_Yeonhee.Classes.Entities;

namespace MazeGame_Yeonhee
{
    // MAIN FORM
    public partial class Form1 : Form
    {
        public bool isHintMode = false;

        public Form1()
        {
            InitializeComponent();

            // Start the game
            GameManager.StartGame();
            // Set mainForm as this
            GameManager.SetMainForm(this);

            // Set a size of the game map
            int mapHeight = Map.mapTotalRows * Map.tileSize;
            int mapWidth = Map.mapTotalColumns * Map.tileSize;

            // Set a size of the pbMap (picture box)
            this.pbMap.Height = mapHeight;
            this.pbMap.Width = mapWidth;

            // Set a size of the Form
            this.ClientSize = new Size(mapWidth, mapHeight + lbLives.Size.Height);
        }

        private void pbMap_Paint(object sender, PaintEventArgs e)
        {
            // Draw all the tiles
            foreach (TileBase tile in Map.tiles)
            {
                tile.Draw(e.Graphics);
            }

            // Draw player on the Player position
            GameManager.player.Draw(e.Graphics);
            
            if (isHintMode)
            {
                // Find the shortest path
                GameManager.player.FindPath();
                // Draw path
                GameManager.player.DrawPath(e.Graphics);
            }

            // Display current player's lives and energies
            lbLives.Text = "Lives: " + GameManager.player.CurrLives.ToString();
            lbEnergies.Text = "Energies: " + GameManager.player.Energies.ToString();
            lbWallBreakers.Text = "Wall Breakers: " + GameManager.player.CurrWallBreakers.ToString();
        }

        // Getting input for movement
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // If isGameStop is false, you cannot move player
            if (!GameManager.isGameStop)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        GameManager.player.CurrentState = PlayerState.UP;
                        GameManager.player.Move();
                        break;

                    case Keys.Down:
                        GameManager.player.CurrentState = PlayerState.DOWN;
                        GameManager.player.Move();
                        break;

                    case Keys.Left:
                        GameManager.player.CurrentState = PlayerState.LEFT;
                        GameManager.player.Move();
                        break;

                    case Keys.Right:
                        GameManager.player.CurrentState = PlayerState.RIGHT;
                        GameManager.player.Move();
                        break;
                }
                // Refresh this form (Form1)
                this.Refresh();
            }
        }

        private void pbHint_Click(object sender, EventArgs e)
        {
            // Turn on/off the hint mode
            if (!isHintMode) { isHintMode = true; }
            else { isHintMode = false; }

            // Refresh the form so the path line immediately gets turned on/off.
            this.Refresh();
        }
    }
}
