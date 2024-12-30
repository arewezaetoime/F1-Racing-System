using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1_Racing_System.Models.Domain
{
    [PrimaryKey(nameof(DriverId), nameof(RaceId))]
    public class DriverRace
    {
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int RaceId { get; set; }
        public Race Race { get; set; }

        public TimeSpan? FinishedFor { get; set; }

        [Required]
        [Range(0, 255)]
        public byte Points { get; set; }
    }
}
