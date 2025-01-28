using System.ComponentModel.DataAnnotations;
using F1_Racing_System.Models.Domain;
using F1_Racing_System.Models.Dto.Driver;

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
        public ICollection<DriverDto> Drivers { get; set; }
    }
}
