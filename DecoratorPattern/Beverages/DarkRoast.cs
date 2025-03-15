using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast Coffee";
        }

        public override double GetPrice()
        {
            return 0.99;
        }
    }
}
