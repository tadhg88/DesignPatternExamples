namespace ConsoleAppForTesting.Decorator.Beverages
{
    public abstract class Beverage
    {
        private string _description = string.Empty;
        private Size _size = Size.Small;

        public virtual string Description
        {
            get { return _description; }
        }

        public virtual Size GetSize()
        {
            return _size;
        }

        public void SetSize(Size value)
        {
            _size = value;
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
            double cost = 1.99;

            if(GetSize() == Size.Medium)
            {
                cost += .50;
            }
            else if (GetSize() == Size.Large)
            {
                cost += 1.00;
            }

            return cost;
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
            double cost = .89;

            if (GetSize() == Size.Medium)
            {
                cost += .50;
            }
            else if (GetSize() == Size.Large)
            {
                cost += 1.00;
            }

            return cost;
        }
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }
}
