using System.Collections.Generic;

namespace W7_T1_Doubler
{
    class Presenter
    {
        Model model;
        IView view;
        public Presenter(IView view)
        {
            this.view = view;
            this.model = new Model();
            ResetClick();
        }

        public Stack<int> Stack => model.Stack;
        public int Number => model.Number;
        public int Steps { get => model.steps; set => model.steps = value; }
        public int RandonNumber
        { 
            get => model.RandomNumber; 
            set => model.RandomNumber = value;
        }

        public void AddClick()
        {
            model.Add();
            view.Number = $"{model.Number}";
            view.Steps = $"{model.Steps}";
        }
        public void MultiClick()
        {
            model.Multi();
            view.Number = $"{model.Number}";
            view.Steps = $"{model.Steps}";
            view.MultiCmdCount = $"Кол-во удвоений: {model.MultiCmdCount}";
        }
        public void ResetClick()
        {
            model.Reset();
            view.Number = $"{model.Number}";
            view.MultiCmdCount = $"Кол-во удвоений: {model.MultiCmdCount}";
            view.Steps = string.Empty;
            view.StepText = string.Empty;
            view.Random = string.Empty;
        }
        public void CancelClick()
        {
            model.Cancel();
            view.Number = $"{model.Number}";
            view.MultiCmdCount = $"Кол-во удвоений: {model.MultiCmdCount}";
        }

        public bool isEnabledCancel(int count)
        {
            return count > 0 ? true : false;
        }
        public bool isEnabledMulti(int number)
        {
            return number == 0 ? false : true;
        }
        public int StepCount(int randNumber)
        {
            int count = 0;

            while (randNumber > 0)
            {
                if (randNumber % 2 == 0)
                {
                    randNumber /= 2;
                    count++;
                }
                else
                {
                    randNumber -= 1;
                    count++;
                }
            }
            return count;
        }
    }
}
