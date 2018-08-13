using ColibriAPI.Entities;

namespace ColibriAPI.Models.Entities
{
    public class Entry : Entity
    {
        protected Entry()
        {
            //Entity Framework Core Only
        }

        public Tournament Tournament { get; set; }
        public Team Team { get; set; }
    }
}
