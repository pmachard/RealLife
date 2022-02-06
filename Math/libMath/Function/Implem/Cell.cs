using Utopia.Math.Function.Interface;

namespace Utopia.Math.Function.Implem
{
    public class Cell<T> : ICell<T> where T : new()
    {
        public Cell()
        {
        }

        public IElement<T> Evaluate(IElement<T> element)
        {
            return null;
        }
    }
}
