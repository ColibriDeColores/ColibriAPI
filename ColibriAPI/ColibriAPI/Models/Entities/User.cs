using ColibriAPI.Entities;
using System;

namespace ColibriAPI.Models.Entities
{
    public class User : Entity
    {
        public User()
        {
            //Entity Framework Core Only
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
    }
}
