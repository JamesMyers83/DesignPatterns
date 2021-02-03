using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Structural.Composite
{
    //composite class
    public class Composite : IComponent
    {
        private List<IComponent> children;

        public string Name { get; set; }
        public string PlaceOfOrigin { get; set; }

        public double Salary 
        { 
            get
            {
                if (children != null)
                    return children.Sum(c => c.Salary);
                else
                    return 0;
            }
            set { }
        }

        public override string ToString()
        {
            return $"{Name} located in {PlaceOfOrigin} - Total salary: {Salary.ToString("C0")}";
        }

        public void AddChild(IComponent child)
        {
            if (children == null)
                children = new List<IComponent>();
            
            children.Add(child);
        }

        public void RemoveChild(IComponent child)
        {
            children.Remove(child);
        }
    }
}
