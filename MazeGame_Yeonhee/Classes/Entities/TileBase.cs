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
    // Base of all the tiles
    public abstract class TileBase
    {
        private int row;
        private int column;
        private int energies;

        protected TileBase(int row, int column, int energies)
        {
            this.row = row;
            this.column = column;
            this.energies = energies;
        }

        public int Row { get => row; set => row = value; }
        public int Column { get => column; set => column = value; }
        public int Energies { get => energies; set => energies = value; }

        public abstract void Draw(Graphics graphics);

        public Rectangle DrawBackground(Graphics graphics)
        {
            Rectangle frame;

            // Set a start point to draw a frame
            int pointX = this.Column * Map.tileSize;
            int pointY = this.Row * Map.tileSize;

            // Make a tile-sized rectangle frame to draw an image on it
            frame = new Rectangle(pointX, pointY, Map.tileSize, Map.tileSize);

            // Draw the empty tile image on the frame.
            using (Image emptyTileimage = Image.FromFile(Map.pathToResources + "Floor.png"))
            {
                graphics.DrawImage(emptyTileimage, frame);
                // Delete the image data from the memory after drawing it.
            }

            // Return the frame so it can be reused.
            return frame;
        }
    }
}
