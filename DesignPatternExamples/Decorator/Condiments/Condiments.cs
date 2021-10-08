using ConsoleAppForTesting.Decorator.Beverages;

namespace ConsoleAppForTesting.Decorator.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
    }

    public class Mocha : CondimentDecorator
    {
        private Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string Description
        {
            get { return beverage.Description + ", Mocha"; }
        }

        public override double Cost()
        {
            return .20 + beverage.Cost();
        }
    }

    public class Soy : CondimentDecorator
    {
        private Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return (.30 + beverage.Cost());
        }

        public override string Description
        {
            get { return beverage.Description + ", Soy"; }
        }
    }
}
