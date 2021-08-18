using System.Collections.Generic;

namespace W7_T1_Doubler
{
    class Model
    {
        private bool flag;
        private int number;
        private int endGameNumber;
        private int multiCmdCount;
        private Stack<int> stack;
        public int Number => number;
        public bool Check => flag;
        public int MultiCmdCount => multiCmdCount;

        public Model(int endGameNumber)
        {
            Reset();
            this.flag = false;
            this.endGameNumber = endGameNumber;
        }
        public void Add()
        {
            if (flag) return;
            number++;
            stack.Push(number);
            flag = number == endGameNumber;
        }
        public void Multi()
        {
            if (flag) return;
            multiCmdCount++;
            number *= 2;
            stack.Push(number);
            flag = number == endGameNumber;
        }
        public void Reset()
        {
            stack = new Stack<int>();
            number = 0;
            multiCmdCount = 0;
        }
        public void Cancel()
        {
            var lastNumber = stack.Pop();
            var prevNumber = stack.Peek();
            number = prevNumber;
            if (lastNumber != 2 && lastNumber / 2 == prevNumber) multiCmdCount--;
        }
    }
}
