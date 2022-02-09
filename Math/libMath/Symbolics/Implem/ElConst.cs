using System;
using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class ElConst : ElAbs
    {
        public double ConstValue{ get; set; }

        public ElConst() 
        {
            ConstValue = 0.0;
        }
        public ElConst(double value)
        {
            ConstValue = value;
        }
        public ElConst(string valueString) 
        {
            try
            {
                ConstValue = Convert.ToDouble(valueString);
            }
            catch (System.FormatException exc)
            {
                ConstValue = double.NaN;
                throw exc;
            }
            catch (System.Exception exc)
            {
                ConstValue = double.NaN;
                throw exc;
            }
        }

        public override double Unit()
        {
            return 1.0;
        }
        public override double Zero()
        {
            return 1.0;
        }
        public override double NaN()
        {
            throw new NotImplementedException();
        }

        public override double Evaluate()
        {
            throw new NotImplementedException();
        }

        public override IEl Add(IEl t2)
        {
            throw new NotImplementedException();
        }
        public override IEl Supp(IEl t2)
        {
            throw new NotImplementedException();
        }
        public override IEl Mult(IEl t2)
        {
            throw new NotImplementedException();
        }
        public override IEl Div(IEl t2)
        {
            throw new NotImplementedException();
        }

    }
}
