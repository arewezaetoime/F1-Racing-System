using System.ComponentModel.DataAnnotations;

namespace F1_Racing_System.Models.Dto.Driver
{
    public class DriverDto
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int? TeamId { get; set; }

        // public string? TeamName { get; set; }

        // public int? TotalPoints { get; set; }
    }
}