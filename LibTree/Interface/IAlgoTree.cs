namespace Utopia.Algo.Tree.Interface
{
    public interface IAlgoTree<T,R>
    {
        IAlgoResult<R> Run(ITreeBinaryNode<T> source);
    }
}
