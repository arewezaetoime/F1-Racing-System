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

// {
//   "raceId": 2,
//   "Results": [
//     {
//       "driverId": 1,
//       "finishedFor": "01:32:03"
//     },
//     {
//       "driverId": 2,
//       "finishedFor": "01:32:10"
//     },
//     {
//       "driverId": 3,
//       "finishedFor": "01:32:15"
//     }
//   ]
// }