namespace ListOfCalculator.SharedUI.ViewModel.TipViewModel
{

    public class TipCalculatorViewModel : TipCalculatorBaseClass
    {

        public double? TipAmount { get; set; }
        public double TipCalculator(double percentage)
        {
            return TotalPrice * percentage / 100;
        }


    }
}
