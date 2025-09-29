using System.ComponentModel.DataAnnotations;

namespace SSD_Lab1.Models
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Years in Business")]
        [Required]
        public int YearsInBusiness { get; set; }

        [Required]
        public string Website { get; set; }

        public string? Province { get; set; }

    }
}
