using System;
using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class ElConst : ElAbs
    {
        public double Value{ get; set; }

        public ElConst() 
        {
            Value = 0.0;
        }
        public ElConst(double value)
        {
            Value = value;
        }
        public ElConst(string valueString) 
        {
            try
            {
                Value = Convert.ToDouble(valueString);
            }
            catch (System.FormatException exc)
            {
                Value = double.NaN;
                throw exc;
            }
            catch (System.Exception exc)
            {
                Value = double.NaN;
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
            return Value;
        }
        public override void Fix(double valueFix)
        {
            Value = valueFix;
        }
    }
}
