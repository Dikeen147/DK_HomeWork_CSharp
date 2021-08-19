using System.Collections.Generic;

namespace W7_T1_Doubler
{
    class Model
    {
        private bool flag;
        public int steps;
        private int number;
        private int endGameNumber;
        private int multiCmdCount;
        private Stack<int> stack;

        public int Steps { get => steps; set => steps = value; }
        public int Number => number;
        public bool Flag => flag;
        public int MultiCmdCount => multiCmdCount;
        public Stack<int> Stack => stack;
        public int RandomNumber
        { 
            get => endGameNumber;
            set => endGameNumber = value;
        }

        public Model() {}

        public void Add()
        {
            if (flag) return;

            number++;
            steps--;
            stack.Push(number);
            flag = number == endGameNumber;
        }
        public void Multi()
        {
            if (flag) return;

            multiCmdCount++;
            number *= 2;
            steps--;
            stack.Push(number);
            flag = number == endGameNumber;
        }
        public void Reset()
        {
            stack = new Stack<int>();
            number = 0;
            steps = 0;
            multiCmdCount = 0;
            endGameNumber = -1;
            flag = false;
        }
        public void Cancel()
        {
            var lastNumber = stack.Pop();
            var prevNumber = stack.Count == 0 ? 0 : stack.Peek();
            number = prevNumber;
            if (lastNumber >= 2 && multiCmdCount > 0 && lastNumber / 2 == prevNumber) multiCmdCount--;
        }
    }
}
