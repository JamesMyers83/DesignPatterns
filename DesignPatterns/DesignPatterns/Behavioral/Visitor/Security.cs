namespace DesignPatterns.Behavioral.Visitor
{
    public class Security : IVisitor
    {
        public string Name { get; set; }

        public string VisitCity(City city) => $"{Name} was sent to {city.Name} to help secure the unrest";

        public string VisitAttraction(TouristAttraction attraction) => $"{Name} sent to {attraction.Name} in {attraction.InCity.Name} to secure its location";
    }
}
