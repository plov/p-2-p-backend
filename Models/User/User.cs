using System.ComponentModel.DataAnnotations;

namespace p_2_p_backend.Models.User
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string PasswordSalt { get; set; } = string.Empty;
        public string RefreshToken { get; set; } = string.Empty;    
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; } //= DateTime.MinValue;

    }
}
