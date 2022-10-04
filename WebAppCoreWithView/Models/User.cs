using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCoreWithView.Models
{
    [Table("User")]
    public class User
    {
        public long Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? SurName { get; set; }
        public DateTime? CreateDate { get; set; }
        public bool? Active { get; set; }
        public string? Type { get; set; }
        public string? Email { get; set; }
    }
}