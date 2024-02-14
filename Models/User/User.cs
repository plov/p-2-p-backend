using System.ComponentModel.DataAnnotations;

namespace p_2_p_backend.Models.User
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string RefreshToken { get; set; } = string.Empty;    
        public DateTime TokenCreated { get; set; } = DateTime.MinValue;
        public DateTime TokenExpires { get; set; } = DateTime.MinValue;

    }
}
