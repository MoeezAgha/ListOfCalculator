using ListOfCalculator.SharedUI.ViewModel;
using Microsoft.AspNetCore.Components;

namespace ListOfCalculator.SharedUI.Componets
{
    public partial class PercentOffCalculator : ComponentBase
    {

        public PercentOffCalculatorModel percentOffCalculatorModel = new();

        public bool showResulDiv { get; set; } = false;
        public bool Error { get; set; } = false;
        public string? ErrorMessage { get; set; } = "";

        //protected override void OnInitialized()
        //{

        //    base.OnInitialized();
        //}


        //private void HandleValidSubmit()
        //{
        //    Console.WriteLine("HandleValidSubmit called: Processing the form");

        //}










    }
}
