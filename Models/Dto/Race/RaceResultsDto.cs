using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace F1_Racing_System.Models.Dto.Race
{
    public class RaceResultsDto
    {
        [Required]
        public int RaceId { get; set; }

        [Required]
        public List<RaceResultDto> Results { get; set; }
    }
}