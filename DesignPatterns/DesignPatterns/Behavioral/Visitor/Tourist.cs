namespace DesignPatterns.Behavioral.Visitor
{
    public class Tourist : IVisitor
    {
        public string Name { get; set; }

        public string VisitCity(City city) =>  $"{Name} visited {city.Name} as a tourist";

        public string VisitAttraction(TouristAttraction attraction) => $"{Name} visited {attraction.Name} in the city of {attraction.InCity.Name} as a tourist";
    }
}
