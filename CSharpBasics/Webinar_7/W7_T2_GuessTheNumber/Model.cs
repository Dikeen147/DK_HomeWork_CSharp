using System;

namespace W7_T2_GuessTheNumber
{
    class Model
    {
        private int randomNumber;
        private int tryCount;
        private string result;
        public Random rnd = new Random();
        public int GetRandomNumber => randomNumber;
        public string Result => result;
        public int TryCount => tryCount;
        public Model()
        {
            this.randomNumber = rnd.Next(0, 100) + 1;
        }
        public void Entered(string enteredNumber)
        {
            int number = int.Parse(enteredNumber);

            if (number > randomNumber)
            {
                tryCount++;
                this.result = $"Число меньше, чем {number}";
            }
            if (number < randomNumber)
            {
                tryCount++;
                this.result = $"Число больше, чем {number}";
            }
            if (number == randomNumber)
            {
                this.result = $"Вы угадали! Это число {number}";
            }
        }
    }
}
