using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Condiments
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public override double GetPrice()
        {
            return _beverage.GetPrice() + 0.15;
        }
    }
}
