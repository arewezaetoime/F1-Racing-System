﻿using System.ComponentModel.DataAnnotations;

namespace F1_Racing_System.Models.Domain
{
    public class Driver
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int? TeamId { get; set; }
        public Team Team { get; set; }

        public ICollection<DriverRace> DriverRaces { get; set; }
    }
}
