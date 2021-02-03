namespace DesignPatterns.Creational.FluentInterface
{
    //concrete object with many properties
    public class SportsTeam
    {
        public string TeamName { get; set; }
        public string Location { get; set; }
        public string Sport { get; set; }
        public bool IsChamp { get; set; }
        public int NumberOfPlayers { get; set; }
        private string champMessage => IsChamp ? "are the champoins of their league!" : "are not very good.";

        public override string ToString()
        {
            return $"{Sport} team {TeamName} is located in {Location} and {champMessage} Currently they have {NumberOfPlayers} of active players";
        }
    }
}
