using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Beverages
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }

        public override double GetPrice()
        {
            return 1.99;
        }
    }
}
