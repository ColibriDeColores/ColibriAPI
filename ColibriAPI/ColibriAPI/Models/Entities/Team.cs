using ColibriAPI.Entities;
using System.Collections.Generic;

namespace ColibriAPI.Models.Entities
{
    public class Team : Entity
    {
        protected Team()
        {
            //Entity Framework Core Only
        }

        public string Name { get; set; }
        public ICollection<Player> TeamPlayers { get; set; }
        public ICollection<Roster> Rosters { get; set; }
        public ICollection<Entry> Entries { get; set; }
    }
}
