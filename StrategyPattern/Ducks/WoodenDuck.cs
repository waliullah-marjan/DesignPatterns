using StrategyPattern.FlyBehaviors;
using StrategyPattern.Interfaces;
using StrategyPattern.QuackBehaviors;

namespace StrategyPattern.Ducks
{
    internal class WoodenDuck : Duck
    {

        public WoodenDuck()
        {
            FlyBehavior = new NoFly();
            QuackBehavior = new MuteDuck();
        } 
        public override void Display()
        {
            Console.WriteLine("I'm just an wooden duck!");
        }
    }
}
