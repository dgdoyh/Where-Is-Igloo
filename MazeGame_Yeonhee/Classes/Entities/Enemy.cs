// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 2
// Submission Date: 2023-12-16

using System;
using System.Drawing;
using MazeGame_Yeonhee.Classes.Pathfinding;

namespace MazeGame_Yeonhee.Classes.Entities
{
    public class Enemy : TileBase
    {
        private static string[] enemyImages = { "Orca.png", "Shark.png" };
        private string selectedEnemyName;

        // For enemies, energies value is their attack damage.
        public Enemy(int row, int column) : base(row, column, 0)
        {
            int count = Enemy.enemyImages.Length;
            // Get a random index for foodImages
            int index = RNG.Get_Instance().Next(0, count);

            // Set different energy value (attack damage) for the each enemies
            if (index == 0)
            { base.Energies = 8; }  // Orca
            else
            { this.Energies = 18; }  // Shark

            // Get a name of enemyImages[index]
            this.selectedEnemyName = Enemy.enemyImages[index];
        }

        public override void Draw(Graphics graphics)
        {
            Rectangle frame = base.DrawBackground(graphics);

            // Draw the enemy image on the tile
            using (Image enemyImage = Image.FromFile(Map.pathToResources + selectedEnemyName))
            {
                graphics.DrawImage(enemyImage, frame);
                // Delete the image data from the memory after drawing it.
            }
        }
    }
}
