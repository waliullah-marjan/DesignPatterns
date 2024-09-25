using StrategyPattern.Interfaces;

namespace StrategyPattern.FlyBehaviors
{
    internal class NoFly : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly!");
        }
    }
}
