using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class ElementConst<T> : IElement<T> where T: new()
    {
        public ElementConst() { }

        public T Value { get; set; }

        public T Unit()
        {
            return new T();
        }

        public T Evaluate(T value)
        {
            return this.Value;
        }
    }
}
