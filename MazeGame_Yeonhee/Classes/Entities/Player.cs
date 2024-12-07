// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 2
// Submission Date: 2023-12-16

using System;
using System.Collections.Generic;
using System.Drawing;
using MazeGame_Yeonhee.Classes.Pathfinding;

namespace MazeGame_Yeonhee.Classes.Entities
{
    public class Player : TileBase
    {
        private static int maxEnergy = 100;
        private static int maxLives = 3;
        private static int maxWallBreakers = 3;

        private PlayerState currentState;
        private int currLives;
        private int currWallBreakers;

        // IDLE, UP, DOWN, LEFT, RIGHT, BREAKWALL
        private static string[] playerImages = {"PenguinNone.png",
                                                "PenguinUp.png",
                                                "PenguinDown.png",
                                                "PenguinLeft.png",
                                                "PenguinRight.png",
                                                "PenguinFight.png"};
        private string playerImageName;

        private List<Node> path;

        // Player initial energies = 100
        public Player(int row, int column) : base(row, column, maxEnergy)
        {
            this.currLives = maxLives;
            this.currWallBreakers = maxWallBreakers;
            this.currentState = PlayerState.IDLE;
            this.path = new List<Node>();
        }

        public PlayerState CurrentState { get => currentState; set => currentState = value; }
        public int CurrLives { get => currLives; set => currLives = value; }
        public int CurrWallBreakers { get => currWallBreakers; set => currWallBreakers = value; }

        public override void Draw(Graphics graphics)
        {
            Rectangle frame = base.DrawBackground(graphics);

            // Get the right player image based on its current state
            int index = (int)this.currentState;
            playerImageName = playerImages[index];

            // Draw the player image on the tile
            using (Image playerImage = Image.FromFile(Map.pathToResources + playerImageName))
            {
                graphics.DrawImage(playerImage, frame);
                // Delete the image data from the memory after drawing it.
            }
        }

        public void FindPath()
        {
            // Find a shortest path from player to igloo
            Node iglooNode = new Node(GameManager.igloo.Row, GameManager.igloo.Column, null, null);
            Node playerNode = new Node(this.Row, this.Column, null, iglooNode);
            path = AStar.FindPath(playerNode, iglooNode);
        }

        public void DrawPath(Graphics graphics)
        {
            for (int i = 0; i < this.path.Count - 1; i++)
            {
                Node start = this.path[i];
                Node end = this.path[i + 1];

                int yStart = (Map.tileSize * start.Row) + (Map.tileSize * 2 / 5);
                int xStart = (Map.tileSize * start.Column) + (Map.tileSize * 2 / 5);
                Point startPoint = new Point(xStart, yStart);

                int yEnd = (Map.tileSize * end.Row) + (Map.tileSize * 2 / 5);
                int xEnd = (Map.tileSize * end.Column) + (Map.tileSize * 2 / 5);

                Point endPoint = new Point(xEnd, yEnd);
                Pen myPen = new Pen(Color.Blue, 5);
                graphics.DrawLine(myPen, startPoint, endPoint);
                myPen.Dispose();
            }
        }

        public void Move()
        {
            int velocityX = 0;
            int velocityY = 0;

            switch (currentState)
            {
                // UP: (row - 1, column)
                case PlayerState.UP:
                    velocityY = -1;
                    break;

                // DOWN: (row + 1, column)
                case PlayerState.DOWN:
                    velocityY = 1;
                    break;

                // LEFT: (row, column - 1)
                case PlayerState.LEFT:
                    velocityX = -1;
                    break;

                // RIGHT: (row, column + 1)
                case PlayerState.RIGHT:
                    velocityX = 1;
                    break;

                default:
                    break;
            }
            // Get the tile to go through
            int nextColumn = base.Column + velocityX;
            int nextRow = base.Row + velocityY;

            TileBase nextTile = Map.tiles[nextRow, nextColumn];

            // Check if player can go through the tile
            if (nextTile != null && !IsOuterWall(nextTile))
            {
                if (nextTile is Wall)
                {
                    // If player doesn't have remaining wallBreakers, cannot go through the Wall
                    if (currWallBreakers == 0)
                    {
                        return;
                    }
                    // If player has remaining wallBreakers, use one
                    else
                    {
                        currentState = PlayerState.BREAKWALL;
                        currWallBreakers--;
                    }
                }

                // Move player
                base.Column += velocityX;
                base.Row += velocityY;

                // Every time player moves, they lose 2 energies
                Lose2Energies();

                if (nextTile is Food)
                {
                    // Add the food's energies to player's energy
                    base.Energies += nextTile.Energies;
                }

                if (nextTile is Igloo)
                {
                    // Game Clear
                    GameManager.GameClear();
                }

                if (nextTile is Enemy)
                {
                    // Reduce player energies by the enemy's energies (damage)
                    base.Energies -= nextTile.Energies;

                    // If player energies go down to 0, they lose 1 life
                    if (base.Energies <= 0)
                    {
                        LoseLife();
                    }
                }

                // Change the all tiles that player goes to Empty tile
                Map.tiles[base.Row, base.Column] = new EmptyTile(base.Row, base.Column);
            }
        }

        public void Lose2Energies()
        {
            // Lose 2 energies
            base.Energies -= 2;

            // If player energies are less or equal than 0, lose its 1 life
            if (base.Energies <= 0)
            {
                LoseLife();
            }
        }

        public void LoseLife()
        {
            // Reduce player lives
            currLives--;

            if (currLives > 0)
            {
                // Restore player energies and wallBreakers
                base.Energies = maxEnergy;
                currWallBreakers = maxWallBreakers;
            }
            else
            {
                // If player lives become 0, Game over
                GameManager.GameOver();
            }
        }

        // Check if the tile is an outer wall
        public bool IsOuterWall(TileBase tile)
        {
            // Return true if the tile is an outer wall
            return tile.Column == Map.mapTotalColumns - 1 || 
                tile.Row == Map.mapTotalRows - 1 ||
                tile.Row == 0 ||
                tile.Column == 0;
        }
    }
}
