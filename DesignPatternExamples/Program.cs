using ConsoleAppForTesting.Decorator.Beverages;
using ConsoleAppForTesting.Decorator.Condiments;
using System;

namespace DesignPatternExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoratorDemo();
        }

        /// <summary>
        /// Head First Design Patterns
        /// https://social.msdn.microsoft.com/Forums/en-US/72db1a43-00dd-4226-b9b1-a96f91a0b6e5/decorator-design-pattern-from-head-first?forum=Vsexpressvcs
        /// </summary>
        private static void DecoratorDemo()
        {

            Beverage beverage = new Expresso();
            beverage.SetSize(Size.Medium);
            Console.WriteLine(beverage.Description + " €" + beverage.Cost());

            Beverage houseBlend = new HouseBlend();
            houseBlend.SetSize(Size.Medium);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Soy(houseBlend);
            Console.WriteLine(houseBlend.Description + " $" + houseBlend.Cost());
        }
    }
}
