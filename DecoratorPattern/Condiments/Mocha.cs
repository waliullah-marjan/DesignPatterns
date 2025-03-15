using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override double GetPrice()
        {
            return _beverage.GetPrice() + 0.20;
        }
    }
}
