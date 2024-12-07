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
    public class Igloo : TileBase
    {
        public Igloo(int row, int column) : base(row, column, 0) { }

        public override void Draw(Graphics graphics)
        {
            Rectangle frame = base.DrawBackground(graphics);

            // Draw the igloo image on the tile
            using (Image playerImage = Image.FromFile(Map.pathToResources + "Igloo.png"))
            {
                graphics.DrawImage(playerImage, frame);
                // Delete the image data from the memory after drawing it.
            }
        }
    }
}
