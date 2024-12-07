// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 2
// Submission Date: 2023-12-16

using System;
using MazeGame_Yeonhee.Classes.Entities;
using MazeGame_Yeonhee.Classes.Pathfinding;

namespace MazeGame_Yeonhee.Classes
{
    public static class GameManager
    {
        public static Form1 mainForm;
        public static Player player;
        public static Igloo igloo;

        public static bool isGameStop;

        public static void StartGame()
        {
            isGameStop = false;

            // Load the data of map
            Map.LoadMap();

            // Create a new player on the certain position
            player = new Player(Map.playerInitialRow, Map.playerInitialColumn);
            igloo = new Igloo(Map.iglooRow, Map.iglooColumn);
        }

        public static void SetMainForm(Form1 form)
        {
            mainForm = form;
        }

        public static void GameClear()
        {
            isGameStop = true;

            GameEndForm form = new GameEndForm("Yay! Game Clear!");
            form.Show();
        }

        public static void GameOver()
        {
            isGameStop = true;

            GameEndForm form = new GameEndForm("Game Over...");
            form.Show();
        }
    }
}
