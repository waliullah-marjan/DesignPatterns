using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }

        public override double GetPrice()
        {
            return 0.89;
        }
    }
}
