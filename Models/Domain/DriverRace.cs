using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace F1_Racing_System.Models.Domain
{
    public class DriverRace
    {
        [Key, Column(Order = 0)]
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        [Key, Column(Order = 1)]
        public int RaceId { get; set; }
        public Race Race { get; set; }

        public TimeSpan? FinishedFor { get; set; }

        [Required]
        [Range(0, 255)]
        public byte Points { get; set; }
    }
}
