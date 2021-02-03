namespace DesignPatterns.Behavioral.Iterator
{
    //concrete iterator
    public class GuitarIterator : IGuitarIterator
    {
        private GuitarAggregate aggregate;
        private int current = 0;
        private int step = 1;

        public GuitarIterator(GuitarAggregate guitarAggregate)
        {
            aggregate = guitarAggregate;
        }
        public bool IsDone() => current >= aggregate.Count;

        public Guitar CurrentItem() => aggregate.GetGuitar(current);

        public Guitar First()
        {
            current = 0;
            return aggregate.GetGuitar(current);
        }
        
        public Guitar Next()
        {
            current += step;

            return IsDone() ? null : aggregate.GetGuitar(current);
        }
    }
}
