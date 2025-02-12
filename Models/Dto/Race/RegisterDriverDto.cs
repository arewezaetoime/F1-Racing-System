using System.ComponentModel.DataAnnotations;

namespace F1_Racing_System.Models.Dto.Race
{
    public class RegisterDriverDto
    {
        [Required]
        public int DriverId { get; set; }

        [Required]
        public int RaceId { get; set; }
    }
}