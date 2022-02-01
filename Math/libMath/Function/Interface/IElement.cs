namespace Utopia.Math.Function.Interface
{
    public interface IElement<T> where T : new()
    {
        T Value { get; set; }
        T Unit();
        T Evaluate(T element);
    }
}
