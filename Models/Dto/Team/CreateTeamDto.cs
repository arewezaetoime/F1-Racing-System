using System.ComponentModel.DataAnnotations;

namespace F1_Racing_System.Models.Dto.Team
{
    public class CreateTeamDto
    {
        [Required]
        [StringLength(15, ErrorMessage = "Team name cannot be longer than 15 characters")]
        public string Name { get; set; }
    }
}
