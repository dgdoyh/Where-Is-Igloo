// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 1
// Submission Date: 2023-12-12

using System;
using System.IO;
using MazeGame_Yeonhee.Classes.Entities;

namespace MazeGame_Yeonhee.Classes.Pathfinding
{
    public static class Map
    {
        // Other class cannot modify readonly variables
        public static readonly int tileSize = 25;

        // A path from default folder (Debug) to resource folder (Resources_Penguin)
        public static readonly string pathToResources = "../../Classes/Resources_Penguin/";
        public static readonly string level3File = "Level3.txt";

        // 2 dimentional (row, column) tiles array 
        public static TileBase[,] tiles = null;

        // This will be used when it creates the map
        public static int mapTotalRows;
        public static int mapTotalColumns;

        public static int playerInitialRow;
        public static int playerInitialColumn;

        public static int iglooRow;
        public static int iglooColumn;

        public static void LoadMap()
        {
            // Bring level0.txt
            string[] lines = File.ReadAllLines(Map.pathToResources + Map.level3File);

            // Set mapTotalRows and mapTotalColumns
            Map.mapTotalRows = lines.Length;
            Map.mapTotalColumns = lines[0].Length;

            //Map.tiles = new List<TileBase>();
            tiles = new TileBase[mapTotalRows, mapTotalColumns];

            // current row value
            int row = 0;

            foreach (string line in lines)
            {
                // Extract all the characters of current line
                char[] chars = line.ToCharArray();

                // Current column value
                int column = 0;

                foreach (char character in chars)
                {
                    TileBase tile = null;

                    switch (character)
                    {
                        // Create a Wall
                        case '#':
                            tile = new Wall(row, column);
                            break;

                        // Create an Empty Tile
                        case '.':
                            tile = new EmptyTile(row, column);
                            break;

                        // Create an enemy
                        case 'E':
                            tile = new Enemy(row, column);
                            break;

                        // Create an Empty Tile for the player
                        case 'P':
                            tile = new EmptyTile(row, column);

                            playerInitialRow = row;
                            playerInitialColumn = column;

                            break;

                        // Create a Food
                        case 'F':
                            tile = new Food(row, column);
                            break;

                        // Create an Igloo
                        case 'I':
                            tile = new Igloo(row, column);

                            iglooRow = row;
                            iglooColumn = column;

                            break;

                        // Default: Create an Empty tile
                        default:
                            tile = new EmptyTile(row, column);
                            break;
                    }
                    // Add the tile into the current position of tiles array
                    Map.tiles[row, column] = tile;

                    // Increase column (x) and go to the next character
                    column++;
                }
                // After checking all the characters of a line, increase row (y) and go to the next line
                row++;
            }
        }
    }
}
