namespace W7_T2_GuessTheNumber
{
    class Presenter
    {
        Model model;
        IView view;

        public Presenter(Model model, IView view)
        {
            this.model = model;
            this.view = view;
        }
        public void EnteredClick(string enteredNumber)
        {
            model.Entered(enteredNumber);
            view.Result = model.Result;
            view.TryCount = $"Количество попыток: {model.TryCount}";
        }
    }
}
