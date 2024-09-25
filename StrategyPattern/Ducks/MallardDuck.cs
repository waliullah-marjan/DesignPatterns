using StrategyPattern.Interfaces;

namespace StrategyPattern.Ducks
{
    internal class MallardDuck : Duck
    {
        public MallardDuck() { }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck!");
        }
    }
}
