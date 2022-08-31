namespace ListOfCalculator.SharedUI.ViewModel
{
    public abstract class TipCalculatorBaseClass
    {

        public double TotalPrice { get; set; } = 0;





    }

    public class TipCalculatorViewModel : TipCalculatorBaseClass
    {

        public double? TipAmount { get; set; }
        public double TipCalculator(double percentage)
        {
            return (this.TotalPrice * percentage) / 100;
        }


    }

    public class TipCalculatorSharedFormula : TipCalculatorBaseClass
    {

        public TipCalculatorSharedFormula()
        {

            this.TotalPrice = 10;
        }
        public double? NumberofPeople { get; set; } = 2;

        public int? TipPercentage { get; set; } = 15;





        public double? TipCalculator()
        {

            return (this.TotalPrice * this.TipPercentage) / 100;
        }

        public double? TipPerPersonCal()
        {



            return (TipCalculator() / NumberofPeople);
        }

        public double? TotalAmount()
        {

            return (TotalPrice + this.TipCalculator());
        }


        public double? TotalPerPersonCal()
        {

            return TipPerPersonCal() + (this.TotalPrice / NumberofPeople);
        }







    }
}
