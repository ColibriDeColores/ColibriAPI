using ColibriAPI.Entities;
using System.Collections.Generic;

namespace ColibriAPI.Models.Entities
{
    public class Roster : Entity
    {
        protected Roster()
        {
            //Entity Framework Core Only
        }

        public Tournament Tournament { get; set; }
        public Team Team { get; set; }
        public ICollection<Player> RosterPlayers { get; set; }
        public Game Game { get; set; }
    }
}
