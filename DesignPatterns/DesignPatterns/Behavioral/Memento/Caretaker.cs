using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Behavioral.Memento
{
    //caretaker class
    public class Caretaker
    {
        private List<Memento> mementos = new List<Memento>();
                
        public void AddMemento(Memento memento) => mementos.Add(memento);

        public Memento GetMemento(int index) => mementos[index];

        public Memento GetPreviousMemento()
        {
            int mementoCount = mementos.Count;

            if (mementoCount < 2)
                return null;
            else
                return mementos[mementoCount - 2];
        }

        public List<Memento> GetAllMementos() => mementos;

        public void RemoveMemento(Memento memento) => mementos.Remove(memento);
    }
}
