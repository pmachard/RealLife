namespace Utopia.Math.Function.Interface
{
    public interface IEl
    {
        double Unit();
        double Zero();
        double NaN();

        double Evaluate();

        IEl Add(IEl t2);
        IEl Supp(IEl t2);
        IEl Mult(IEl t2);
        IEl Div(IEl t2);

        public static IEl operator +(IEl left, IEl right)
        {
            return left.Add(right);
        }
        public static IEl operator -(IEl left, IEl right)
        {
            return left.Supp(right);
        }
        public static IEl operator *(IEl left, IEl right)
        {
            return left.Mult(right);
        }
        public static IEl operator /(IEl left, IEl right)
        {
            return left.Div(right);
        }
    }
}
