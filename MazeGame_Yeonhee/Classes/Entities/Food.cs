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
    public class Food : TileBase
    {
        private static string[] foodImages = { "Crab.png", "Fish.png", "Lobster.png" };
        private string selectedFoodName;

        public Food(int row, int column) : base(row, column, 12)
        {
            int count = foodImages.Length;
            // Get a random index for foodImages
            int index = RNG.Get_Instance().Next(0, count);

            // Set different energy value for each food
            if (index == 0)
            { base.Energies = 12; }  // Crab
            if (index == 1)
            { this.Energies = 22; }  // Fish
            else
            { this.Energies = 32; }  // Lobster

            // Get a name of foodImages[index]
            this.selectedFoodName = foodImages[index];
        }

        public override void Draw(Graphics graphics)
        {
            Rectangle frame = base.DrawBackground(graphics);

            // Draw the food image on the tile
            using (Image foodImage = Image.FromFile(Map.pathToResources + selectedFoodName))
            {
                graphics.DrawImage(foodImage, frame);
                // Delete the image data from the memory after drawing it.
            }
        }
    }
}
