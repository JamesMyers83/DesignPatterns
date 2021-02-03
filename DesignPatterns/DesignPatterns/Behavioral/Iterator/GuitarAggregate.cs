using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Iterator
{
    //concrete aggregate
    public class GuitarAggregate : IGuitarAggregate
    {
        private List<Guitar> guitarList = new List<Guitar>();

        public GuitarIterator CreateIterator()
        {
            return new GuitarIterator(this);
        }

        public int Count => guitarList.Count;

        public void AddGuitar(Guitar guitar) => guitarList.Add(guitar);
        
        public void RemoveGuitar(Guitar guitar) => guitarList.Remove(guitar);

        public Guitar GetGuitar(int position) => guitarList[position];
    }
}
