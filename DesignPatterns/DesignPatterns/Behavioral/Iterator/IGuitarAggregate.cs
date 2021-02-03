namespace DesignPatterns.Behavioral.Iterator
{
    //abstract aggregate
    public interface IGuitarAggregate
    {
        GuitarIterator CreateIterator();
    }
}
