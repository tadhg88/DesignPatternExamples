namespace ConsoleAppForTesting.Decorator.Beverages
{
    public abstract class Beverage
    {
        public string _description = "Unknown Bev";

        public virtual string Description
        {
            get { return _description; }
        }

        public abstract double Cost();
    }

    public class Expresso : Beverage
    {
        public override string Description
        {
            get { return "Expresso"; }
        }

        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public override string Description
        {
            get { return "House Blend Coffee"; }
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
