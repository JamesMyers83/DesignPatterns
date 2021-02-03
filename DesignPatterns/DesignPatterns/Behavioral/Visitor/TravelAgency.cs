using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Visitor
{
    //object structure
    public class TravelAgency
    {
        private List<IElement> elements;

        //add all locations to list        
        public TravelAgency()
        {
            elements = new List<IElement>();
            elements.Add(Chicago);
            elements.Add(theBean);

            elements.Add(Orlando);
            elements.Add(disneyWorld);

            elements.Add(NewYork);
            elements.Add(empireState);
        }

        //define default list of cities and tourist attractions
        public City Chicago => new City { Name = "Chicago" };
        public City Orlando => new City { Name = "Orlando" };
        public City NewYork => new City { Name = "New York" };

        public TouristAttraction theBean => new TouristAttraction
        {
            Name = "The Bean (Cloud)",
            InCity = Chicago
        };

        public TouristAttraction disneyWorld => new TouristAttraction
        {
            Name = "Disney World",
            InCity = Orlando
        };

        public TouristAttraction empireState => new TouristAttraction
        {
            Name = "Empire State Building",
            InCity = NewYork
        };

        //high-level interface to all the visitor to visit all elements
        public string VisitAllPlaces(IVisitor visitor)
        {
            string output = "";

            foreach (IElement element in elements)
                output += element.AcceptVisitor(visitor) + "\r\n";

            return output;
        }
    }
}
