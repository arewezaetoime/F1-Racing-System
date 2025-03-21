﻿using System.ComponentModel.DataAnnotations;

namespace F1_Racing_System.Models.Domain
{
    public class Race
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<DriverRace> DriverRaces { get; set; }
    }
}
