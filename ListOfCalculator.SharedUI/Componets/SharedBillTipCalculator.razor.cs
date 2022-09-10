using ListOfCalculator.SharedUI.ViewModel;
using Microsoft.AspNetCore.Components;

namespace ListOfCalculator.SharedUI.Componets
{
    public partial class SharedBillTipCalculator : ComponentBase
    {
        public TipCalculatorSharedFormula tipCalculatorViewModel = new TipCalculatorSharedFormula();

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


        public void Calc(string step)
        {
            if (2 < step.Length)
            {
                int number = Convert.ToInt32(step.Substring(0, 2));
                tipCalculatorViewModel.TipPercentage = number;
            }
            else
            {
                tipCalculatorViewModel.TipPercentage = Convert.ToInt32(step);
            }

        }




    }
}
