using System.ComponentModel.DataAnnotations;

namespace Back_end_.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Confirmpassword { get; set; }
    }
}
