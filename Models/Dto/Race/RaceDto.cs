using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using F1_Racing_System.Models.Domain;

namespace F1_Racing_System.Models.Dto.Race
{
    public class RaceDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<DriverRace> DriverRaces { get; set; }
    }
}