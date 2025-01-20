using System.ComponentModel.DataAnnotations;
using F1_Racing_System.Models.Domain;

namespace F1_Racing_System.Models.Dto
{
    public class TeamDto
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
