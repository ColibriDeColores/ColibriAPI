using ColibriAPI.Entities;
using System;

namespace ColibriAPI.Models.Entities
{
    public class User : Entity
    {
        protected User()
        {
            //Entity Framework Core Only
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid PasswordSalt { get; set; }
        public DateTime Birthday { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsOrganizer { get; set; }
        public bool IsPlayer { get; set; }
    }
}
