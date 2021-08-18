using System.Windows.Forms;

namespace W7_T1_Doubler
{
    class Presenter
    {
        Model model;
        IView view;

        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
            ResetClick();
        }

        public void AddClick()
        {
            model.Add();
            view.Number = $"{model.Number}";
        }
        public void MultiClick()
        {
            model.Multi();
            view.Number = $"{model.Number}";
            view.MultiCmdCount = $"Кол-во удвоений: {model.MultiCmdCount}";
        }
        public void ResetClick()
        {
            model.Reset();
            view.Number = $"{model.Number}";
            view.MultiCmdCount = $"Кол-во удвоений: {model.MultiCmdCount}";
        }
        public void CancelClick()
        {
            model.Cancel();
            view.Number = $"{model.Number}";
            view.MultiCmdCount = $"Кол-во удвоений: {model.MultiCmdCount}";
        }
    }
}
