using System.Text.Json;

namespace DesignPatterns.Creational.Prototype
{
    //concrete prototype which will cause circular object reference
    public class Person : IClonable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public Person[] Children { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }

        public Person Clone() => JsonSerializer.Deserialize<Person>(ToString());

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
