using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace DatingApp.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        [AllowNull, MaxLength(50), ]
        public string Username { get; set; }
    }
}
