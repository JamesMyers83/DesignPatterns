namespace DesignPatterns.Behavioral.Visitor
{
    public class Photographer : IVisitor
    {
        public string Name { get; set; }

        public string VisitCity(City city) => $"{Name} visited {city.Name} and took photos";
        
        public string VisitAttraction(TouristAttraction attraction) => $"{Name} took photos of {attraction.Name} in the city of {attraction.InCity.Name}";
    }
}
