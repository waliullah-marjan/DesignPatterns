namespace StrategyPattern.Interfaces
{
    internal abstract class Duck
    {
        internal IFlyBehavior? FlyBehavior { private get; set; }
        internal IQuackBehavior? QuackBehavior { private get; set; }
        public Duck() { }

        public abstract void Display();

        public void Fly()
        {
            FlyBehavior?.Fly();
        }

        public void Quack()
        {
            QuackBehavior?.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All duck can swim!");
        }
    }
}
