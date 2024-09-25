using StrategyPattern.Interfaces;

namespace StrategyPattern.FlyBehaviors
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
