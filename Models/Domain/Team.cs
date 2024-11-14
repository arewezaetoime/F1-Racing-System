using System.ComponentModel.DataAnnotations;

namespace F1_Racing_System.Models.Domain
{
    public class Team
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        // Navigation property
        public ICollection<Driver> Drivers { get; set; }
    }
}
