using ConsoleAppForTesting.Decorator.Beverages;

namespace ConsoleAppForTesting.Decorator.Condiments
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        public abstract override string Description { get; }

        public override Size GetSize()
        {
            return beverage.GetSize();
        }
    }

    public class Mocha : CondimentDecorator
    {
        // private Beverage beverage;

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
            double cost = beverage.Cost();

            if (GetSize() == Size.Small)
            {
                cost += .10;
            }
            else if (GetSize() == Size.Medium)
            {
                cost += .20;
            }
            else if (GetSize() == Size.Large)
            {
                cost += .30;
            }

            return cost;
        }
    }

    public class Soy : CondimentDecorator
    {
        //private Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            double cost = beverage.Cost();

            if (GetSize() == Size.Small)
            {
                cost += .10;
            }
            else if (GetSize() == Size.Medium)
            {
                cost += .20;
            }
            else if (GetSize() == Size.Large)
            {
                cost += .30;
            }

            return cost;
        }

        public override string Description
        {
            get { return beverage.Description + ", Soy"; }
        }
    }
}
