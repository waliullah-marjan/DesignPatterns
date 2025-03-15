using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Condiments
{
    public class SteamedMilk : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public SteamedMilk(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Steamed Milk";
        }

        public override double GetPrice()
        {
            return _beverage.GetPrice() + 0.10;
        }
    }
}
