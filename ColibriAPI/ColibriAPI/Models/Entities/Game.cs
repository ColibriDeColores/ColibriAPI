using ColibriAPI.Entities;
using ColibriAPI.Models.Enums;
using System;
using System.Collections.Generic;

namespace ColibriAPI.Models.Entities
{
    public class Game : Entity
    {
        protected Game()
        {
            //Entity Framework Core Only
        }

        public TournamentStage TournamentStage { get; set; }
        public DateTime PlayDate { get; set; }
        public ICollection<Roster> Rosters { get; set; }

    }
}
