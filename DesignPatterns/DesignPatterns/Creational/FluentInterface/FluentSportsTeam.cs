namespace DesignPatterns.Creational.FluentInterface
{
    //fluent interface pattern for method chaining in plain language
    public class FluentSportsTeam
    {
        private SportsTeam team = new SportsTeam();

        public FluentSportsTeam NameOfTeam(string teamName)
        {
            team.TeamName = teamName;
            return this;
        }

        public FluentSportsTeam LocatedIn(string location)
        {
            team.Location = location;
            return this;
        }

        public FluentSportsTeam PlaysSport(string sport)
        {
            team.Sport = sport;
            return this;
        }

        public FluentSportsTeam AreCurrentChampionsInTheirLeague(bool isChamp)
        {
            team.IsChamp = isChamp;
            return this;
        }

        public FluentSportsTeam HasNumberOfActivePlayers(int players)
        {
            team.NumberOfPlayers = players;
            return this;
        }

        public SportsTeam GetSportsTeam() => team;
    }
}
