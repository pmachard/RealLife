using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class ElVar : ElAbs
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public ElVar() 
        { 
        }
        public ElVar(double value)
        {
            Value = value;
        }
        public ElVar(string varName)
        {
            Name = varName;
        }

        public override double Unit()
        {
            throw new System.NotImplementedException();
        }
        public override double Zero()
        {
            throw new System.NotImplementedException();
        }
        public override double NaN()
        {
            throw new System.NotImplementedException();
        }

        public override double Evaluate()
        {
            throw new System.NotImplementedException();
        }

        public override IEl Add(IEl right)
        {
            throw new System.NotImplementedException();
        }
        public override IEl Supp(IEl right)
        {
            throw new System.NotImplementedException();
        }
        public override IEl Mult(IEl right)
        {
            throw new System.NotImplementedException();
        }
        public override IEl Div(IEl right)
        {
            throw new System.NotImplementedException();
        }
    }
}
