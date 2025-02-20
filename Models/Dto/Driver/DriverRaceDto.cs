using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace F1_Racing_System.Models.Dto.Driver
{
    public class DriverRaceDto
    {
        public int DriverId { get; set; }
        public string DriverName { get; set; }  // Only include needed driver properties
        public int RaceId { get; set; }
        public string RaceName { get; set; }    // Only include needed race properties
        public TimeSpan? FinishedFor { get; set; }
        public short Points { get; set; }
    }
}