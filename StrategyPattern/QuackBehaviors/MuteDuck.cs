using StrategyPattern.Interfaces;

namespace StrategyPattern.QuackBehaviors
{
    internal class MuteDuck : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Mute!");
        }
    }
}