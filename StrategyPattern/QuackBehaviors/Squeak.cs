using StrategyPattern.Interfaces;

namespace StrategyPattern.QuackBehaviors
{
    internal class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
