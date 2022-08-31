using ListOfCalculator.SharedUI.ViewModel;
using Microsoft.AspNetCore.Components;

namespace ListOfCalculator.SharedUI.Componets
{
    public partial class SingleTipCalculator : ComponentBase
    {
        public TipCalculatorViewModel tipCalculatorViewModel = new();
        public readonly TipCalculatorFromula tipCalculatorFromula = new();
        public bool showTableGrid { get; set; } = false;
        public bool Error { get; set; } = false;
        public string? ErrorMessage { get; set; } = "";

        protected override void OnInitialized()
        {

            base.OnInitialized();
        }

        public void CalculateTip()
        {
            if (tipCalculatorViewModel.TotalPrice > 0 && tipCalculatorViewModel.TotalPrice != 0)
            {
                showTableGrid = true;
                Error = false;
            }
            else
            {
                Error = true;
                showTableGrid = false;
                ErrorMessage = "Value must be greater than or equal to 1";


            }


        }
        private void HandleValidSubmit()
        {
            Console.WriteLine("HandleValidSubmit called: Processing the form");

        }



    }
}
