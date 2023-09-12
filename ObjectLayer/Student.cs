using System.ComponentModel.DataAnnotations;

namespace ObjectLayer
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Phone(ErrorMessage = "Invalid Telephon Number")]
        public string Telephon { get; set; }

        public DateTime BirthDay { get; set; }
    }
}