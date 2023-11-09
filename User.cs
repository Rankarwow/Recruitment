using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Recruitment
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string? Email { get; set; }

        //ITU-T E.164 states longest phone number is 15 digits including 3 digits country code
        [Required]
        [MaxLength(15)]
        public string? PhoneNumber { get; set; }
    }
}