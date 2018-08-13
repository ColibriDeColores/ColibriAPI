using ColibriAPI.Entities;
using System;

namespace ColibriAPI.Models.Entities
{
    public class Tournament : Entity
    {
        protected Tournament()
        {
            //Entity Framework Core Only
        }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
