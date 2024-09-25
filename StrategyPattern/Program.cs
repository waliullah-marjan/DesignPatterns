using StrategyPattern.Ducks;
using StrategyPattern.FlyBehaviors;
using StrategyPattern.Interfaces;
using StrategyPattern.QuackBehaviors;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy Pattern : Mini Duck Simulation\n");

            Duck mallardDuck = new MallardDuck();
            mallardDuck.FlyBehavior = new FlyWithWings();
            mallardDuck.QuackBehavior = new Quack();
            
            PrintDuckDetails(mallardDuck);

            Duck woodenDuck = new WoodenDuck();
            PrintDuckDetails(woodenDuck);

        }

        static void PrintDuckDetails(Duck duck)
        {
            duck.Display();
            duck.Fly();
            duck.Quack();

            Console.WriteLine();
        }
    }
}
