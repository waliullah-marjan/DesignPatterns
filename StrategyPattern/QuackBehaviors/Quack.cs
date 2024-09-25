using StrategyPattern.Interfaces;

namespace StrategyPattern.QuackBehaviors
{
    internal class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
