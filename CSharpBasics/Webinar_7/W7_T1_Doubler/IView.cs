namespace W7_T1_Doubler
{
    interface IView
    {
        string Number { set; }
        string MultiCmdCount { set; }
        string Random { set; }
        string Steps { get; set; }
        string StepText { set; }
    }
}
