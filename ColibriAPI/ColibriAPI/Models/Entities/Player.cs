using ColibriAPI.Entities;

namespace ColibriAPI.Models.Entities
{
    public class Player : Entity
    {
        protected Player()
        {
            //Entity Framework Core Only
        }

        public string PlayerTag { get; set; }
        public string PlayerIdentifier { get; set; }
        public User User { get; set; }
    }
}
