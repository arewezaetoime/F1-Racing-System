using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace F1_Racing_System.Models.Domain
{
    [PrimaryKey(nameof(DriverId), nameof(RaceId))]
    public class DriverRace
    {
        [Required]
        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }

        [Required]
        [ForeignKey("Race")]
        public int RaceId { get; set; }
        public virtual Race Race { get; set; }

        public TimeSpan? FinishedFor { get; set; }

        [Required]
        [Column(TypeName = "smallint")]
        public short Points { get; set; }
    }
}