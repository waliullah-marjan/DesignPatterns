using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator Pattern\n");


            PrintLine();

            Beverage beverage = new Espresso();
            PrintBeverage(beverage);

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            PrintBeverage(beverage2);

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            PrintBeverage(beverage3);

            PrintLine();
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(string.Format("{0,-50} ${1,4:N2}", beverage.GetDescription(), beverage.GetPrice()));
        }

        static void PrintLine()
        {
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
