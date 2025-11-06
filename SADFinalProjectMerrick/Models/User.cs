using SADFinalProjectMerrick.Models;
using SADFianlProjectMerrick.Models;
using System.ComponentModel.DataAnnotations;

namespace SADFianlProjectMerrick.Models
{
    public class User 
    {
        // Primary Key (PK)
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
