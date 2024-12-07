// Assignment #: 10
// Full Name: Yeonhee Do
// Student ID: 2211198
// Version #: 2
// Submission Date: 2023-12-16

using System;

namespace MazeGame_Yeonhee.Classes.Entities
{
    public class RNG : Random
    {
        private static RNG instance = null;

        private RNG() : base() { }

        public static RNG Get_Instance()
        {
            if (instance == null)
            {
                instance = new RNG();
            }
            return instance;
        }
    }
}
