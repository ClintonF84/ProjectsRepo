using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resume.Data
{
    [Table("Users")]
    public class User : DbDefaults
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Resume Resume { get; set; }

        public User()
        {
            this.Email = string.Empty;
            this.Password = string.Empty;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
        }

        public User(string email): this()
        {
            this.Email = email;
        }

        public User(string email, string password): this(email)
        {
            this.Password = password;
        }

        public User(string email, string password, string firstName): this(email, password)
        {
            this.FirstName = firstName;
        }

        public User(string email, string password, string firstName, string lastName): this(email, password, firstName)
        {
            this.LastName = lastName;
        }
    }
}
