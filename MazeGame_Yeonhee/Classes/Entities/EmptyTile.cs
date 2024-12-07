// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 2
// Submission Date: 2023-12-16

using System;
using System.Drawing;

namespace MazeGame_Yeonhee.Classes.Entities
{
    public class EmptyTile : TileBase
    {
        public EmptyTile(int row, int column) : base(row, column, 0) { }

        public override void Draw(Graphics graphics)
        {
            base.DrawBackground(graphics);
        }
    }
}
