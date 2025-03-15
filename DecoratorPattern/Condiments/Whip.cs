using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Condiments
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public override double GetPrice()
        {
            return _beverage.GetPrice() + 0.10;
        }
    }
}
