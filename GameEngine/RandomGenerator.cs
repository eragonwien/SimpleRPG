using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public static class RandomGenerator
    {
        private static Random randomGen;

        static RandomGenerator()
        {
            randomGen = new Random();
        }

        public static int GetRandomInt(int min, int max)
        {
            return randomGen.Next(min, max + 1);
        }
    }
}
