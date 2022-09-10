namespace ListOfCalculator.SharedUI.ViewModel
{

    public class PercentOffCalculatorModel
    {

        public double OriginalPrice { get; set; }

        public double PercentOff { get; set; }

        public double FinalPrice { get; set; }

        public double Saved { get; set; }



        public void PercOffCalculator()
        {
            Saved = PercentOff * OriginalPrice;
            FinalPrice = OriginalPrice - Saved;


        }



    }
}
