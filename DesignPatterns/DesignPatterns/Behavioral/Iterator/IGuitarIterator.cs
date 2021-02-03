namespace DesignPatterns.Behavioral.Iterator
{
    //abstract iterator
    public interface IGuitarIterator
    {
        Guitar First();
        Guitar Next();
        bool IsDone();
        Guitar CurrentItem();
    }
}
