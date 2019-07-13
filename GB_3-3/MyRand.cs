using System;

namespace GB_3_3
{
    public class MyRand
    {
        private static Random rand = new Random();
        public static float Float(float min, float max) => (float) rand.NextDouble() * max + min;
    }
}