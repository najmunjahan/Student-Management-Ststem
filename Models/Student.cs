using System.ComponentModel.DataAnnotations;

namespace Student_Management_Ststem.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(1, 120)]
        public int Age { get; set; }
    }
}
