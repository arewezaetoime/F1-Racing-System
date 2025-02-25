using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F1_Racing_System.Models.Dto.Race
{
    public class RaceResultDto
    {
        [Required]
        public int DriverId { get; set; }

        [Required]
        public TimeSpan FinishedFor { get; set; }
    }
}