using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalInfoApi.Models
{
    public class UserDetails
    {
        [Key]
        public Guid ID { get; set; } = Guid.NewGuid();
        [Required]
        public string IDType { get; set; }
        [Required]
        public string IDNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string MaritalStatus { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
