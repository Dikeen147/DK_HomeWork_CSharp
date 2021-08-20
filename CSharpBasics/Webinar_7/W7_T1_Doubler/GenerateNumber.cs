using System;

namespace W7_T1_Doubler
{
    class GenerateNumber
    {
        private Random rnd;
        private int min;
        private int max;
        public GenerateNumber()
        {
            this.rnd = new Random();
            this.min = 56;
            this.max = 2412;
        }
        public GenerateNumber(int min, int max)
        {
            this.rnd = new Random();
            this.min = min;
            this.max = max;
        }
        public int GetRandNumber()
        {
            return rnd.Next(min, max);
        }
    }
}
