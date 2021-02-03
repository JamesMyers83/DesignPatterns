using System.Collections.Generic;
using System.Text.Json;

namespace DesignPatterns.Creational.Prototype
{
    //concrete prototype preventing circular object reference
    public class SafePerson : IClonable<SafePerson>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }

        private List<SafePerson> children;

        public List<SafePerson> Children
        {
            get 
            {
                return children;
            }
            set
            {
                if (value != null)
                {
                    children = new List<SafePerson>();

                    foreach (SafePerson child in value)
                    {
                        if (child.Father != null)
                        {
                            child.Father.Children = null;

                            if (child.Father == this)
                                child.Father = null;
                        }

                        if (child.Mother != null)
                        {
                            child.Mother.Children = null;

                            if (child.Mother == this)
                                child.Mother = null;
                        }

                        children.Add(child);
                    }
                }
            }
        }

        public SafePerson Father { get; set; }

        public SafePerson Mother { get; set; }

        public SafePerson Clone() => JsonSerializer.Deserialize<SafePerson>(ToString());

        public override string ToString()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            return JsonSerializer.Serialize(this, options);
        }
    }
}
