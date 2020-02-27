using System;
using System.Collections.Generic;

namespace ConsoleApp12
{
    class Program
    {
        public struct Mario
        {
            public enum Size
            {
                small,
                large
            }
            public int numOfLives;
            public string currentLevel;
            public Size sizeOfMario;
            public bool canShootFireballs;
            public bool isJumping;
            public int numOfCoins;

        }
        static void Main(string[] args)
        {
           Mario mario = new Mario();
            mario.numOfLives = 3;
            mario.currentLevel = "World 1-1";
            mario.sizeOfMario = Mario.Size.small;
            mario.canShootFireballs = false;
            mario.isJumping = false;

            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");

        }
    }
}
