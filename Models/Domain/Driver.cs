using System.ComponentModel.DataAnnotations;

namespace F1_Racing_System.Models.Domain
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        // Nullable foreign key to Team
        public int? TeamId { get; set; }
        public Team Team { get; set; }

        // Navigation property
        public ICollection<DriverRace> DriverRaces { get; set; }
    }
}
