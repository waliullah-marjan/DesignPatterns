using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }

        public override double GetPrice()
        {
            return 0.99;
        }
    }
}
